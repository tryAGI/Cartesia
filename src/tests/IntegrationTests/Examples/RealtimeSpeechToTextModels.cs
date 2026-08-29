/*
order: 30
title: Realtime Speech To Text Models
slug: realtime-speech-to-text-models

Use Sonic 3.6 for text-to-speech and Ink 2 for realtime speech-to-text.
*/

namespace Cartesia.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void RealtimeSpeechToText_ModelsExposeStableIds()
    {
        //// Sonic 3.6 exposes both the rolling stable alias and immutable production snapshot.
        TTSModel.Sonic36.ToValueString().Should().Be("sonic-3.6");
        TTSModel.Sonic3620260827.ToValueString().Should().Be("sonic-3.6-2026-08-27");

        //// Ink 2 is available for realtime STT auto-finalize and manual-finalize sessions.
        STTAutoFinalizeModel.Ink2.ToValueString().Should().Be("ink-2");
        STTManualFinalizeModel.Ink2.ToValueString().Should().Be("ink-2");

        //// Batch STT is still limited to Ink Whisper until Cartesia enables Ink 2 on /stt.
        STTBatchModel.InkWhisper.ToValueString().Should().Be("ink-whisper");
        STTBatchModelExtensions.ToEnum("ink-2").Should().BeNull();
    }

    [TestMethod]
    public void RealtimeSpeechToText_KeytermsAreAvailableOnBothModes()
    {
        //// Keyterm prompting biases Ink 2 toward product names, jargon, and uncommon phrases.
        string[] keyterms = ["Cartesia", "Ink 2", "Sonic"];

        var auto = new STTAutoFinalizeWebSocketQueryParams(
            model: STTAutoFinalizeModel.Ink2,
            encoding: STTEncoding.PcmS16le,
            sampleRate: 16000,
            keyterm: keyterms);
        var manual = new STTManualFinalizeWebSocketQueryParams(
            model: STTManualFinalizeModel.Ink2,
            encoding: STTEncoding.PcmS16le,
            sampleRate: 16000,
            language: null,
            minVolume: null,
            maxSilenceDurationSecs: null,
            keyterm: keyterms);

        auto.Keyterm.Should().Equal(keyterms);
        manual.Keyterm.Should().Equal(keyterms);
    }

    [TestMethod]
    public async Task RealtimeSpeechToText_KeytermsEnforceConnectionLimits()
    {
        using var api = new CartesiaClient("dummy-key");
        var tooManyKeyterms = Enumerable.Repeat("Cartesia", 101).ToArray();
        string[] tooLongKeyterms = [new('x', 1201)];

        var tooManyAct = () => api.ConnectRealtimeSttAutoAsync(
            STTEncoding.PcmS16le,
            sampleRate: 16000,
            keyterms: tooManyKeyterms);
        var tooLongAct = () => api.ConnectRealtimeSttManualAsync(
            STTEncoding.PcmS16le,
            sampleRate: 16000,
            keyterms: tooLongKeyterms);

        await Assert.ThrowsExactlyAsync<ArgumentException>(tooManyAct);
        await Assert.ThrowsExactlyAsync<ArgumentException>(tooLongAct);
    }

    [TestMethod]
    public void RealtimeSpeechToText_AutoFinalizeParsesInk2TurnEvents()
    {
        var response = STTAutoFinalizeWebSocketResponse.FromJson(
            """
            {
              "type": "turn.end",
              "transcript": "Can you help me with my order?",
              "request_id": "2ff8af53-4d38-479d-8287-58940f01c701"
            }
            """,
            SourceGenerationContext.Default);

        response.Should().NotBeNull();
        response!.Value.IsTurnEnd.Should().BeTrue();
        response.Value.PickTurnEnd().Transcript.Should().Be("Can you help me with my order?");
    }

    [TestMethod]
    public void RealtimeSpeechToText_ManualFinalizeParsesInk2TranscriptEvents()
    {
        var response = STTManualFinalizeWebSocketResponse.FromJson(
            """
            {
              "type": "transcript",
              "request_id": "b67e1c5d-2f4c-4c3d-9f82-96eb4d2f12a8",
              "text": "How are you doing today?",
              "is_final": true,
              "duration": 2.5,
              "language": "en"
            }
            """,
            SourceGenerationContext.Default);

        response.Should().NotBeNull();
        response!.Value.IsTranscript.Should().BeTrue();

        var transcript = response.Value.PickTranscript();
        transcript.Text.Should().Be("How are you doing today?");
        transcript.IsFinal.Should().BeTrue();
        transcript.Language.Should().Be("en");
    }
}
