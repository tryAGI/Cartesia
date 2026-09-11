#!/usr/bin/env python3
"""Assemble Cartesia's latest public OpenAPI fragments into one document.

Cartesia's aggregate ``latest.yml`` is authentication-gated, while every API
reference page exposes the corresponding self-contained OpenAPI fragment in
its public Markdown source. This script follows the latest dated API section,
downloads those fragments, and merges them without requiring a YAML package.
"""

from collections import OrderedDict
from concurrent.futures import ThreadPoolExecutor
from pathlib import Path
import argparse
import re
import subprocess


INDEX_URL = "https://docs.cartesia.ai/_llms/en/api.md"
USER_AGENT = "tryAGI-Cartesia-SDK/1.0"
LATEST_SECTION = re.compile(r"^### (?P<version>\d{4}-\d{2}-\d{2})\s*$", re.MULTILINE)
REFERENCE_URL = re.compile(r"\((https://docs\.cartesia\.ai/api-reference/[^)]+\.md)\)")
OPENAPI_FENCE = re.compile(r"````yaml[^\n]*\n(openapi:.*?)\n````", re.DOTALL)


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


def extract_top_level_section(document: str, name: str) -> str | None:
    marker = re.search(rf"^{re.escape(name)}:\s*$", document, re.MULTILINE)
    if marker is None:
        return None

    start = marker.end() + 1
    next_section = re.search(r"^\S[^\n]*:\s*$", document[start:], re.MULTILINE)
    end = start + next_section.start() if next_section else len(document)
    return document[start:end].rstrip()


def extract_mapping_blocks(document: str, indentation: int) -> OrderedDict[str, str]:
    marker = re.compile(rf"^{' ' * indentation}(\S[^\n]*):\s*$", re.MULTILINE)
    matches = list(marker.finditer(document))
    blocks: OrderedDict[str, str] = OrderedDict()
    for index, match in enumerate(matches):
        end = matches[index + 1].start() if index + 1 < len(matches) else len(document)
        blocks[match.group(1)] = document[match.start():end].rstrip()
    return blocks


def merge_unique(
    target: OrderedDict[str, str],
    source: OrderedDict[str, str],
    description: str,
) -> None:
    for key, block in source.items():
        existing = target.get(key)
        if existing is not None and existing.strip() != block.strip():
            raise SystemExit(f"Conflicting {description} definition for {key}.")
        target[key] = block


def extract_document_parts(
    document: str,
) -> tuple[OrderedDict[str, OrderedDict[str, str]], OrderedDict[str, OrderedDict[str, str]]]:
    paths: OrderedDict[str, OrderedDict[str, str]] = OrderedDict()
    paths_section = extract_top_level_section(document, "paths") or ""
    for path, path_block in extract_mapping_blocks(paths_section, 2).items():
        path_body = "\n".join(path_block.splitlines()[1:])
        paths[path] = extract_mapping_blocks(path_body, 4)

    components: OrderedDict[str, OrderedDict[str, str]] = OrderedDict()
    components_section = extract_top_level_section(document, "components") or ""
    for category, category_block in extract_mapping_blocks(components_section, 2).items():
        category_body = "\n".join(category_block.splitlines()[1:])
        components[category] = extract_mapping_blocks(category_body, 4)

    return paths, components


def merge_fragments(
    fragments: list[str], fallback_document: str | None
) -> tuple[str, int, int]:
    paths: OrderedDict[str, OrderedDict[str, str]] = OrderedDict()
    components: OrderedDict[str, OrderedDict[str, str]] = OrderedDict()

    for fragment in fragments:
        fragment_paths, fragment_components = extract_document_parts(fragment)
        for path, operations in fragment_paths.items():
            merge_unique(paths.setdefault(path, OrderedDict()), operations, f"operation on {path}")
        for category, items in fragment_components.items():
            merge_unique(components.setdefault(category, OrderedDict()), items, f"component in {category}")

    # Keep endpoints omitted from the latest index until Cartesia explicitly
    # deprecates them in a published schema. This retains the existing voice
    # changer and pre-v1 Agents surface while latest definitions win on overlap.
    # Also preserve compatibility-only schemas used by WebSocket adapters; the
    # REST fragments do not repeat schemas from the separate AsyncAPI document.
    if fallback_document:
        fallback_paths, fallback_components = extract_document_parts(fallback_document)
        for path, operations in fallback_paths.items():
            target = paths.setdefault(path, OrderedDict())
            for method, block in operations.items():
                target.setdefault(method, block)
        for category, items in fallback_components.items():
            target = components.setdefault(category, OrderedDict())
            for key, block in items.items():
                target.setdefault(key, block)

    lines = [
        "openapi: 3.0.1",
        "info:",
        "  title: Cartesia API",
        "  version: 0.0.1",
        "servers:",
        "  - url: https://api.cartesia.ai",
        "    description: Production",
        "security: []",
        "paths:",
    ]
    for path, operations in paths.items():
        lines.append(f"  {path}:")
        lines.extend(operations.values())

    lines.append("components:")
    for category, items in components.items():
        lines.append(f"  {category}:")
        lines.extend(items.values())

    return "\n".join(lines) + "\n", len(paths), sum(len(items) for items in paths.values())


def require_latest_surface(document: str, version: str, operation_count: int) -> None:
    if operation_count < 90:
        raise SystemExit(f"Only {operation_count} OpenAPI operations were assembled; expected at least 90.")

    paths, components = extract_document_parts(document)
    required_operations = {
        ("/tts/bytes", "post"),
        ("/tts/sse", "post"),
        ("/v1/agents", "get"),
        ("/v1/agents", "post"),
        ("/v1/agents/{agent_id}", "get"),
        ("/v1/agents/{agent_id}", "patch"),
        ("/v1/agents/{agent_id}", "delete"),
        ("/v1/agents/models", "get"),
        ("/v1/agents/tools", "get"),
        ("/v1/agents/tools", "post"),
        ("/voices/clone", "post"),
        ("/voices/{id}/accents", "patch"),
        ("/accents", "get"),
    }
    missing_operations = sorted(
        f"{method.upper()} {path}"
        for path, method in required_operations
        if method not in paths.get(path, {})
    )
    if missing_operations:
        raise SystemExit("Latest Cartesia surface is missing: " + ", ".join(missing_operations))

    schemas = components.get("schemas", {})
    for schema_name, properties in {
        "TTSRequest": ("locale", "accent", "normalization"),
        "TTSSSERequest": ("locale", "accent", "normalization"),
        "Voice": ("accents",),
    }.items():
        schema = schemas.get(schema_name)
        if schema is None:
            raise SystemExit(f"Latest Cartesia surface is missing schema {schema_name}.")
        missing = [name for name in properties if f"        {name}:" not in schema]
        if missing:
            raise SystemExit(f"Schema {schema_name} is missing properties: {', '.join(missing)}")

    version_header = components.get("parameters", {}).get("CartesiaVersionHeader", "")
    if version not in version_header:
        raise SystemExit(f"Cartesia version header does not include latest version {version}.")


def main() -> None:
    parser = argparse.ArgumentParser()
    parser.add_argument("output", type=Path)
    parser.add_argument("--fallback-spec", type=Path)
    args = parser.parse_args()

    index = fetch_text(INDEX_URL)
    latest = LATEST_SECTION.search(index)
    if latest is None:
        raise SystemExit("No dated API section was found in Cartesia's documentation index.")
    next_section = LATEST_SECTION.search(index, latest.end())
    section = index[latest.end():next_section.start() if next_section else len(index)]
    urls = list(dict.fromkeys(REFERENCE_URL.findall(section)))
    if not urls:
        raise SystemExit("No API reference pages were found in Cartesia's latest documentation section.")

    with ThreadPoolExecutor(max_workers=8) as executor:
        pages = list(executor.map(fetch_text, urls))

    fragments: list[str] = []
    for url, page in zip(urls, pages, strict=True):
        match = OPENAPI_FENCE.search(page)
        if match:
            fragments.append(match.group(1))
        elif "## AsyncAPI" not in page:
            raise SystemExit(f"No OpenAPI or AsyncAPI fragment was found in {url}.")

    fallback = None
    if args.fallback_spec and args.fallback_spec.exists():
        fallback = args.fallback_spec.read_text(encoding="utf-8")

    document, path_count, operation_count = merge_fragments(fragments, fallback)
    document = "\n".join(line.rstrip() for line in document.splitlines()) + "\n"
    require_latest_surface(document, latest.group("version"), operation_count)
    args.output.write_text(document, encoding="utf-8")
    print(
        f"Assembled Cartesia {latest.group('version')} OpenAPI: "
        f"{path_count} paths, {operation_count} operations."
    )


if __name__ == "__main__":
    main()
