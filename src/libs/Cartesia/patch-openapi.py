#!/usr/bin/env python3
"""Apply documented Cartesia model overrides missing from the published spec."""

from pathlib import Path
import re
import sys


def add_enum_values(document: str, schema_name: str, values: list[str]) -> str:
    schema_marker = f"    {schema_name}:\n"
    schema_start = document.find(schema_marker)
    if schema_start < 0:
        raise SystemExit(f"Schema {schema_name} was not found in the Cartesia OpenAPI document.")

    next_schema_match = re.search(
        r"^    \S[^\n]*:\s*$",
        document[schema_start + len(schema_marker):],
        re.MULTILINE,
    )
    next_schema = (
        schema_start + len(schema_marker) + next_schema_match.start()
        if next_schema_match
        else len(document)
    )

    block = document[schema_start:next_schema]
    enum_marker = "      enum:\n"
    enum_start = block.find(enum_marker)
    if enum_start < 0:
        raise SystemExit(f"Schema {schema_name} does not contain an enum.")

    insertion = enum_start + len(enum_marker)
    while insertion < len(block):
        line_end = block.find("\n", insertion)
        if line_end < 0:
            line_end = len(block)
        line = block[insertion:line_end]
        if not line.startswith("        - "):
            break
        insertion = line_end + (1 if line_end < len(block) else 0)

    existing = {
        line.removeprefix("        - ").strip().strip("'\"")
        for line in block.splitlines()
        if line.startswith("        - ")
    }
    missing = [value for value in values if value not in existing]
    if not missing:
        return document

    added = "".join(f"        - '{value}'\n" for value in missing)
    block = block[:insertion] + added + block[insertion:]
    return document[:schema_start] + block + document[next_schema:]


def make_schema_property_optional(document: str, schema_name: str, property_name: str) -> str:
    """Keep a documented property while tolerating responses that omit it."""
    schema_marker = f"    {schema_name}:\n"
    schema_start = document.find(schema_marker)
    if schema_start < 0:
        raise SystemExit(f"Schema {schema_name} was not found in the Cartesia OpenAPI document.")

    next_schema_match = re.search(
        r"^    \S[^\n]*:\s*$",
        document[schema_start + len(schema_marker):],
        re.MULTILINE,
    )
    next_schema = (
        schema_start + len(schema_marker) + next_schema_match.start()
        if next_schema_match
        else len(document)
    )

    block = document[schema_start:next_schema]
    property_marker = f"        {property_name}:\n"
    if property_marker not in block:
        raise SystemExit(f"Schema {schema_name} does not define property {property_name}.")

    required_marker = "      required:\n"
    required_start = block.find(required_marker)
    if required_start < 0:
        return document

    required_end_match = re.search(
        r"^      \S[^\n]*:\s*$",
        block[required_start + len(required_marker):],
        re.MULTILINE,
    )
    required_end = (
        required_start + len(required_marker) + required_end_match.start()
        if required_end_match
        else len(block)
    )
    required_block = block[required_start:required_end]
    required_line = f"        - {property_name}\n"
    if required_line not in required_block:
        return document

    required_block = required_block.replace(required_line, "", 1)
    block = block[:required_start] + required_block + block[required_end:]
    return document[:schema_start] + block + document[next_schema:]


if len(sys.argv) != 2:
    raise SystemExit("usage: patch-openapi.py <openapi.yaml>")

spec_path = Path(sys.argv[1])
spec = spec_path.read_text(encoding="utf-8")
spec = add_enum_values(
    spec,
    "TTSModel",
    ["sonic-3.6", "sonic-3.6-2026-08-27", "sonic-preview"],
)
spec = add_enum_values(
    spec,
    "SupportedLanguage",
    [
        "or",
        "ur",
        "en-GB",
        "en-US",
        "en-IN",
        "en-IE",
        "en-ZA",
        "en-NZ",
        "en-SG",
        "en-AU",
        "es-ES",
        "es-MX",
        "es-US",
        "fr-FR",
        "fr-CA",
        "nl-NL",
        "nl-BE",
        "pt-PT",
        "pt-BR",
    ],
)
# Cartesia's List Voices response can omit locales unless that data is expanded.
# Leaving the field required makes a successful page fail JSON deserialization.
spec = make_schema_property_optional(spec, "Voice", "locales")
spec_path.write_text(spec, encoding="utf-8")
