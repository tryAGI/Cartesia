/*
order: 65
title: Latest Text To Speech Model
slug: latest-text-to-speech-model

Exercise the production Sonic 3.6 snapshot end to end with Russian text.
*/

namespace Cartesia.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [Timeout(60_000)]
    public async Task Example_LatestTextToSpeechModel()
    {
        using var client = GetAuthenticatedClient();

        var audio = await client.Tts.TtsBytesAsync(
            TtsBytesCartesiaVersion.x20251104,
            new TTSRequest
            {
                ModelId = TTSModel.Sonic3620260827,
                Transcript = "Привет! Это стабильная модель Cartesia Sonic 3.6.",
                Voice = new TTSRequestVoiceSpecifier
                {
                    Mode = TTSRequestVoiceSpecifierMode.Id,
                    Id = "694f9389-aac1-45b6-b726-9d9369183238",
                },
                Language = SupportedLanguage.Ru,
                OutputFormat = new RawOutputFormat
                {
                    Container = RawOutputFormatContainer.Raw,
                    Encoding = RawEncoding.PcmS16le,
                    SampleRate = 24000,
                },
            });

        audio.Should().NotBeNullOrEmpty();
    }
}
