/*
order: 40
title: Speech To Text Client Get Service Self
slug: speech-to-text-client-get-service-self
*/

using Microsoft.Extensions.AI;

namespace Cartesia.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void SpeechToTextClient_GetService_Self()
    {
        using var api = new CartesiaClient("dummy-key");
        ISpeechToTextClient speechClient = api;

        //// Access the underlying CartesiaClient from the MEAI interface.
        var self = speechClient.GetService<CartesiaClient>();

        Assert.IsNotNull(self);
        Assert.AreSame(api, self);
    }
}
