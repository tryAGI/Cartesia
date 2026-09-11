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
    public void MultilingualVoices_ParseSupportedAccents()
    {
        //// Voice responses identify the native accent and every attached cross-lingual accent.
        var voice = Voice.FromJson(
            """
            {
              "id": "db6b0ed5-d5d3-463d-ae85-518a07d3c2b4",
              "is_owner": false,
              "status": "active",
              "access": "public",
              "visibility": "all",
              "name": "Skylar",
              "tagline": "Friendly Guide",
              "description": "Friendly multilingual guide",
              "created_at": "2026-03-31T17:37:05.961874Z",
              "language": "en",
              "accents": [
                { "accent": "general-american", "locale": "en-US", "is_native": true },
                { "accent": "mexican", "locale": "es-MX", "is_native": false },
                { "accent": "hindi", "locale": "hi-IN", "is_native": false }
              ]
            }
            """,
            SourceGenerationContext.Default);

        voice.Should().NotBeNull();
        voice!.Accents.Should().HaveCount(3);
        voice.Accents![0].Accent.Should().Be(VoiceAccent.GeneralAmerican);
        voice.Accents[0].Locale.Should().Be("en-US");
        voice.Accents[0].IsNative.Should().BeTrue();
        voice.Accents.Select(accent => accent.Locale).Should().Contain("es-MX").And.Contain("hi-IN");
    }

    [TestMethod]
    public void MultilingualVoices_ParseListResponseWithoutLocales()
    {
        //// Accent metadata remains optional for voices whose accent is not yet known.
        var voice = Voice.FromJson(
            """
            {
              "id": "db6b0ed5-d5d3-463d-ae85-518a07d3c2b4",
              "is_owner": false,
              "status": "active",
              "access": "public",
              "visibility": "all",
              "name": "Skylar",
              "tagline": "Friendly Guide",
              "description": "Friendly guide",
              "gender": "feminine",
              "language": "en",
              "country": "US",
              "created_at": "2026-03-31T17:37:05.961874Z"
            }
            """,
            SourceGenerationContext.Default);

        voice.Should().NotBeNull();
        voice!.Name.Should().Be("Skylar");
        voice.Accents.Should().BeNull();
    }

    [TestMethod]
    public void MultilingualVoices_ExposeAllTtsLanguages()
    {
        //// The TTS model includes all 44 languages plus 17 locale-specific selectors.
        Enum.GetValues<SupportedLanguage>().Should().HaveCount(61);
        SupportedLanguage.Ar.ToValueString().Should().Be("ar");
        SupportedLanguage.EnGb.ToValueString().Should().Be("en-GB");
        SupportedLanguage.He.ToValueString().Should().Be("he");
        SupportedLanguage.Or.ToValueString().Should().Be("or");
        SupportedLanguage.Ta.ToValueString().Should().Be("ta");
        SupportedLanguage.Te.ToValueString().Should().Be("te");
        SupportedLanguage.Th.ToValueString().Should().Be("th");
        SupportedLanguage.Ur.ToValueString().Should().Be("ur");
    }

    [TestMethod]
    public void InstantVoiceClones_ExposeAccentAndMultilingualControls()
    {
        //// Clone metadata can preserve the source accent, and owned clones can gain more native accents.
        var clone = new VoicesCloneRequest
        {
            Clip = [0x52, 0x49, 0x46, 0x46],
            Clipname = "speaker.wav",
            Name = "Multilingual speaker",
            Language = SupportedLanguage.En,
            Accent = VoiceAccent.GeneralAmerican,
        };
        var addedAccents = new AddVoiceAccentsRequest
        {
            Accents = [AttachVoiceAccent.British, AttachVoiceAccent.Mexican],
        };

        clone.ToJson(SourceGenerationContext.Default).Should().Contain("\"accent\":\"general-american\"");
        addedAccents.ToJson(SourceGenerationContext.Default).Should().Contain("\"accents\":[\"british\",\"mexican\"]");

        var operationNames = typeof(IVoicesClient).GetMethods().Select(method => method.Name).ToHashSet();
        operationNames.Should().Contain([
            "VoicesCloneAsync",
            "VoicesAddAccentsAsync",
            "VoicesDeleteAccentAsync",
            "AccentsListAsync",
        ]);
    }
}
