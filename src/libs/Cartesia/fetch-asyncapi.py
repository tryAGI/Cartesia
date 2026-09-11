#!/usr/bin/env python3
"""Normalize Cartesia's public Managed Agents WebSocket contract to AsyncAPI 3."""

from pathlib import Path
import argparse
import json
import re
import subprocess

import yaml


SOURCE_URL = "https://docs.cartesia.ai/api-reference/agents/agent-websocket.md"
USER_AGENT = "tryAGI-Cartesia-SDK/1.0"
ASYNCAPI_FENCE = re.compile(r"````yaml[^\n]*\n(?P<document>.*?)\n````", re.DOTALL)
VERSION = re.compile(r"\b\d{4}-\d{2}-\d{2}\b")
EXPECTED_SEND_MESSAGES = {
    "agentSessionCreateEvent",
    "agentAudioInputEvent",
    "agentDtmfInputEvent",
    "agentClientToolResultEvent",
}
EXPECTED_RECEIVE_MESSAGES = {
    "agentSessionReadyEvent",
    "agentAudioOutputEvent",
    "agentAudioOutputClearEvent",
    "agentDtmfOutputEvent",
    "agentClientToolCallEvent",
    "agentTurnStartedEvent",
    "agentTurnOutputTextDeltaEvent",
    "agentTurnEndedEvent",
    "agentErrorEvent",
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


def require_contract(
    source: dict[str, object],
    send_messages: set[str],
    receive_messages: set[str],
) -> tuple[str, str]:
    address = source.get("address")
    if address != "/v1/agents/websocket/{agent_id}":
        raise SystemExit(f"Unexpected Managed Agents WebSocket address: {address!r}.")

    missing_send = EXPECTED_SEND_MESSAGES - send_messages
    missing_receive = EXPECTED_RECEIVE_MESSAGES - receive_messages
    if missing_send or missing_receive:
        raise SystemExit(
            "Managed Agents WebSocket contract is incomplete: "
            f"missing send={sorted(missing_send)}, receive={sorted(missing_receive)}."
        )

    parameters = source.get("parameters")
    if not isinstance(parameters, list):
        raise SystemExit("Managed Agents WebSocket parameters were not found.")
    version_parameter = next(
        (
            parameter
            for parameter in parameters
            if isinstance(parameter, dict) and parameter.get("id") == "cartesia_version"
        ),
        None,
    )
    if not isinstance(version_parameter, dict):
        raise SystemExit("Managed Agents WebSocket version parameter was not found.")
    match = VERSION.search(str(version_parameter.get("description", "")))
    if match is None:
        raise SystemExit("Managed Agents WebSocket version could not be determined.")
    return address, match.group(0)


def normalize(source: dict[str, object]) -> dict[str, object]:
    raw_operations = source.get("operations")
    if not isinstance(raw_operations, list):
        raise SystemExit("Managed Agents WebSocket operations were not found.")

    schemas: dict[str, object] = {}
    messages: dict[str, object] = {}
    channel_messages: dict[str, object] = {}
    operations: dict[str, object] = {}
    send_messages: set[str] = set()
    receive_messages: set[str] = set()

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
            raise SystemExit(f"Unknown Managed Agents WebSocket operation {operation_id!r}.")

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
            schema_name = raw_schema.get("x-parser-schema-id")
            if not isinstance(schema_name, str) or not schema_name.startswith("Agent"):
                raise SystemExit(f"Message {message_id} has no stable Agent schema id.")
            if schema_name in schemas:
                raise SystemExit(f"Duplicate Managed Agents WebSocket schema {schema_name}.")

            direction_messages.add(message_id)
            schema = clean_schema(raw_schema)
            if isinstance(schema, dict):
                schema.setdefault("description", raw_message.get("description", ""))
            schemas[schema_name] = schema
            messages[schema_name] = {
                "name": schema_name,
                "title": raw_message.get("title", schema_name),
                "description": raw_message.get("description", ""),
                "contentType": "application/json",
                "payload": {"$ref": f"#/components/schemas/{schema_name}"},
            }
            channel_messages[schema_name] = {
                "$ref": f"#/components/messages/{schema_name}"
            }
            operations[f"{action}{schema_name}"] = {
                "action": action,
                "channel": {"$ref": "#/channels/managedAgent"},
                "messages": [
                    {"$ref": f"#/channels/managedAgent/messages/{schema_name}"}
                ],
            }

    address, version = require_contract(source, send_messages, receive_messages)
    return {
        "asyncapi": "3.0.0",
        "info": {
            "title": "Cartesia Managed Agents WebSocket API",
            "version": version,
            "description": source.get("description", ""),
        },
        "servers": {
            "production": {
                "host": "api.cartesia.ai",
                "pathname": address,
                "protocol": "wss",
                "description": "Cartesia Managed Agents WebSocket endpoint.",
                "variables": {
                    "agent_id": {
                        "description": "ID of the managed agent to connect to."
                    },
                    "cartesia_version": {
                        "description": "Cartesia API version.",
                        "default": version,
                    },
                },
                "security": [
                    {"$ref": "#/components/securitySchemes/apiKey"},
                    {"$ref": "#/components/securitySchemes/accessToken"},
                ],
            }
        },
        "channels": {
            "managedAgent": {
                "address": address,
                "messages": channel_messages,
            }
        },
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
    args = parser.parse_args()

    markdown = fetch_text(SOURCE_URL)
    match = ASYNCAPI_FENCE.search(markdown)
    if match is None:
        raise SystemExit("Managed Agents AsyncAPI document was not found.")
    source = yaml.safe_load(match.group("document"))
    if not isinstance(source, dict):
        raise SystemExit("Managed Agents AsyncAPI document is invalid.")

    document = normalize(source)
    args.output.write_text(json.dumps(document, indent=2) + "\n", encoding="utf-8")
    print(
        f"Assembled Cartesia Managed Agents AsyncAPI {document['info']['version']}: "
        f"{len(document['operations'])} messages."
    )


if __name__ == "__main__":
    main()
