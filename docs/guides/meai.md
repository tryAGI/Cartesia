# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The `Cartesia` SDK implements the `ISpeechToTextClient` interface from `Microsoft.Extensions.AI`, enabling you to use Cartesia speech-to-text through a standardized .NET AI abstraction.

## Supported Interfaces

| Interface | Support Level |
|-----------|--------------|
| `ISpeechToTextClient` | Full (synchronous transcription, 115+ languages, word timestamps) |

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

### Accessing the Underlying Client

Retrieve the `CartesiaClient` from the MEAI interface:

```csharp
ISpeechToTextClient sttClient = client;

var metadata = sttClient.GetService<SpeechToTextClientMetadata>();
Console.WriteLine($"Provider: {metadata?.ProviderName}"); // "cartesia"

var cartesiaClient = sttClient.GetService<CartesiaClient>();
// Use cartesiaClient for Cartesia-specific APIs (TTS, voice cloning, agents, etc.)
```
