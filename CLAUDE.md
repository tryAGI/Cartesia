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

- OpenAPI spec hosted on Stainless GCS with hash-based URLs
- `generate.sh` dynamically resolves latest URL from `cartesia-ai/cartesia-python/.stats.yml`
- Auth is standard `http/bearer` — no jq/yq fix needed
- Every endpoint requires `Cartesia-Version` header (e.g., `2025-04-16`)
### The WebSocket vocabulary is in the spec but unreachable from it

The document declares `STTAutoFinalize*`, `STTManualFinalize*`, `STTBatchModel` and
`PhonemeTimestamps` as components, and **no `$ref` reaches any of them** — OpenAPI cannot express a
WebSocket channel, so no path points at them. They are not dead: `Extensions/CartesiaClient.Realtime
SpeechToText.cs` (711 lines) and `Extensions/CartesiaTtsSseExtensions.cs` (282 lines) use ten of
them by hand.

So don't let an "unreferenced components" audit talk you into deleting them —
`scripts/audit_orphan_type_usage.py --sdk Cartesia` in the workspace repo lists exactly which ten,
and that check belongs before any such removal.

What this actually signals is a **missing `asyncapi.yaml`**. Twelve SDKs here ship a handcrafted one
(AssemblyAI, Deepgram, ElevenLabs, Inworld, Mistral, NariLabs, OpenAI, Simli, SmallestAI, Soniox,
Ultravox, Xai) and have their realtime clients generated instead of written. Cartesia's component
vocabulary already exists, which is the hard part; the 711 hand-written lines are what an AsyncAPI
document would replace.

- MEAI: `ISpeechToTextClient` implemented in `Extensions/CartesiaClient.SpeechToTextClient.cs`
  - Synchronous transcription via `POST /stt` — no polling needed
  - Maps `SpeechLanguage` to `SttTranscribeRequestLanguage` enum
  - Supports `RawRepresentationFactory` for pre-built `SttTranscribeRequest`
