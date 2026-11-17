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

The OpenAPI document declares `STTAutoFinalize*`, `STTManualFinalize*`, `STTBatchModel` and
`PhonemeTimestamps` as components, and **no `$ref` reaches any of them** — OpenAPI cannot express a
WebSocket channel, so no path points at them. They are not dead, and an "unreferenced components"
audit should not talk you into deleting them:
`scripts/audit_orphan_type_usage.py --sdk Cartesia` in the workspace repo lists the ten that
hand-written code uses.

### The realtime clients ARE generated — from four fetched AsyncAPI contracts

`generate.sh` runs `fetch-asyncapi.py` for `agents`, `tts`, `stt` and `stt-turns`, producing
`managed-agents-asyncapi.json`, `tts-asyncapi.json`, `stt-asyncapi.json` and
`stt-turns-asyncapi.json`, and generates a client from each:
`CartesiaManagedAgentRealtimeClient`, `CartesiaTextToSpeechRealtimeClient`,
`CartesiaSpeechToTextRealtimeClient`, `CartesiaSpeechToTextTurnsRealtimeClient`.

Note the filenames: there is no `asyncapi.yaml` here, so a `ls asyncapi.*` finds nothing and invites
the wrong conclusion that the realtime surface is unspecified. It is not.

**`Extensions/CartesiaClient.RealtimeSpeechToText.cs` (711 lines) is superseded.** It was last
touched 2026-08-08; the generated realtime clients arrived 2026-09-11 in "feat(cartesia): generate
realtime speech clients" and the hand-written one was never removed. Nothing references it but
itself and a test helper.

Two things checked before calling it removable, because neither is obvious:

- **MEAI does not depend on it.** `ISpeechToTextClient.GetStreamingTextAsync` calls `GetTextAsync`
  and chunks the REST result — it never opens a WebSocket — so removing the hand-written client does
  not touch the MEAI surface.
- **The API version is not lost.** The hand-written client sends it as a `Cartesia-Version` header;
  the fetched contracts declare `cartesia_version` as a **required query parameter**, so
  `ConnectSessionAsync` takes a typed, mandatory `SpeechToTextApiVersion` on both channels. Grepping
  the generated files for `Cartesia-Version` finds nothing and invites the opposite conclusion —
  check the contract, not the header list.

So nothing functional blocks removal: both channels are generated, the version is handled more
strictly than by hand, and MEAI is uninvolved. What remains is the API break for anyone who adopted
`ConnectRealtimeSttAutoAsync`, which is a deprecation question - `[Obsolete]` pointing at
`CartesiaSpeechToTextRealtimeClient` / `CartesiaSpeechToTextTurnsRealtimeClient`, then removal in a
major. Inworld went through the same transition and recorded it the same way.

- MEAI: `ISpeechToTextClient` implemented in `Extensions/CartesiaClient.SpeechToTextClient.cs`
  - Synchronous transcription via `POST /stt` — no polling needed
  - Maps `SpeechLanguage` to `SttTranscribeRequestLanguage` enum
  - Supports `RawRepresentationFactory` for pre-built `SttTranscribeRequest`
