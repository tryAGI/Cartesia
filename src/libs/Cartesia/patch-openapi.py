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


def contains_schema(document: str, schema_name: str) -> bool:
    return f"    {schema_name}:\n" in document


def contains_schema_property(document: str, schema_name: str, property_name: str) -> bool:
    schema_marker = f"    {schema_name}:\n"
    schema_start = document.find(schema_marker)
    if schema_start < 0:
        return False

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
    return f"        {property_name}:\n" in document[schema_start:next_schema]


def replace_schema(document: str, schema_name: str, replacement: str) -> str:
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
    return document[:schema_start] + replacement.rstrip() + "\n" + document[next_schema:]


def flatten_string_enum_union(document: str, schema_name: str) -> str:
    """Collapse indistinguishable string oneOf branches into one usable enum."""
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
    values = list(dict.fromkeys(
        line.removeprefix("            - ").strip().strip("'\"")
        for line in block.splitlines()
        if line.startswith("            - ")
    ))
    if not values:
        raise SystemExit(f"Schema {schema_name} does not contain string enum branches.")

    enum_lines = "\n".join(f"        - {value}" for value in values)
    return replace_schema(
        document,
        schema_name,
        f"""    {schema_name}:
      title: {schema_name}
      type: string
      description: Accent id from GET /accents, valid for the selected language.
      enum:
{enum_lines}""",
    )


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

# The latest docs express the three output formats as inline allOf branches.
# AutoSDK preserves those as nested AllOf values, which makes the otherwise
# simple discriminated union unusable, and integer enum defaults on required
# MP3 properties currently produce invalid `int.x...` initializers. Normalize
# the equivalent schema before generation.
spec = replace_schema(
    spec,
    "OutputFormat",
    """    OutputFormat:
      title: OutputFormat
      oneOf:
        - $ref: '#/components/schemas/WAVOutputFormat'
        - $ref: '#/components/schemas/MP3OutputFormat'
        - $ref: '#/components/schemas/RawOutputFormat'""",
)
spec = replace_schema(
    spec,
    "WAVOutputFormat",
    """    WAVOutputFormat:
      title: WAVOutputFormat
      type: object
      properties:
        container:
          type: string
          enum:
            - wav
          default: wav
        encoding:
          $ref: '#/components/schemas/RawEncoding'
          default: pcm_s16le
        sample_rate:
          type: integer
          enum:
            - 8000
            - 16000
            - 22050
            - 24000
            - 44100
            - 48000
          default: 44100
      required:
        - container""",
)
spec = replace_schema(
    spec,
    "MP3OutputFormat",
    """    MP3OutputFormat:
      title: MP3OutputFormat
      type: object
      properties:
        container:
          type: string
          enum:
            - mp3
          default: mp3
        sample_rate:
          type: integer
          enum:
            - 8000
            - 16000
            - 22050
            - 24000
            - 44100
            - 48000
        bit_rate:
          type: integer
          enum:
            - 32000
            - 64000
            - 96000
            - 128000
            - 192000
      required:
        - container
        - sample_rate
        - bit_rate""",
)
spec = replace_schema(
    spec,
    "RawOutputFormat",
    """    RawOutputFormat:
      title: RawOutputFormat
      type: object
      properties:
        container:
          type: string
          enum:
            - raw
          default: raw
        encoding:
          $ref: '#/components/schemas/RawEncoding'
        sample_rate:
          type: integer
          enum:
            - 8000
            - 16000
            - 22050
            - 24000
            - 44100
            - 48000
      required:
        - container
        - encoding
        - sample_rate""",
)

# Accent payloads are plain JSON strings, so their language-specific oneOf
# branches have no discriminator. Flattening keeps every documented value and
# prevents codegen from choosing the first enum branch during deserialization.
spec = flatten_string_enum_union(spec, "VoiceAccent")
spec = flatten_string_enum_union(spec, "LocalizeVoiceAccent")

for tts_model_schema in ("TTSModelID", "TTSModel"):
    if contains_schema(spec, tts_model_schema):
        spec = add_enum_values(
            spec,
            tts_model_schema,
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
# Older Cartesia responses used `locales`, which could be omitted unless expanded.
# Newer responses expose optional `accents` instead. Preserve the old tolerance
# when the compatibility schema is still present in the assembled document.
if contains_schema_property(spec, "Voice", "locales"):
    spec = make_schema_property_optional(spec, "Voice", "locales")
spec_path.write_text(spec, encoding="utf-8")
