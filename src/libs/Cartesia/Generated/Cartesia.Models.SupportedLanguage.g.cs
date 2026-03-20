
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The language that the given voice should speak the transcript in. For valid options, see [Models](/build-with-cartesia/tts-models).
    /// </summary>
    public enum SupportedLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        En,
        /// <summary>
        /// 
        /// </summary>
        Fr,
        /// <summary>
        /// 
        /// </summary>
        De,
        /// <summary>
        /// 
        /// </summary>
        Es,
        /// <summary>
        /// 
        /// </summary>
        Pt,
        /// <summary>
        /// 
        /// </summary>
        Zh,
        /// <summary>
        /// 
        /// </summary>
        Ja,
        /// <summary>
        /// 
        /// </summary>
        Hi,
        /// <summary>
        /// 
        /// </summary>
        It,
        /// <summary>
        /// 
        /// </summary>
        Ko,
        /// <summary>
        /// 
        /// </summary>
        Nl,
        /// <summary>
        /// 
        /// </summary>
        Pl,
        /// <summary>
        /// 
        /// </summary>
        Ru,
        /// <summary>
        /// 
        /// </summary>
        Sv,
        /// <summary>
        /// 
        /// </summary>
        Tr,
        /// <summary>
        /// 
        /// </summary>
        Tl,
        /// <summary>
        /// 
        /// </summary>
        Bg,
        /// <summary>
        /// 
        /// </summary>
        Ro,
        /// <summary>
        /// 
        /// </summary>
        Ar,
        /// <summary>
        /// 
        /// </summary>
        Cs,
        /// <summary>
        /// 
        /// </summary>
        El,
        /// <summary>
        /// 
        /// </summary>
        Fi,
        /// <summary>
        /// 
        /// </summary>
        Hr,
        /// <summary>
        /// 
        /// </summary>
        Ms,
        /// <summary>
        /// 
        /// </summary>
        Sk,
        /// <summary>
        /// 
        /// </summary>
        Da,
        /// <summary>
        /// 
        /// </summary>
        Ta,
        /// <summary>
        /// 
        /// </summary>
        Uk,
        /// <summary>
        /// 
        /// </summary>
        Hu,
        /// <summary>
        /// 
        /// </summary>
        No,
        /// <summary>
        /// 
        /// </summary>
        Vi,
        /// <summary>
        /// 
        /// </summary>
        Bn,
        /// <summary>
        /// 
        /// </summary>
        Th,
        /// <summary>
        /// 
        /// </summary>
        He,
        /// <summary>
        /// 
        /// </summary>
        Ka,
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        Te,
        /// <summary>
        /// 
        /// </summary>
        Gu,
        /// <summary>
        /// 
        /// </summary>
        Kn,
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
        Pa,
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
                SupportedLanguage.En => "en",
                SupportedLanguage.Fr => "fr",
                SupportedLanguage.De => "de",
                SupportedLanguage.Es => "es",
                SupportedLanguage.Pt => "pt",
                SupportedLanguage.Zh => "zh",
                SupportedLanguage.Ja => "ja",
                SupportedLanguage.Hi => "hi",
                SupportedLanguage.It => "it",
                SupportedLanguage.Ko => "ko",
                SupportedLanguage.Nl => "nl",
                SupportedLanguage.Pl => "pl",
                SupportedLanguage.Ru => "ru",
                SupportedLanguage.Sv => "sv",
                SupportedLanguage.Tr => "tr",
                SupportedLanguage.Tl => "tl",
                SupportedLanguage.Bg => "bg",
                SupportedLanguage.Ro => "ro",
                SupportedLanguage.Ar => "ar",
                SupportedLanguage.Cs => "cs",
                SupportedLanguage.El => "el",
                SupportedLanguage.Fi => "fi",
                SupportedLanguage.Hr => "hr",
                SupportedLanguage.Ms => "ms",
                SupportedLanguage.Sk => "sk",
                SupportedLanguage.Da => "da",
                SupportedLanguage.Ta => "ta",
                SupportedLanguage.Uk => "uk",
                SupportedLanguage.Hu => "hu",
                SupportedLanguage.No => "no",
                SupportedLanguage.Vi => "vi",
                SupportedLanguage.Bn => "bn",
                SupportedLanguage.Th => "th",
                SupportedLanguage.He => "he",
                SupportedLanguage.Ka => "ka",
                SupportedLanguage.Id => "id",
                SupportedLanguage.Te => "te",
                SupportedLanguage.Gu => "gu",
                SupportedLanguage.Kn => "kn",
                SupportedLanguage.Ml => "ml",
                SupportedLanguage.Mr => "mr",
                SupportedLanguage.Pa => "pa",
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
                "en" => SupportedLanguage.En,
                "fr" => SupportedLanguage.Fr,
                "de" => SupportedLanguage.De,
                "es" => SupportedLanguage.Es,
                "pt" => SupportedLanguage.Pt,
                "zh" => SupportedLanguage.Zh,
                "ja" => SupportedLanguage.Ja,
                "hi" => SupportedLanguage.Hi,
                "it" => SupportedLanguage.It,
                "ko" => SupportedLanguage.Ko,
                "nl" => SupportedLanguage.Nl,
                "pl" => SupportedLanguage.Pl,
                "ru" => SupportedLanguage.Ru,
                "sv" => SupportedLanguage.Sv,
                "tr" => SupportedLanguage.Tr,
                "tl" => SupportedLanguage.Tl,
                "bg" => SupportedLanguage.Bg,
                "ro" => SupportedLanguage.Ro,
                "ar" => SupportedLanguage.Ar,
                "cs" => SupportedLanguage.Cs,
                "el" => SupportedLanguage.El,
                "fi" => SupportedLanguage.Fi,
                "hr" => SupportedLanguage.Hr,
                "ms" => SupportedLanguage.Ms,
                "sk" => SupportedLanguage.Sk,
                "da" => SupportedLanguage.Da,
                "ta" => SupportedLanguage.Ta,
                "uk" => SupportedLanguage.Uk,
                "hu" => SupportedLanguage.Hu,
                "no" => SupportedLanguage.No,
                "vi" => SupportedLanguage.Vi,
                "bn" => SupportedLanguage.Bn,
                "th" => SupportedLanguage.Th,
                "he" => SupportedLanguage.He,
                "ka" => SupportedLanguage.Ka,
                "id" => SupportedLanguage.Id,
                "te" => SupportedLanguage.Te,
                "gu" => SupportedLanguage.Gu,
                "kn" => SupportedLanguage.Kn,
                "ml" => SupportedLanguage.Ml,
                "mr" => SupportedLanguage.Mr,
                "pa" => SupportedLanguage.Pa,
                _ => null,
            };
        }
    }
}