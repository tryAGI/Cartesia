/*
order: 10
title: Check API Status
slug: check-api-status

Check the Cartesia API status.
*/

namespace Cartesia.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_CheckApiStatus()
    {
        using var client = GetAuthenticatedClient();

        //// Check the API status to verify connectivity.
        var response = await client.ApiStatus.ApiStatusGetAsync(
            cartesiaVersion: ApiStatusGetCartesiaVersion.x20250416);

        Assert.IsNotNull(response);
    }
}
