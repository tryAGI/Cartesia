namespace Cartesia.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static CartesiaClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("CARTESIA_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("CARTESIA_API_KEY environment variable is not found.");

        var client = new CartesiaClient(apiKey);
        
        return client;
    }
}
