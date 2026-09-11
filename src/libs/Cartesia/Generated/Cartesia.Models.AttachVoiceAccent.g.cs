
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// See valid values from [GET /accents](/api-reference/accents/list) where `is_localizable` is `true`
    /// </summary>
    public enum AttachVoiceAccent
    {
        /// <summary>
        ///
        /// </summary>
        Australian,
        /// <summary>
        ///
        /// </summary>
        BrazilianPortuguese,
        /// <summary>
        ///
        /// </summary>
        British,
        /// <summary>
        ///
        /// </summary>
        CanadianFrench,
        /// <summary>
        ///
        /// </summary>
        Castilian,
        /// <summary>
        ///
        /// </summary>
        CentralTamil,
        /// <summary>
        ///
        /// </summary>
        CentralThai,
        /// <summary>
        ///
        /// </summary>
        Czech,
        /// <summary>
        ///
        /// </summary>
        EuropeanPortuguese,
        /// <summary>
        ///
        /// </summary>
        GeneralAmerican,
        /// <summary>
        ///
        /// </summary>
        IndianEnglish,
        /// <summary>
        ///
        /// </summary>
        Israeli,
        /// <summary>
        ///
        /// </summary>
        Istanbul,
        /// <summary>
        ///
        /// </summary>
        Korean,
        /// <summary>
        ///
        /// </summary>
        Mandarin,
        /// <summary>
        ///
        /// </summary>
        Mexican,
        /// <summary>
        ///
        /// </summary>
        ModernStandardArabic,
        /// <summary>
        ///
        /// </summary>
        Parisian,
        /// <summary>
        ///
        /// </summary>
        Polish,
        /// <summary>
        ///
        /// </summary>
        Randstad,
        /// <summary>
        ///
        /// </summary>
        Russian,
        /// <summary>
        ///
        /// </summary>
        Slovak,
        /// <summary>
        ///
        /// </summary>
        SouthernUs,
        /// <summary>
        ///
        /// </summary>
        StandardGerman,
        /// <summary>
        ///
        /// </summary>
        StandardHindi,
        /// <summary>
        ///
        /// </summary>
        StandardItalian,
        /// <summary>
        ///
        /// </summary>
        StandardJapanese,
        /// <summary>
        ///
        /// </summary>
        Stockholm,
        /// <summary>
        ///
        /// </summary>
        Telangana,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AttachVoiceAccentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AttachVoiceAccent value)
        {
            return value switch
            {
                AttachVoiceAccent.Australian => "australian",
                AttachVoiceAccent.BrazilianPortuguese => "brazilian-portuguese",
                AttachVoiceAccent.British => "british",
                AttachVoiceAccent.CanadianFrench => "canadian-french",
                AttachVoiceAccent.Castilian => "castilian",
                AttachVoiceAccent.CentralTamil => "central-tamil",
                AttachVoiceAccent.CentralThai => "central-thai",
                AttachVoiceAccent.Czech => "czech",
                AttachVoiceAccent.EuropeanPortuguese => "european-portuguese",
                AttachVoiceAccent.GeneralAmerican => "general-american",
                AttachVoiceAccent.IndianEnglish => "indian-english",
                AttachVoiceAccent.Israeli => "israeli",
                AttachVoiceAccent.Istanbul => "istanbul",
                AttachVoiceAccent.Korean => "korean",
                AttachVoiceAccent.Mandarin => "mandarin",
                AttachVoiceAccent.Mexican => "mexican",
                AttachVoiceAccent.ModernStandardArabic => "modern-standard-arabic",
                AttachVoiceAccent.Parisian => "parisian",
                AttachVoiceAccent.Polish => "polish",
                AttachVoiceAccent.Randstad => "randstad",
                AttachVoiceAccent.Russian => "russian",
                AttachVoiceAccent.Slovak => "slovak",
                AttachVoiceAccent.SouthernUs => "southern-us",
                AttachVoiceAccent.StandardGerman => "standard-german",
                AttachVoiceAccent.StandardHindi => "standard-hindi",
                AttachVoiceAccent.StandardItalian => "standard-italian",
                AttachVoiceAccent.StandardJapanese => "standard-japanese",
                AttachVoiceAccent.Stockholm => "stockholm",
                AttachVoiceAccent.Telangana => "telangana",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AttachVoiceAccent? ToEnum(string value)
        {
            return value switch
            {
                "australian" => AttachVoiceAccent.Australian,
                "brazilian-portuguese" => AttachVoiceAccent.BrazilianPortuguese,
                "british" => AttachVoiceAccent.British,
                "canadian-french" => AttachVoiceAccent.CanadianFrench,
                "castilian" => AttachVoiceAccent.Castilian,
                "central-tamil" => AttachVoiceAccent.CentralTamil,
                "central-thai" => AttachVoiceAccent.CentralThai,
                "czech" => AttachVoiceAccent.Czech,
                "european-portuguese" => AttachVoiceAccent.EuropeanPortuguese,
                "general-american" => AttachVoiceAccent.GeneralAmerican,
                "indian-english" => AttachVoiceAccent.IndianEnglish,
                "israeli" => AttachVoiceAccent.Israeli,
                "istanbul" => AttachVoiceAccent.Istanbul,
                "korean" => AttachVoiceAccent.Korean,
                "mandarin" => AttachVoiceAccent.Mandarin,
                "mexican" => AttachVoiceAccent.Mexican,
                "modern-standard-arabic" => AttachVoiceAccent.ModernStandardArabic,
                "parisian" => AttachVoiceAccent.Parisian,
                "polish" => AttachVoiceAccent.Polish,
                "randstad" => AttachVoiceAccent.Randstad,
                "russian" => AttachVoiceAccent.Russian,
                "slovak" => AttachVoiceAccent.Slovak,
                "southern-us" => AttachVoiceAccent.SouthernUs,
                "standard-german" => AttachVoiceAccent.StandardGerman,
                "standard-hindi" => AttachVoiceAccent.StandardHindi,
                "standard-italian" => AttachVoiceAccent.StandardItalian,
                "standard-japanese" => AttachVoiceAccent.StandardJapanese,
                "stockholm" => AttachVoiceAccent.Stockholm,
                "telangana" => AttachVoiceAccent.Telangana,
                _ => null,
            };
        }
    }
}