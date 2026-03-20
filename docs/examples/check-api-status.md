# Check API Status

Check the Cartesia API status.

This example assumes `using Cartesia;` is in scope and `apiKey` contains your Cartesia API key.

```csharp
using var client = new CartesiaClient(apiKey);

// Check the API status to verify connectivity.
var response = await client.ApiStatus.ApiStatusGetAsync(
    cartesiaVersion: ApiStatusGetCartesiaVersion.x20250416);
```