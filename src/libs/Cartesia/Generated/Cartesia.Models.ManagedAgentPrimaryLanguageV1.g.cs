
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// ISO 639-1 language code used for speech recognition, agent responses, and speech synthesis.
    /// </summary>
    public enum ManagedAgentPrimaryLanguageV1
    {
        /// <summary>
        ///
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
        ///
        /// </summary>
        Cs,
        /// <summary>
        ///
        /// </summary>
        Da,
        /// <summary>
        ///
        /// </summary>
        De,
        /// <summary>
        ///
        /// </summary>
        El,
        /// <summary>
        ///
        /// </summary>
        En,
        /// <summary>
        ///
        /// </summary>
        Es,
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
        Gu,
        /// <summary>
        ///
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
        ///
        /// </summary>
        Id,
        /// <summary>
        ///
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
        No,
        /// <summary>
        ///
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
        ///
        /// </summary>
        Pt,
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
        ///
        /// </summary>
        Te,
        /// <summary>
        ///
        /// </summary>
        Th,
        /// <summary>
        ///
        /// </summary>
        Tl,
        /// <summary>
        ///
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
    public static class ManagedAgentPrimaryLanguageV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedAgentPrimaryLanguageV1 value)
        {
            return value switch
            {
                ManagedAgentPrimaryLanguageV1.Ar => "ar",
                ManagedAgentPrimaryLanguageV1.Bg => "bg",
                ManagedAgentPrimaryLanguageV1.Bn => "bn",
                ManagedAgentPrimaryLanguageV1.Cs => "cs",
                ManagedAgentPrimaryLanguageV1.Da => "da",
                ManagedAgentPrimaryLanguageV1.De => "de",
                ManagedAgentPrimaryLanguageV1.El => "el",
                ManagedAgentPrimaryLanguageV1.En => "en",
                ManagedAgentPrimaryLanguageV1.Es => "es",
                ManagedAgentPrimaryLanguageV1.Fi => "fi",
                ManagedAgentPrimaryLanguageV1.Fr => "fr",
                ManagedAgentPrimaryLanguageV1.Gu => "gu",
                ManagedAgentPrimaryLanguageV1.He => "he",
                ManagedAgentPrimaryLanguageV1.Hi => "hi",
                ManagedAgentPrimaryLanguageV1.Hr => "hr",
                ManagedAgentPrimaryLanguageV1.Hu => "hu",
                ManagedAgentPrimaryLanguageV1.Id => "id",
                ManagedAgentPrimaryLanguageV1.It => "it",
                ManagedAgentPrimaryLanguageV1.Ja => "ja",
                ManagedAgentPrimaryLanguageV1.Ka => "ka",
                ManagedAgentPrimaryLanguageV1.Kn => "kn",
                ManagedAgentPrimaryLanguageV1.Ko => "ko",
                ManagedAgentPrimaryLanguageV1.Ml => "ml",
                ManagedAgentPrimaryLanguageV1.Mr => "mr",
                ManagedAgentPrimaryLanguageV1.Ms => "ms",
                ManagedAgentPrimaryLanguageV1.Nl => "nl",
                ManagedAgentPrimaryLanguageV1.No => "no",
                ManagedAgentPrimaryLanguageV1.Or => "or",
                ManagedAgentPrimaryLanguageV1.Pa => "pa",
                ManagedAgentPrimaryLanguageV1.Pl => "pl",
                ManagedAgentPrimaryLanguageV1.Pt => "pt",
                ManagedAgentPrimaryLanguageV1.Ro => "ro",
                ManagedAgentPrimaryLanguageV1.Ru => "ru",
                ManagedAgentPrimaryLanguageV1.Sk => "sk",
                ManagedAgentPrimaryLanguageV1.Sv => "sv",
                ManagedAgentPrimaryLanguageV1.Ta => "ta",
                ManagedAgentPrimaryLanguageV1.Te => "te",
                ManagedAgentPrimaryLanguageV1.Th => "th",
                ManagedAgentPrimaryLanguageV1.Tl => "tl",
                ManagedAgentPrimaryLanguageV1.Tr => "tr",
                ManagedAgentPrimaryLanguageV1.Uk => "uk",
                ManagedAgentPrimaryLanguageV1.Ur => "ur",
                ManagedAgentPrimaryLanguageV1.Vi => "vi",
                ManagedAgentPrimaryLanguageV1.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedAgentPrimaryLanguageV1? ToEnum(string value)
        {
            return value switch
            {
                "ar" => ManagedAgentPrimaryLanguageV1.Ar,
                "bg" => ManagedAgentPrimaryLanguageV1.Bg,
                "bn" => ManagedAgentPrimaryLanguageV1.Bn,
                "cs" => ManagedAgentPrimaryLanguageV1.Cs,
                "da" => ManagedAgentPrimaryLanguageV1.Da,
                "de" => ManagedAgentPrimaryLanguageV1.De,
                "el" => ManagedAgentPrimaryLanguageV1.El,
                "en" => ManagedAgentPrimaryLanguageV1.En,
                "es" => ManagedAgentPrimaryLanguageV1.Es,
                "fi" => ManagedAgentPrimaryLanguageV1.Fi,
                "fr" => ManagedAgentPrimaryLanguageV1.Fr,
                "gu" => ManagedAgentPrimaryLanguageV1.Gu,
                "he" => ManagedAgentPrimaryLanguageV1.He,
                "hi" => ManagedAgentPrimaryLanguageV1.Hi,
                "hr" => ManagedAgentPrimaryLanguageV1.Hr,
                "hu" => ManagedAgentPrimaryLanguageV1.Hu,
                "id" => ManagedAgentPrimaryLanguageV1.Id,
                "it" => ManagedAgentPrimaryLanguageV1.It,
                "ja" => ManagedAgentPrimaryLanguageV1.Ja,
                "ka" => ManagedAgentPrimaryLanguageV1.Ka,
                "kn" => ManagedAgentPrimaryLanguageV1.Kn,
                "ko" => ManagedAgentPrimaryLanguageV1.Ko,
                "ml" => ManagedAgentPrimaryLanguageV1.Ml,
                "mr" => ManagedAgentPrimaryLanguageV1.Mr,
                "ms" => ManagedAgentPrimaryLanguageV1.Ms,
                "nl" => ManagedAgentPrimaryLanguageV1.Nl,
                "no" => ManagedAgentPrimaryLanguageV1.No,
                "or" => ManagedAgentPrimaryLanguageV1.Or,
                "pa" => ManagedAgentPrimaryLanguageV1.Pa,
                "pl" => ManagedAgentPrimaryLanguageV1.Pl,
                "pt" => ManagedAgentPrimaryLanguageV1.Pt,
                "ro" => ManagedAgentPrimaryLanguageV1.Ro,
                "ru" => ManagedAgentPrimaryLanguageV1.Ru,
                "sk" => ManagedAgentPrimaryLanguageV1.Sk,
                "sv" => ManagedAgentPrimaryLanguageV1.Sv,
                "ta" => ManagedAgentPrimaryLanguageV1.Ta,
                "te" => ManagedAgentPrimaryLanguageV1.Te,
                "th" => ManagedAgentPrimaryLanguageV1.Th,
                "tl" => ManagedAgentPrimaryLanguageV1.Tl,
                "tr" => ManagedAgentPrimaryLanguageV1.Tr,
                "uk" => ManagedAgentPrimaryLanguageV1.Uk,
                "ur" => ManagedAgentPrimaryLanguageV1.Ur,
                "vi" => ManagedAgentPrimaryLanguageV1.Vi,
                "zh" => ManagedAgentPrimaryLanguageV1.Zh,
                _ => null,
            };
        }
    }
}