#!/usr/bin/env python3
"""Normalize Cartesia's public WebSocket contracts to AsyncAPI 3."""

from pathlib import Path
import argparse
import json
import re
import subprocess

import yaml


USER_AGENT = "tryAGI-Cartesia-SDK/1.0"
ASYNCAPI_FENCE = re.compile(r"````yaml[^\n]*\n(?P<document>.*?)\n````", re.DOTALL)
VERSION = re.compile(r"\b\d{4}-\d{2}-\d{2}\b")
PATH_VARIABLE = re.compile(r"{(?P<name>[A-Za-z0-9_]+)}")

CONTRACTS = {
    "agents": {
        "source_url": "https://docs.cartesia.ai/api-reference/agents/agent-websocket.md",
        "title": "Cartesia Managed Agents WebSocket API",
        "address": "/v1/agents/websocket/{agent_id}",
        "channel": "managedAgent",
        "server_description": "Cartesia Managed Agents WebSocket endpoint.",
        "expected_send": {
            "agentSessionCreateEvent",
            "agentAudioInputEvent",
            "agentDtmfInputEvent",
            "agentClientToolResultEvent",
        },
        "expected_receive": {
            "agentSessionReadyEvent",
            "agentAudioOutputEvent",
            "agentAudioOutputClearEvent",
            "agentDtmfOutputEvent",
            "agentClientToolCallEvent",
            "agentTurnStartedEvent",
            "agentTurnOutputTextDeltaEvent",
            "agentTurnEndedEvent",
            "agentErrorEvent",
        },
    },
    "tts": {
        "source_url": "https://docs.cartesia.ai/api-reference/tts/websocket.md",
        "title": "Cartesia Realtime Text-to-Speech WebSocket API",
        "address": "/tts/websocket",
        "channel": "textToSpeech",
        "server_description": "Cartesia realtime text-to-speech WebSocket endpoint.",
        "expected_send": {"generationRequest", "cancelRequest"},
        "expected_receive": {
            "chunkResponse",
            "flushDoneResponse",
            "doneResponse",
            "timestampsResponse",
            "phonemeTimestampsResponse",
            "ttsErrorResponse",
        },
    },
    "stt": {
        "source_url": "https://docs.cartesia.ai/api-reference/stt/websocket.md",
        "title": "Cartesia Realtime Speech-to-Text WebSocket API",
        "address": "/stt/websocket",
        "channel": "speechToText",
        "server_description": "Cartesia manual-finalization speech-to-text WebSocket endpoint.",
        "expected_send": {"sttAudioData", "sttFinalizeCommand", "sttCloseCommand"},
        "expected_receive": {
            "sttTranscriptResponse",
            "sttFlushDoneResponse",
            "sttDoneResponse",
            "sttErrorResponse",
        },
    },
    "stt-turns": {
        "source_url": "https://docs.cartesia.ai/api-reference/stt/turns/websocket.md",
        "title": "Cartesia Turn-Detecting Speech-to-Text WebSocket API",
        "address": "/stt/turns/websocket",
        "channel": "speechToTextTurns",
        "server_description": "Cartesia turn-detecting speech-to-text WebSocket endpoint.",
        "expected_send": {
            "sttTurnsAudioData",
            "sttTurnsCloseCommand",
            "sttTurnsConfigCommand",
        },
        "expected_receive": {
            "sttTurnsConnected",
            "sttTurnsTurnStart",
            "sttTurnsTurnUpdate",
            "sttTurnsTurnEagerEnd",
            "sttTurnsTurnResume",
            "sttTurnsTurnEnd",
            "sttErrorResponse",
        },
    },
}

SCHEMA_NAME_OVERRIDES = {
    # Keep the completion schema distinct from FlushDoneResponse so generated
    # discriminator mappings cannot confuse the overlapping type names.
    "doneResponse": "GenerationDoneResponse",
    "sttAudioData": "STTAudioData",
    "sttFinalizeCommand": "STTFinalizeCommand",
    "sttCloseCommand": "STTCloseCommand",
    "sttTurnsAudioData": "STTTurnsAudioData",
}


def fetch_text(url: str) -> str:
    result = subprocess.run(
        [
            "curl",
            "--fail",
            "--silent",
            "--show-error",
            "--location",
            "--retry",
            "5",
            "--retry-delay",
            "2",
            "--retry-all-errors",
            "--connect-timeout",
            "30",
            "--max-time",
            "300",
            "--user-agent",
            USER_AGENT,
            url,
        ],
        check=False,
        capture_output=True,
        text=True,
    )
    if result.returncode != 0:
        raise SystemExit(f"Failed to fetch {url}: {result.stderr.strip()}")
    return result.stdout


def clean_schema(value: object) -> object:
    if isinstance(value, dict):
        return {
            key: clean_schema(item)
            for key, item in value.items()
            if not key.startswith("x-parser-")
        }
    if isinstance(value, list):
        return [clean_schema(item) for item in value]
    return value


def get_version(source: dict[str, object]) -> str:
    candidates: list[object] = []
    parameters = source.get("parameters")
    if isinstance(parameters, list):
        candidates.extend(
            parameter
            for parameter in parameters
            if isinstance(parameter, dict) and parameter.get("id") == "cartesia_version"
        )

    bindings = source.get("bindings")
    if isinstance(bindings, list):
        for binding in bindings:
            if not isinstance(binding, dict) or binding.get("protocol") != "ws":
                continue
            value = binding.get("value")
            query = value.get("query") if isinstance(value, dict) else None
            properties = query.get("properties") if isinstance(query, dict) else None
            if isinstance(properties, dict) and "cartesia_version" in properties:
                candidates.append(properties["cartesia_version"])

    versions = set(VERSION.findall(json.dumps(candidates)))
    if len(versions) != 1:
        raise SystemExit(f"Expected one Cartesia WebSocket version, found {sorted(versions)}.")
    return versions.pop()


def get_query_binding(
    source: dict[str, object],
    contract_name: str,
    schemas: dict[str, object],
) -> dict[str, object] | None:
    bindings = source.get("bindings")
    if not isinstance(bindings, list):
        return None

    raw_query = None
    for binding in bindings:
        if not isinstance(binding, dict) or binding.get("protocol") != "ws":
            continue
        value = binding.get("value")
        if isinstance(value, dict) and isinstance(value.get("query"), dict):
            raw_query = value["query"]
            break
    if raw_query is None:
        return None

    query = clean_schema(raw_query)
    if not isinstance(query, dict):
        raise SystemExit(f"{contract_name} WebSocket query binding is invalid.")
    properties = query.get("properties")
    if not isinstance(properties, dict):
        raise SystemExit(f"{contract_name} WebSocket query properties are missing.")

    required = query.get("required")
    required_names = set(required) if isinstance(required, list) else set()
    missing = {"model", "encoding", "sample_rate", "cartesia_version"} - required_names
    if missing:
        raise SystemExit(
            f"{contract_name} WebSocket query binding is incomplete: missing {sorted(missing)}."
        )

    sample_rate = properties.get("sample_rate")
    if isinstance(sample_rate, dict) and sample_rate.get("format") == "integer":
        sample_rate["type"] = "integer"
        sample_rate["format"] = "int32"

    keyterm = properties.get("keyterm")
    if isinstance(keyterm, dict):
        keyterm["type"] = "array"
        keyterm["items"] = {"type": "string"}
        keyterm.pop("example", None)

    schema_prefix = "SpeechToTextTurns" if contract_name == "stt-turns" else "SpeechToText"
    for property_name in ("model", "encoding", "cartesia_version"):
        property_schema = properties.get(property_name)
        if not isinstance(property_schema, dict) or not isinstance(property_schema.get("enum"), list):
            continue
        suffix = {
            "model": "Model",
            "encoding": "Encoding",
            "cartesia_version": "ApiVersion",
        }[property_name]
        schema_name = f"{schema_prefix}{suffix}"
        schemas[schema_name] = property_schema
        properties[property_name] = {"$ref": f"#/components/schemas/{schema_name}"}

    return {"ws": {"query": query}}


def get_schema_name(message_id: str, raw_schema: dict[str, object]) -> str:
    if message_id in SCHEMA_NAME_OVERRIDES:
        return SCHEMA_NAME_OVERRIDES[message_id]
    schema_name = raw_schema.get("x-parser-schema-id")
    if isinstance(schema_name, str) and re.fullmatch(r"[A-Za-z][A-Za-z0-9]*", schema_name):
        return schema_name
    raise SystemExit(f"Message {message_id} has no stable schema id.")


def require_security_schemes(source: dict[str, object]) -> None:
    schemes = source.get("securitySchemes")
    if not isinstance(schemes, list):
        raise SystemExit("WebSocket security schemes were not found.")
    available = {
        (scheme.get("name"), scheme.get("in"))
        for scheme in schemes
        if isinstance(scheme, dict)
    }
    required = {("X-API-Key", "header"), ("access_token", "query")}
    if not required <= available:
        raise SystemExit(f"WebSocket security schemes are incomplete: found {sorted(available)}.")


def normalize(source: dict[str, object], contract_name: str) -> dict[str, object]:
    contract = CONTRACTS[contract_name]
    address = source.get("address")
    if address != contract["address"]:
        raise SystemExit(f"Unexpected {contract_name} WebSocket address: {address!r}.")
    require_security_schemes(source)

    raw_operations = source.get("operations")
    if not isinstance(raw_operations, list):
        raise SystemExit(f"{contract_name} WebSocket operations were not found.")

    schemas: dict[str, object] = {}
    messages: dict[str, object] = {}
    channel_messages: dict[str, object] = {}
    operations: dict[str, object] = {}
    send_messages: set[str] = set()
    receive_messages: set[str] = set()
    channel_name = str(contract["channel"])

    for raw_operation in raw_operations:
        if not isinstance(raw_operation, dict):
            continue
        operation_id = str(raw_operation.get("id", ""))
        if operation_id.startswith("send"):
            action = "send"
            direction_messages = send_messages
        elif operation_id.startswith("receive"):
            action = "receive"
            direction_messages = receive_messages
        else:
            raise SystemExit(f"Unknown {contract_name} WebSocket operation {operation_id!r}.")

        raw_messages = raw_operation.get("messages")
        if not isinstance(raw_messages, list):
            raise SystemExit(f"Operation {operation_id} does not contain messages.")
        for raw_message in raw_messages:
            if not isinstance(raw_message, dict):
                continue
            message_id = str(raw_message.get("id", ""))
            raw_schema = raw_message.get("jsonPayloadSchema")
            if not message_id or not isinstance(raw_schema, dict):
                raise SystemExit(f"Operation {operation_id} contains an invalid message.")
            schema_name = get_schema_name(message_id, raw_schema)
            if schema_name in schemas:
                raise SystemExit(f"Duplicate {contract_name} WebSocket schema {schema_name}.")

            direction_messages.add(message_id)
            schema = clean_schema(raw_schema)
            if isinstance(schema, dict):
                schema.setdefault("description", raw_message.get("description", ""))
            schemas[schema_name] = schema

            is_binary = raw_schema.get("type") == "string" and raw_schema.get("format") == "binary"
            is_text = raw_schema.get("type") == "string" and not is_binary
            if is_binary:
                content_type = "application/octet-stream"
            elif is_text:
                content_type = "text/plain"
            else:
                content_type = "application/json"
            messages[schema_name] = {
                "name": schema_name,
                "title": raw_message.get("title", schema_name),
                "description": raw_message.get("description", ""),
                "contentType": content_type,
                "payload": {"$ref": f"#/components/schemas/{schema_name}"},
            }
            channel_messages[schema_name] = {"$ref": f"#/components/messages/{schema_name}"}
            operations[f"{action}{schema_name}"] = {
                "action": action,
                "channel": {"$ref": f"#/channels/{channel_name}"},
                "messages": [{"$ref": f"#/channels/{channel_name}/messages/{schema_name}"}],
            }

    missing_send = set(contract["expected_send"]) - send_messages
    missing_receive = set(contract["expected_receive"]) - receive_messages
    if missing_send or missing_receive:
        raise SystemExit(
            f"{contract_name} WebSocket contract is incomplete: "
            f"missing send={sorted(missing_send)}, receive={sorted(missing_receive)}."
        )

    version = get_version(source)
    variables: dict[str, object] = {}
    parameters = source.get("parameters")
    parameter_descriptions: dict[str, str] = {}
    if isinstance(parameters, list):
        parameter_descriptions = {
            str(parameter.get("id")): str(parameter.get("description", "")).strip()
            for parameter in parameters
            if isinstance(parameter, dict)
        }
    for variable_name in PATH_VARIABLE.findall(str(address)):
        variables[variable_name] = {
            "description": parameter_descriptions.get(variable_name, f"{variable_name} value."),
        }
    if contract_name in {"agents", "tts"}:
        variables["cartesia_version"] = {
            "description": "Cartesia API version.",
            "default": version,
        }

    channel: dict[str, object] = {
        "address": address,
        "messages": channel_messages,
    }
    query_binding = get_query_binding(source, contract_name, schemas)
    if query_binding is not None:
        channel["bindings"] = query_binding

    return {
        "asyncapi": "3.0.0",
        "info": {
            "title": contract["title"],
            "version": version,
            "description": source.get("description", ""),
        },
        "servers": {
            "production": {
                "host": "api.cartesia.ai",
                "pathname": address,
                "protocol": "wss",
                "description": contract["server_description"],
                "variables": variables,
                "security": [
                    {"$ref": "#/components/securitySchemes/apiKey"},
                    {"$ref": "#/components/securitySchemes/accessToken"},
                ],
            }
        },
        "channels": {channel_name: channel},
        "operations": operations,
        "components": {
            "securitySchemes": {
                "apiKey": {
                    "type": "apiKey",
                    "in": "header",
                    "name": "X-API-Key",
                    "description": "API key for trusted server applications.",
                },
                "accessToken": {
                    "type": "apiKey",
                    "in": "query",
                    "name": "access_token",
                    "description": "Short-lived token for browser and mobile applications.",
                },
            },
            "messages": messages,
            "schemas": schemas,
        },
    }


def main() -> None:
    parser = argparse.ArgumentParser()
    parser.add_argument("output", type=Path)
    parser.add_argument("--contract", choices=CONTRACTS, default="agents")
    args = parser.parse_args()

    contract = CONTRACTS[args.contract]
    markdown = fetch_text(str(contract["source_url"]))
    match = ASYNCAPI_FENCE.search(markdown)
    if match is None:
        raise SystemExit(f"{args.contract} AsyncAPI document was not found.")
    source = yaml.safe_load(match.group("document"))
    if not isinstance(source, dict):
        raise SystemExit(f"{args.contract} AsyncAPI document is invalid.")

    document = normalize(source, args.contract)
    args.output.write_text(json.dumps(document, indent=2) + "\n", encoding="utf-8")
    print(
        f"Assembled Cartesia {args.contract} AsyncAPI {document['info']['version']}: "
        f"{len(document['operations'])} messages."
    )


if __name__ == "__main__":
    main()
