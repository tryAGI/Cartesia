# Speech To Text Client Get Text Async



This example assumes `using Cartesia;` is in scope and `apiKey` contains your Cartesia API key.

```csharp
using var api = new CartesiaClient(apiKey);
ISpeechToTextClient speechClient = api;

// Transcribe audio using the MEAI ISpeechToTextClient interface.
// Cartesia processes the audio synchronously — no polling required.
using var httpClient = new HttpClient();
await using var audioStream = await httpClient.GetStreamAsync(
    "https://cdn.openai.com/API/docs/audio/alloy.wav");

var ms = new MemoryStream();
await audioStream.CopyToAsync(ms);
ms.Position = 0;

var response = await speechClient.GetTextAsync(ms);

Console.WriteLine($"Text: {response.Text}");
```