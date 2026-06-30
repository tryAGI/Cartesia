/*
order: 70
title: Text To Speech SSE Streaming
slug: text-to-speech-sse-streaming
*/

using System.Net;
using System.Text;

namespace Cartesia.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task TextToSpeechSseStreaming_DecodesAudioChunks()
    {
        var handler = new TtsSseResponseHandler();
        using var api = new CartesiaClient(
            "dummy-key",
            new HttpClient(handler)
            {
                BaseAddress = new Uri(CartesiaClient.DefaultBaseUrl),
            });

        var request = new TTSSSERequest
        {
            ModelId = TTSModel.Sonic35,
            Transcript = "Hello from Cartesia.",
            Voice = new TTSRequestVoiceSpecifier
            {
                Mode = TTSRequestVoiceSpecifierMode.Id,
                Id = "694f9389-aac1-45b6-b726-9d9369183238",
            },
            OutputFormat = new SSEOutputFormat
            {
                Container = SSEOutputFormatContainer.Raw,
                Encoding = RawEncoding.PcmS16le,
                SampleRate = 24000,
            },
            ContextId = "ctx-1",
        };

        var events = new List<CartesiaTtsSseEvent>();

        //// StreamTtsSseAsync yields events as the SSE response is read and decodes chunk audio bytes.
        await foreach (var @event in api.StreamTtsSseAsync(request))
        {
            events.Add(@event);
        }

        events.Should().HaveCount(2);
        events[0].Type.Should().Be(TTSSSEEventDiscriminatorType.Chunk);
        events[0].IsAudioChunk.Should().BeTrue();
        events[0].Audio.ToArray().Should().Equal(1, 2, 3, 4);
        events[0].ContextId.Should().Be("ctx-1");
        events[0].StatusCode.Should().Be(206);
        events[0].StepTime.Should().BeApproximately(12.5d, 0.00001d);

        events[1].Type.Should().Be(TTSSSEEventDiscriminatorType.Done);
        events[1].IsDone.Should().BeTrue();
        events[1].ContextId.Should().Be("ctx-1");
        events[1].StatusCode.Should().Be(206);

        handler.RequestUri.Should().Be(new Uri("https://api.cartesia.ai/tts/sse"));
        handler.CartesiaVersion.Should().Be(CartesiaTtsSseExtensions.DefaultTtsSseCartesiaVersion.ToValueString());
    }

    private sealed class TtsSseResponseHandler : HttpMessageHandler
    {
        public Uri? RequestUri { get; private set; }
        public string? CartesiaVersion { get; private set; }

        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            RequestUri = request.RequestUri;
            CartesiaVersion = request.Headers.GetValues("Cartesia-Version").Single();

            const string body =
                "data: {\"type\":\"chunk\",\"done\":false,\"status_code\":206,\"step_time\":12.5,\"context_id\":\"ctx-1\",\"data\":\"AQIDBA==\"}\n\n" +
                "data: {\"type\":\"done\",\"done\":true,\"status_code\":206,\"context_id\":\"ctx-1\"}\n\n";

            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
            {
                RequestMessage = request,
                Content = new StringContent(body, Encoding.UTF8, "text/event-stream"),
            });
        }
    }
}
