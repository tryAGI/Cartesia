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


if len(sys.argv) != 2:
    raise SystemExit("usage: patch-openapi.py <openapi.yaml>")

spec_path = Path(sys.argv[1])
spec = spec_path.read_text(encoding="utf-8")
spec = add_enum_values(spec, "TTSModel", ["sonic-preview"])
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
spec_path.write_text(spec, encoding="utf-8")
