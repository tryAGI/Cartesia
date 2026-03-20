# Speech To Text Client Get Service Self



This example assumes `using Cartesia;` is in scope and `apiKey` contains your Cartesia API key.

```csharp
using var api = new CartesiaClient("dummy-key");
ISpeechToTextClient speechClient = api;

// Access the underlying CartesiaClient from the MEAI interface.
var self = speechClient.GetService<CartesiaClient>();
```