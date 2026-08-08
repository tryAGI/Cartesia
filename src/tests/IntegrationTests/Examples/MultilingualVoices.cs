/*
order: 35
title: Multilingual Voices
slug: multilingual-voices

Discover every locale a voice supports before selecting its language for synthesis.
*/

namespace Cartesia.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void MultilingualVoices_ParseSupportedLocales()
    {
        //// Voice responses identify both the native locale and attached cross-lingual locales.
        var voice = Voice.FromJson(
            """
            {
              "id": "db6b0ed5-d5d3-463d-ae85-518a07d3c2b4",
              "is_owner": false,
              "is_public": true,
              "name": "Skylar",
              "description": "Friendly multilingual guide",
              "created_at": "2026-03-31T17:37:05.961874Z",
              "language": "en",
              "locales": [
                { "locale": "en-US", "is_native": true },
                { "locale": "es-MX", "is_native": false },
                { "locale": "hi-IN", "is_native": false }
              ]
            }
            """,
            SourceGenerationContext.Default);

        voice.Should().NotBeNull();
        voice!.Locales.Should().HaveCount(3);
        voice.Locales[0].Locale.Should().Be("en-US");
        voice.Locales[0].IsNative.Should().BeTrue();
        voice.Locales.Select(locale => locale.Locale).Should().Contain("es-MX").And.Contain("hi-IN");
    }

    [TestMethod]
    public void MultilingualVoices_ExposeAllTtsLanguages()
    {
        //// The TTS language model includes all 42 languages currently published by Cartesia.
        Enum.GetValues<SupportedLanguage>().Should().HaveCount(42);
        SupportedLanguage.Ar.ToValueString().Should().Be("ar");
        SupportedLanguage.He.ToValueString().Should().Be("he");
        SupportedLanguage.Ta.ToValueString().Should().Be("ta");
        SupportedLanguage.Te.ToValueString().Should().Be("te");
        SupportedLanguage.Th.ToValueString().Should().Be("th");
    }
}
