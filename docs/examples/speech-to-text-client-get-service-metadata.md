# Speech To Text Client Get Service Metadata



This example assumes `using Cartesia;` is in scope and `apiKey` contains your Cartesia API key.

```csharp
using var api = new CartesiaClient("dummy-key");
ISpeechToTextClient speechClient = api;

// Retrieve metadata about the speech-to-text provider.
var metadata = speechClient.GetService<SpeechToTextClientMetadata>();
```