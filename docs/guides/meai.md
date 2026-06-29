# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Cartesia SDK implements `ITextToSpeechClient` and `ISpeechToTextClient` from [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai).

## Supported Interfaces

| Interface | Support Level |
|-----------|--------------|
| `ITextToSpeechClient` | Full (Sonic TTS bytes plus low-latency SSE streaming) |
| `ISpeechToTextClient` | Full (synchronous transcription, 115+ languages, word timestamps) |

## ITextToSpeechClient

### Text-to-Speech

Generate speech through the standard MEAI interface. Cartesia requires an explicit `VoiceId`:

```csharp
using Cartesia;
using Microsoft.Extensions.AI;

using var client = new CartesiaClient(apiKey);
ITextToSpeechClient ttsClient = client;

var response = await ttsClient.GetAudioAsync(
    "Cartesia Sonic is available through Microsoft.Extensions.AI.",
    new TextToSpeechOptions
    {
        ModelId = "sonic-3.5",
        VoiceId = "694f9389-aac1-45b6-b726-9d9369183238",
        AudioFormat = "wav",
        Language = "en-US",
        Speed = 1.05f,
    });

var audio = response.Contents.OfType<DataContent>().Single();
File.WriteAllBytes("cartesia.wav", audio.Data.ToArray());
```

### Streaming Text-to-Speech

`GetStreamingAudioAsync` uses Cartesia's SSE endpoint and emits raw PCM audio chunks:

```csharp
await foreach (var update in ttsClient.GetStreamingAudioAsync(
    "Streaming speech starts returning audio before the full generation is done.",
    new TextToSpeechOptions
    {
        ModelId = "sonic-3.5",
        VoiceId = "694f9389-aac1-45b6-b726-9d9369183238",
        AudioFormat = "pcm_s16le",
    }))
{
    foreach (var chunk in update.Contents.OfType<DataContent>())
    {
        Console.WriteLine($"{update.Kind}: {chunk.Data.Length} bytes");
    }
}
```

### Cartesia-Specific Options

Use `AdditionalProperties` for provider-specific fields:

```csharp
var response = await ttsClient.GetAudioAsync(
    "Provider-specific options remain available.",
    new TextToSpeechOptions
    {
        VoiceId = "694f9389-aac1-45b6-b726-9d9369183238",
        AudioFormat = "mp3",
        AdditionalProperties = new()
        {
            [CartesiaTextToSpeechPropertyNames.SampleRate] = 24000,
            [CartesiaTextToSpeechPropertyNames.BitRate] = 96000,
            [CartesiaTextToSpeechPropertyNames.Emotion] = "calm",
        },
    });
```

`RawRepresentationFactory` can return a `TTSRequest` or `TTSSSERequest` when you need full access to Cartesia-specific request bodies.

## ISpeechToTextClient

### Installation

```bash
dotnet add package Cartesia
```

### File-Based Transcription

Transcribe an audio file to text. Unlike polling-based providers, Cartesia processes audio synchronously:

```csharp
using Cartesia;
using Microsoft.Extensions.AI;

using var client = new CartesiaClient(apiKey);
ISpeechToTextClient sttClient = client;

using var audioStream = File.OpenRead("audio.wav");
var response = await sttClient.GetTextAsync(audioStream);

Console.WriteLine(response.Text);
Console.WriteLine($"Duration: {response.StartTime} - {response.EndTime}");
```

### Transcription with Language Hint

Specify a language code for more accurate transcription:

```csharp
ISpeechToTextClient sttClient = client;

using var audioStream = File.OpenRead("spanish-audio.wav");
var response = await sttClient.GetTextAsync(audioStream, new SpeechToTextOptions
{
    SpeechLanguage = "es",
});

Console.WriteLine(response.Text);
```

### Specifying a Model

Select a specific Cartesia STT model:

```csharp
ISpeechToTextClient sttClient = client;

using var audioStream = File.OpenRead("audio.wav");
var response = await sttClient.GetTextAsync(audioStream, new SpeechToTextOptions
{
    ModelId = "ink-whisper",
});

Console.WriteLine(response.Text);
```

### Advanced Configuration with RawRepresentationFactory

Use `RawRepresentationFactory` to access Cartesia-specific features like audio encoding and timestamp granularity:

```csharp
ISpeechToTextClient sttClient = client;

using var audioStream = File.OpenRead("audio.wav");
var response = await sttClient.GetTextAsync(audioStream, new SpeechToTextOptions
{
    RawRepresentationFactory = _ => new SttTranscribeRequest
    {
        Model = "ink-whisper",
        Language = SttTranscribeRequestLanguage.En,
        TimestampGranularities = [TimestampGranularity.Word],
    },
});

Console.WriteLine(response.Text);

// Access word-level timestamps from the raw response
var raw = (TranscriptionResponse)response.RawRepresentation!;
if (raw.Words is { Count: > 0 } words)
{
    foreach (var word in words)
    {
        Console.WriteLine($"  [{word.Start:F2}s - {word.End:F2}s] {word.Word}");
    }
}
```

### Streaming Behavior

`GetStreamingTextAsync` delegates to the non-streaming `GetTextAsync` method internally. The Cartesia STT API processes audio synchronously (no polling needed), and then the full result is converted to `SpeechToTextResponseUpdate` events using `ToSpeechToTextResponseUpdates()`.

This means you will not receive incremental transcription updates as audio is processed. The entire transcript is returned at once after processing completes. For most use cases, calling `GetTextAsync` directly is equivalent and simpler.

### Accessing the Underlying Client

Retrieve the `CartesiaClient` from the MEAI interface:

```csharp
ISpeechToTextClient sttClient = client;

var metadata = sttClient.GetService<SpeechToTextClientMetadata>();
Console.WriteLine($"Provider: {metadata?.ProviderName}"); // "cartesia"

var cartesiaClient = sttClient.GetService<CartesiaClient>();
// Use cartesiaClient for Cartesia-specific APIs (TTS, voice cloning, agents, etc.)
```
