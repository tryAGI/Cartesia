/*
order: 50
title: Text To Speech Client Get Service Metadata
slug: text-to-speech-client-get-service-metadata
*/

using Microsoft.Extensions.AI;

namespace Cartesia.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void TextToSpeechClient_GetService_Metadata()
    {
        using var api = new CartesiaClient("dummy-key");
        ITextToSpeechClient speechClient = api;

        //// Retrieve metadata about the text-to-speech provider.
        var metadata = speechClient.GetService<TextToSpeechClientMetadata>();

        Assert.IsNotNull(metadata);
        Assert.AreEqual("cartesia", metadata.ProviderName);
        Assert.AreEqual("sonic-3.5", metadata.DefaultModelId);
        Assert.IsNotNull(metadata.ProviderUri);
    }
}
