
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The language that the given voice should speak the transcript in. For valid options, see [Models](https://docs.cartesia.ai/build-with-cartesia/tts-models).
    /// </summary>
    public enum SupportedLanguage
    {
        /// <summary>
        /// //docs.cartesia.ai/build-with-cartesia/tts-models).
        /// </summary>
        Ar,
        /// <summary>
        /// 
        /// </summary>
        Bg,
        /// <summary>
        /// 
        /// </summary>
        Bn,
        /// <summary>
        /// //docs.cartesia.ai/build-with-cartesia/tts-models).
        /// </summary>
        Cs,
        /// <summary>
        /// 
        /// </summary>
        Da,
        /// <summary>
        /// //docs.cartesia.ai/build-with-cartesia/tts-models).
        /// </summary>
        De,
        /// <summary>
        /// //docs.cartesia.ai/build-with-cartesia/tts-models).
        /// </summary>
        El,
        /// <summary>
        /// //docs.cartesia.ai/build-with-cartesia/tts-models).
        /// </summary>
        En,
        /// <summary>
        /// 
        /// </summary>
        EnAu,
        /// <summary>
        /// 
        /// </summary>
        EnGb,
        /// <summary>
        /// 
        /// </summary>
        EnIe,
        /// <summary>
        /// 
        /// </summary>
        EnIn,
        /// <summary>
        /// 
        /// </summary>
        EnNz,
        /// <summary>
        /// 
        /// </summary>
        EnSg,
        /// <summary>
        /// 
        /// </summary>
        EnUs,
        /// <summary>
        /// 
        /// </summary>
        EnZa,
        /// <summary>
        /// //docs.cartesia.ai/build-with-cartesia/tts-models).
        /// </summary>
        Es,
        /// <summary>
        /// 
        /// </summary>
        EsEs,
        /// <summary>
        /// 
        /// </summary>
        EsMx,
        /// <summary>
        /// 
        /// </summary>
        EsUs,
        /// <summary>
        /// 
        /// </summary>
        Fi,
        /// <summary>
        /// 
        /// </summary>
        Fr,
        /// <summary>
        /// 
        /// </summary>
        FrCa,
        /// <summary>
        /// 
        /// </summary>
        FrFr,
        /// <summary>
        /// //docs.cartesia.ai/build-with-cartesia/tts-models).
        /// </summary>
        Gu,
        /// <summary>
        /// //docs.cartesia.ai/build-with-cartesia/tts-models).
        /// </summary>
        He,
        /// <summary>
        /// 
        /// </summary>
        Hi,
        /// <summary>
        /// 
        /// </summary>
        Hr,
        /// <summary>
        /// 
        /// </summary>
        Hu,
        /// <summary>
        /// //docs.cartesia.ai/build-with-cartesia/tts-models).
        /// </summary>
        Id,
        /// <summary>
        /// //docs.cartesia.ai/build-with-cartesia/tts-models).
        /// </summary>
        It,
        /// <summary>
        /// 
        /// </summary>
        Ja,
        /// <summary>
        /// 
        /// </summary>
        Ka,
        /// <summary>
        /// 
        /// </summary>
        Kn,
        /// <summary>
        /// 
        /// </summary>
        Ko,
        /// <summary>
        /// 
        /// </summary>
        Ml,
        /// <summary>
        /// 
        /// </summary>
        Mr,
        /// <summary>
        /// 
        /// </summary>
        Ms,
        /// <summary>
        /// 
        /// </summary>
        Nl,
        /// <summary>
        /// 
        /// </summary>
        NlBe,
        /// <summary>
        /// 
        /// </summary>
        NlNl,
        /// <summary>
        /// 
        /// </summary>
        No,
        /// <summary>
        /// //docs.cartesia.ai/build-with-cartesia/tts-models).
        /// </summary>
        Or,
        /// <summary>
        /// 
        /// </summary>
        Pa,
        /// <summary>
        /// 
        /// </summary>
        Pl,
        /// <summary>
        /// //docs.cartesia.ai/build-with-cartesia/tts-models).
        /// </summary>
        Pt,
        /// <summary>
        /// 
        /// </summary>
        PtBr,
        /// <summary>
        /// 
        /// </summary>
        PtPt,
        /// <summary>
        /// 
        /// </summary>
        Ro,
        /// <summary>
        /// 
        /// </summary>
        Ru,
        /// <summary>
        /// 
        /// </summary>
        Sk,
        /// <summary>
        /// 
        /// </summary>
        Sv,
        /// <summary>
        /// 
        /// </summary>
        Ta,
        /// <summary>
        /// //docs.cartesia.ai/build-with-cartesia/tts-models).
        /// </summary>
        Te,
        /// <summary>
        /// //docs.cartesia.ai/build-with-cartesia/tts-models).
        /// </summary>
        Th,
        /// <summary>
        /// 
        /// </summary>
        Tl,
        /// <summary>
        /// //docs.cartesia.ai/build-with-cartesia/tts-models).
        /// </summary>
        Tr,
        /// <summary>
        /// 
        /// </summary>
        Uk,
        /// <summary>
        /// 
        /// </summary>
        Ur,
        /// <summary>
        /// 
        /// </summary>
        Vi,
        /// <summary>
        /// 
        /// </summary>
        Zh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SupportedLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SupportedLanguage value)
        {
            return value switch
            {
                SupportedLanguage.Ar => "ar",
                SupportedLanguage.Bg => "bg",
                SupportedLanguage.Bn => "bn",
                SupportedLanguage.Cs => "cs",
                SupportedLanguage.Da => "da",
                SupportedLanguage.De => "de",
                SupportedLanguage.El => "el",
                SupportedLanguage.En => "en",
                SupportedLanguage.EnAu => "en-AU",
                SupportedLanguage.EnGb => "en-GB",
                SupportedLanguage.EnIe => "en-IE",
                SupportedLanguage.EnIn => "en-IN",
                SupportedLanguage.EnNz => "en-NZ",
                SupportedLanguage.EnSg => "en-SG",
                SupportedLanguage.EnUs => "en-US",
                SupportedLanguage.EnZa => "en-ZA",
                SupportedLanguage.Es => "es",
                SupportedLanguage.EsEs => "es-ES",
                SupportedLanguage.EsMx => "es-MX",
                SupportedLanguage.EsUs => "es-US",
                SupportedLanguage.Fi => "fi",
                SupportedLanguage.Fr => "fr",
                SupportedLanguage.FrCa => "fr-CA",
                SupportedLanguage.FrFr => "fr-FR",
                SupportedLanguage.Gu => "gu",
                SupportedLanguage.He => "he",
                SupportedLanguage.Hi => "hi",
                SupportedLanguage.Hr => "hr",
                SupportedLanguage.Hu => "hu",
                SupportedLanguage.Id => "id",
                SupportedLanguage.It => "it",
                SupportedLanguage.Ja => "ja",
                SupportedLanguage.Ka => "ka",
                SupportedLanguage.Kn => "kn",
                SupportedLanguage.Ko => "ko",
                SupportedLanguage.Ml => "ml",
                SupportedLanguage.Mr => "mr",
                SupportedLanguage.Ms => "ms",
                SupportedLanguage.Nl => "nl",
                SupportedLanguage.NlBe => "nl-BE",
                SupportedLanguage.NlNl => "nl-NL",
                SupportedLanguage.No => "no",
                SupportedLanguage.Or => "or",
                SupportedLanguage.Pa => "pa",
                SupportedLanguage.Pl => "pl",
                SupportedLanguage.Pt => "pt",
                SupportedLanguage.PtBr => "pt-BR",
                SupportedLanguage.PtPt => "pt-PT",
                SupportedLanguage.Ro => "ro",
                SupportedLanguage.Ru => "ru",
                SupportedLanguage.Sk => "sk",
                SupportedLanguage.Sv => "sv",
                SupportedLanguage.Ta => "ta",
                SupportedLanguage.Te => "te",
                SupportedLanguage.Th => "th",
                SupportedLanguage.Tl => "tl",
                SupportedLanguage.Tr => "tr",
                SupportedLanguage.Uk => "uk",
                SupportedLanguage.Ur => "ur",
                SupportedLanguage.Vi => "vi",
                SupportedLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SupportedLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => SupportedLanguage.Ar,
                "bg" => SupportedLanguage.Bg,
                "bn" => SupportedLanguage.Bn,
                "cs" => SupportedLanguage.Cs,
                "da" => SupportedLanguage.Da,
                "de" => SupportedLanguage.De,
                "el" => SupportedLanguage.El,
                "en" => SupportedLanguage.En,
                "en-AU" => SupportedLanguage.EnAu,
                "en-GB" => SupportedLanguage.EnGb,
                "en-IE" => SupportedLanguage.EnIe,
                "en-IN" => SupportedLanguage.EnIn,
                "en-NZ" => SupportedLanguage.EnNz,
                "en-SG" => SupportedLanguage.EnSg,
                "en-US" => SupportedLanguage.EnUs,
                "en-ZA" => SupportedLanguage.EnZa,
                "es" => SupportedLanguage.Es,
                "es-ES" => SupportedLanguage.EsEs,
                "es-MX" => SupportedLanguage.EsMx,
                "es-US" => SupportedLanguage.EsUs,
                "fi" => SupportedLanguage.Fi,
                "fr" => SupportedLanguage.Fr,
                "fr-CA" => SupportedLanguage.FrCa,
                "fr-FR" => SupportedLanguage.FrFr,
                "gu" => SupportedLanguage.Gu,
                "he" => SupportedLanguage.He,
                "hi" => SupportedLanguage.Hi,
                "hr" => SupportedLanguage.Hr,
                "hu" => SupportedLanguage.Hu,
                "id" => SupportedLanguage.Id,
                "it" => SupportedLanguage.It,
                "ja" => SupportedLanguage.Ja,
                "ka" => SupportedLanguage.Ka,
                "kn" => SupportedLanguage.Kn,
                "ko" => SupportedLanguage.Ko,
                "ml" => SupportedLanguage.Ml,
                "mr" => SupportedLanguage.Mr,
                "ms" => SupportedLanguage.Ms,
                "nl" => SupportedLanguage.Nl,
                "nl-BE" => SupportedLanguage.NlBe,
                "nl-NL" => SupportedLanguage.NlNl,
                "no" => SupportedLanguage.No,
                "or" => SupportedLanguage.Or,
                "pa" => SupportedLanguage.Pa,
                "pl" => SupportedLanguage.Pl,
                "pt" => SupportedLanguage.Pt,
                "pt-BR" => SupportedLanguage.PtBr,
                "pt-PT" => SupportedLanguage.PtPt,
                "ro" => SupportedLanguage.Ro,
                "ru" => SupportedLanguage.Ru,
                "sk" => SupportedLanguage.Sk,
                "sv" => SupportedLanguage.Sv,
                "ta" => SupportedLanguage.Ta,
                "te" => SupportedLanguage.Te,
                "th" => SupportedLanguage.Th,
                "tl" => SupportedLanguage.Tl,
                "tr" => SupportedLanguage.Tr,
                "uk" => SupportedLanguage.Uk,
                "ur" => SupportedLanguage.Ur,
                "vi" => SupportedLanguage.Vi,
                "zh" => SupportedLanguage.Zh,
                _ => null,
            };
        }
    }
}