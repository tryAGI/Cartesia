# CLAUDE.md — Cartesia SDK

## Overview

Auto-generated C# SDK for [Cartesia](https://cartesia.ai/) — low-latency TTS, STT, voice cloning, AI agents, fine-tuning, and pronunciation dictionaries.

## Build & Test

```bash
dotnet build Cartesia.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth with Cartesia API key:

```csharp
var client = new CartesiaClient(apiKey); // CARTESIA_API_KEY env var
```

## Key Files

- `src/libs/Cartesia/generate.sh` — Regeneration script (downloads spec from Stainless GCS, runs autosdk)
- `src/libs/Cartesia/Generated/` — **Never edit** — auto-generated code
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Spec Notes

- OpenAPI spec hosted on Stainless GCS with hash-based URLs (not stable)
- To update spec: check `cartesia-ai/cartesia-python/.stats.yml` for latest URL
- Auth is standard `http/bearer` — no jq/yq fix needed
- Every endpoint requires `Cartesia-Version` header (e.g., `2025-04-16`)
- MEAI candidate: `ISpeechToTextClient` interface (has STT endpoint)
