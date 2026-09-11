/*
order: 60
title: Text To Speech Client Options
slug: text-to-speech-client-options
*/

using Microsoft.Extensions.AI;

namespace Cartesia.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task TextToSpeechClient_RequiresVoiceId()
    {
        using var api = new CartesiaClient("dummy-key");
        ITextToSpeechClient speechClient = api;

        //// Cartesia voices are explicit. Set TextToSpeechOptions.VoiceId for synthesis.
        var act = () => speechClient.GetAudioAsync("Hello from Cartesia.").WaitAsync(TimeSpan.FromSeconds(5));

        await Assert.ThrowsExactlyAsync<ArgumentException>(act);
    }

    [TestMethod]
    public async Task TextToSpeechClient_MapsOptionsToRawRequest()
    {
        using var api = new CartesiaClient(
            "dummy-key",
            new HttpClient(new StaticResponseHandler())
            {
                BaseAddress = new Uri(CartesiaClient.DefaultBaseUrl),
            });
        ITextToSpeechClient speechClient = api;
        TTSRequest? capturedRequest = null;

        //// RawRepresentationFactory lets you inspect or customize the Cartesia-specific request.
        _ = await Assert.ThrowsExactlyAsync<ApiException>(() => speechClient.GetAudioAsync(
            "Hello from Cartesia.",
            new TextToSpeechOptions
            {
                ModelId = "sonic-3.6",
                VoiceId = "694f9389-aac1-45b6-b726-9d9369183238",
                AudioFormat = "wav",
                Language = "en-GB",
                Speed = 1.1f,
                Volume = 0.9f,
                AdditionalProperties = new()
                {
                    [CartesiaTextToSpeechPropertyNames.Accent] = "british",
                    [CartesiaTextToSpeechPropertyNames.Normalization] = "en-US",
                    [CartesiaTextToSpeechPropertyNames.SampleRate] = 24000,
                    [CartesiaTextToSpeechPropertyNames.PronunciationDictionaryId] = "pronunciation-dictionary-id",
                },
                RawRepresentationFactory = _ =>
                {
                    capturedRequest = new TTSRequest
                    {
                        ModelId = TTSModelID.Sonic3,
                        Transcript = string.Empty,
                        Voice = "placeholder",
                        OutputFormat = new RawOutputFormat
                        {
                            Encoding = RawEncoding.PcmS16le,
                            SampleRate = 44100,
                        },
                    };

                    return capturedRequest;
                },
            }));

        Assert.IsNotNull(capturedRequest);
        Assert.AreEqual("Hello from Cartesia.", capturedRequest.Transcript);
        Assert.AreEqual(TTSModelID.Sonic36, capturedRequest.ModelId);
        Assert.AreEqual("694f9389-aac1-45b6-b726-9d9369183238", capturedRequest.Voice.PickTTSRequestVoiceId());
        Assert.IsNull(capturedRequest.Language);
        Assert.AreEqual("en-GB", capturedRequest.Locale);
        Assert.AreEqual("british", capturedRequest.Accent);
        Assert.AreEqual("en-US", capturedRequest.Normalization);
        Assert.AreEqual("pronunciation-dictionary-id", capturedRequest.PronunciationDictId);
        capturedRequest.GenerationConfig!.Speed.Should().BeApproximately(1.1d, 0.00001d);
        capturedRequest.GenerationConfig.Volume.Should().BeApproximately(0.9d, 0.00001d);
        Assert.AreEqual(24000, capturedRequest.OutputFormat.PickWAVOutputFormat().SampleRate);
    }

    private sealed class StaticResponseHandler : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken) =>
            Task.FromResult(new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
            {
                RequestMessage = request,
                Content = new StringContent("{}"),
            });
    }
}
