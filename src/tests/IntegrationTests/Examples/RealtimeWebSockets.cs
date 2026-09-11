/*
order: 40
title: Realtime WebSockets
slug: realtime-websockets

Use the generated WebSocket clients for realtime TTS plus manual and turn-detecting STT.
*/

using ManualStt = Cartesia.Realtime.SpeechToText;
using TurnStt = Cartesia.Realtime.SpeechToTextTurns;
using Tts = Cartesia.Realtime.TextToSpeech;

namespace Cartesia.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void RealtimeTextToSpeech_ExposesSonic36ControlsAndEveryServerEvent()
    {
        //// Realtime Sonic 3.6 requests expose locale, accent, and normalization controls.
        var request = new Tts.GenerationRequest
        {
            ModelId = Tts.GenerationRequestModelId.Sonic36,
            Transcript = "Welcome to London.",
            Voice = "voice_123",
            OutputFormat = new Tts.GenerationRequestOutputFormat
            {
                Encoding = Tts.GenerationRequestOutputFormatEncoding.PcmS16le,
                SampleRate = 24000,
            },
            Locale = Tts.GenerationRequestLocale.EnGb,
            Accent = "British",
            Normalization = "auto",
            ContextId = "context_123",
        };

        var json = request.ToJson(Tts.TextToSpeechSourceGenerationContext.Default);

        json.Should().Contain("\"model_id\":\"sonic-3.6\"");
        json.Should().Contain("\"locale\":\"en-GB\"");
        json.Should().Contain("\"accent\":\"British\"");
        json.Should().Contain("\"normalization\":\"auto\"");

        //// All documented response variants are available on the discriminator-backed union.
        typeof(Tts.ServerEvent).GetProperties().Select(property => property.Name).Should().Contain([
            "Chunk",
            "FlushDone",
            "Done",
            "Timestamps",
            "PhonemeTimestamps",
            "Error",
        ]);

        var done = Tts.ServerEvent.FromJson(
            """
            {
              "type": "done",
              "done": true,
              "status_code": 200,
              "context_id": "context_123"
            }
            """,
            Tts.TextToSpeechSourceGenerationContext.Default);

        done.Should().NotBeNull();
        done!.Value.IsDone.Should().BeTrue();
        done.Value.PickDone().ContextId.Should().Be("context_123");
    }

    [TestMethod]
    public void RealtimeTextToSpeech_ClientExposesFullProtocolSurface()
    {
        var methodNames = typeof(Tts.CartesiaTextToSpeechRealtimeClient)
            .GetMethods()
            .Select(method => method.Name)
            .ToHashSet();

        methodNames.Should().Contain([
            "AuthorizeUsingApiKeyInHeader",
            "AuthorizeUsingApiKeyInQuery",
            "ConnectAsync",
            "SendGenerationRequestAsync",
            "SendCancelRequestAsync",
            "ReceiveUpdatesAsync",
        ]);
    }

    [TestMethod]
    public void RealtimeSpeechToText_ManualProtocolUsesBinaryAudioAndPlainTextCommands()
    {
        var clientType = typeof(ManualStt.CartesiaSpeechToTextRealtimeClient);
        var methodNames = clientType.GetMethods().Select(method => method.Name).ToHashSet();

        methodNames.Should().Contain([
            "AuthorizeUsingApiKeyInHeader",
            "AuthorizeUsingApiKeyInQuery",
            "ConnectAsync",
            "SendSTTAudioDataAsync",
            "SendSTTFinalizeCommandAsync",
            "SendSTTCloseCommandAsync",
            "ReceiveUpdatesAsync",
        ]);
        clientType.GetMethod("SendSTTAudioDataAsync")!
            .GetParameters()[0].ParameterType.Should().Be<byte[]>();
        ManualStt.STTFinalizeCommandExtensions.ToValueString(ManualStt.STTFinalizeCommand.Finalize)
            .Should().Be("finalize");
        ManualStt.STTCloseCommandExtensions.ToValueString(ManualStt.STTCloseCommand.Close)
            .Should().Be("close");

        //// Manual STT returns transcript, flush, done, and error events.
        typeof(ManualStt.ServerEvent).GetProperties().Select(property => property.Name).Should().Contain([
            "Transcript",
            "FlushDone",
            "Done",
            "Error",
        ]);

        var transcript = ManualStt.ServerEvent.FromJson(
            """
            {
              "type": "transcript",
              "is_final": true,
              "request_id": "request_123",
              "text": "Cartesia realtime transcription"
            }
            """,
            ManualStt.SpeechToTextSourceGenerationContext.Default);

        transcript.Should().NotBeNull();
        transcript!.Value.IsTranscript.Should().BeTrue();
        transcript.Value.PickTranscript().Text.Should().Be("Cartesia realtime transcription");
    }

    [TestMethod]
    public void RealtimeSpeechToText_TurnProtocolExposesConfigurationAndEveryEvent()
    {
        var clientType = typeof(TurnStt.CartesiaSpeechToTextTurnsRealtimeClient);
        var methodNames = clientType.GetMethods().Select(method => method.Name).ToHashSet();

        methodNames.Should().Contain([
            "AuthorizeUsingApiKeyInHeader",
            "AuthorizeUsingApiKeyInQuery",
            "ConnectAsync",
            "SendSTTTurnsAudioDataAsync",
            "SendSTTTurnsCloseCommandAsync",
            "SendSTTTurnsConfigCommandAsync",
            "ReceiveUpdatesAsync",
        ]);
        clientType.GetMethod("SendSTTTurnsAudioDataAsync")!
            .GetParameters()[0].ParameterType.Should().Be<byte[]>();

        //// Turn-aware STT exposes connected, start, update, eager-end, resume, end, and error events.
        typeof(TurnStt.ServerEvent).GetProperties().Select(property => property.Name).Should().Contain([
            "Connected",
            "TurnStart",
            "TurnUpdate",
            "TurnEagerEnd",
            "TurnResume",
            "TurnEnd",
            "Error",
        ]);

        var turnEnd = TurnStt.ServerEvent.FromJson(
            """
            {
              "type": "turn.end",
              "transcript": "How can I help?",
              "request_id": "request_456"
            }
            """,
            TurnStt.SpeechToTextTurnsSourceGenerationContext.Default);

        turnEnd.Should().NotBeNull();
        turnEnd!.Value.IsTurnEnd.Should().BeTrue();
        turnEnd.Value.PickTurnEnd().Transcript.Should().Be("How can I help?");
    }
}
