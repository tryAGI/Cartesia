
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Accent id from GET /accents, valid for the selected language.
    /// </summary>
    public enum LocalizeVoiceAccent
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
    public static class LocalizeVoiceAccentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalizeVoiceAccent value)
        {
            return value switch
            {
                LocalizeVoiceAccent.Australian => "australian",
                LocalizeVoiceAccent.BrazilianPortuguese => "brazilian-portuguese",
                LocalizeVoiceAccent.British => "british",
                LocalizeVoiceAccent.CanadianFrench => "canadian-french",
                LocalizeVoiceAccent.Castilian => "castilian",
                LocalizeVoiceAccent.CentralTamil => "central-tamil",
                LocalizeVoiceAccent.CentralThai => "central-thai",
                LocalizeVoiceAccent.Czech => "czech",
                LocalizeVoiceAccent.EuropeanPortuguese => "european-portuguese",
                LocalizeVoiceAccent.GeneralAmerican => "general-american",
                LocalizeVoiceAccent.IndianEnglish => "indian-english",
                LocalizeVoiceAccent.Israeli => "israeli",
                LocalizeVoiceAccent.Istanbul => "istanbul",
                LocalizeVoiceAccent.Korean => "korean",
                LocalizeVoiceAccent.Mandarin => "mandarin",
                LocalizeVoiceAccent.Mexican => "mexican",
                LocalizeVoiceAccent.ModernStandardArabic => "modern-standard-arabic",
                LocalizeVoiceAccent.Parisian => "parisian",
                LocalizeVoiceAccent.Polish => "polish",
                LocalizeVoiceAccent.Randstad => "randstad",
                LocalizeVoiceAccent.Russian => "russian",
                LocalizeVoiceAccent.Slovak => "slovak",
                LocalizeVoiceAccent.SouthernUs => "southern-us",
                LocalizeVoiceAccent.StandardGerman => "standard-german",
                LocalizeVoiceAccent.StandardHindi => "standard-hindi",
                LocalizeVoiceAccent.StandardItalian => "standard-italian",
                LocalizeVoiceAccent.StandardJapanese => "standard-japanese",
                LocalizeVoiceAccent.Stockholm => "stockholm",
                LocalizeVoiceAccent.Telangana => "telangana",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalizeVoiceAccent? ToEnum(string value)
        {
            return value switch
            {
                "australian" => LocalizeVoiceAccent.Australian,
                "brazilian-portuguese" => LocalizeVoiceAccent.BrazilianPortuguese,
                "british" => LocalizeVoiceAccent.British,
                "canadian-french" => LocalizeVoiceAccent.CanadianFrench,
                "castilian" => LocalizeVoiceAccent.Castilian,
                "central-tamil" => LocalizeVoiceAccent.CentralTamil,
                "central-thai" => LocalizeVoiceAccent.CentralThai,
                "czech" => LocalizeVoiceAccent.Czech,
                "european-portuguese" => LocalizeVoiceAccent.EuropeanPortuguese,
                "general-american" => LocalizeVoiceAccent.GeneralAmerican,
                "indian-english" => LocalizeVoiceAccent.IndianEnglish,
                "israeli" => LocalizeVoiceAccent.Israeli,
                "istanbul" => LocalizeVoiceAccent.Istanbul,
                "korean" => LocalizeVoiceAccent.Korean,
                "mandarin" => LocalizeVoiceAccent.Mandarin,
                "mexican" => LocalizeVoiceAccent.Mexican,
                "modern-standard-arabic" => LocalizeVoiceAccent.ModernStandardArabic,
                "parisian" => LocalizeVoiceAccent.Parisian,
                "polish" => LocalizeVoiceAccent.Polish,
                "randstad" => LocalizeVoiceAccent.Randstad,
                "russian" => LocalizeVoiceAccent.Russian,
                "slovak" => LocalizeVoiceAccent.Slovak,
                "southern-us" => LocalizeVoiceAccent.SouthernUs,
                "standard-german" => LocalizeVoiceAccent.StandardGerman,
                "standard-hindi" => LocalizeVoiceAccent.StandardHindi,
                "standard-italian" => LocalizeVoiceAccent.StandardItalian,
                "standard-japanese" => LocalizeVoiceAccent.StandardJapanese,
                "stockholm" => LocalizeVoiceAccent.Stockholm,
                "telangana" => LocalizeVoiceAccent.Telangana,
                _ => null,
            };
        }
    }
}