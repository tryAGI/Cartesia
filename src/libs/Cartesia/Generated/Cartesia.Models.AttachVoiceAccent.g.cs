
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
        Bulgarian,
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
        Danish,
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
        IndianUrdu,
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
        Konkani,
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
        Manila,
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
        NorthKerala,
        /// <summary>
        ///
        /// </summary>
        Odia,
        /// <summary>
        ///
        /// </summary>
        Oslo,
        /// <summary>
        ///
        /// </summary>
        Parisian,
        /// <summary>
        ///
        /// </summary>
        Parsi,
        /// <summary>
        ///
        /// </summary>
        Polish,
        /// <summary>
        ///
        /// </summary>
        Powadhi,
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
        SouthernKarnataka,
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
        StandardIndonesian,
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
        TaiwaneseMandarin,
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
                AttachVoiceAccent.Bulgarian => "bulgarian",
                AttachVoiceAccent.CanadianFrench => "canadian-french",
                AttachVoiceAccent.Castilian => "castilian",
                AttachVoiceAccent.CentralTamil => "central-tamil",
                AttachVoiceAccent.CentralThai => "central-thai",
                AttachVoiceAccent.Czech => "czech",
                AttachVoiceAccent.Danish => "danish",
                AttachVoiceAccent.EuropeanPortuguese => "european-portuguese",
                AttachVoiceAccent.GeneralAmerican => "general-american",
                AttachVoiceAccent.IndianEnglish => "indian-english",
                AttachVoiceAccent.IndianUrdu => "indian-urdu",
                AttachVoiceAccent.Israeli => "israeli",
                AttachVoiceAccent.Istanbul => "istanbul",
                AttachVoiceAccent.Konkani => "konkani",
                AttachVoiceAccent.Korean => "korean",
                AttachVoiceAccent.Mandarin => "mandarin",
                AttachVoiceAccent.Manila => "manila",
                AttachVoiceAccent.Mexican => "mexican",
                AttachVoiceAccent.ModernStandardArabic => "modern-standard-arabic",
                AttachVoiceAccent.NorthKerala => "north-kerala",
                AttachVoiceAccent.Odia => "odia",
                AttachVoiceAccent.Oslo => "oslo",
                AttachVoiceAccent.Parisian => "parisian",
                AttachVoiceAccent.Parsi => "parsi",
                AttachVoiceAccent.Polish => "polish",
                AttachVoiceAccent.Powadhi => "powadhi",
                AttachVoiceAccent.Randstad => "randstad",
                AttachVoiceAccent.Russian => "russian",
                AttachVoiceAccent.Slovak => "slovak",
                AttachVoiceAccent.SouthernKarnataka => "southern-karnataka",
                AttachVoiceAccent.SouthernUs => "southern-us",
                AttachVoiceAccent.StandardGerman => "standard-german",
                AttachVoiceAccent.StandardHindi => "standard-hindi",
                AttachVoiceAccent.StandardIndonesian => "standard-indonesian",
                AttachVoiceAccent.StandardItalian => "standard-italian",
                AttachVoiceAccent.StandardJapanese => "standard-japanese",
                AttachVoiceAccent.Stockholm => "stockholm",
                AttachVoiceAccent.TaiwaneseMandarin => "taiwanese-mandarin",
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
                "bulgarian" => AttachVoiceAccent.Bulgarian,
                "canadian-french" => AttachVoiceAccent.CanadianFrench,
                "castilian" => AttachVoiceAccent.Castilian,
                "central-tamil" => AttachVoiceAccent.CentralTamil,
                "central-thai" => AttachVoiceAccent.CentralThai,
                "czech" => AttachVoiceAccent.Czech,
                "danish" => AttachVoiceAccent.Danish,
                "european-portuguese" => AttachVoiceAccent.EuropeanPortuguese,
                "general-american" => AttachVoiceAccent.GeneralAmerican,
                "indian-english" => AttachVoiceAccent.IndianEnglish,
                "indian-urdu" => AttachVoiceAccent.IndianUrdu,
                "israeli" => AttachVoiceAccent.Israeli,
                "istanbul" => AttachVoiceAccent.Istanbul,
                "konkani" => AttachVoiceAccent.Konkani,
                "korean" => AttachVoiceAccent.Korean,
                "mandarin" => AttachVoiceAccent.Mandarin,
                "manila" => AttachVoiceAccent.Manila,
                "mexican" => AttachVoiceAccent.Mexican,
                "modern-standard-arabic" => AttachVoiceAccent.ModernStandardArabic,
                "north-kerala" => AttachVoiceAccent.NorthKerala,
                "odia" => AttachVoiceAccent.Odia,
                "oslo" => AttachVoiceAccent.Oslo,
                "parisian" => AttachVoiceAccent.Parisian,
                "parsi" => AttachVoiceAccent.Parsi,
                "polish" => AttachVoiceAccent.Polish,
                "powadhi" => AttachVoiceAccent.Powadhi,
                "randstad" => AttachVoiceAccent.Randstad,
                "russian" => AttachVoiceAccent.Russian,
                "slovak" => AttachVoiceAccent.Slovak,
                "southern-karnataka" => AttachVoiceAccent.SouthernKarnataka,
                "southern-us" => AttachVoiceAccent.SouthernUs,
                "standard-german" => AttachVoiceAccent.StandardGerman,
                "standard-hindi" => AttachVoiceAccent.StandardHindi,
                "standard-indonesian" => AttachVoiceAccent.StandardIndonesian,
                "standard-italian" => AttachVoiceAccent.StandardItalian,
                "standard-japanese" => AttachVoiceAccent.StandardJapanese,
                "stockholm" => AttachVoiceAccent.Stockholm,
                "taiwanese-mandarin" => AttachVoiceAccent.TaiwaneseMandarin,
                "telangana" => AttachVoiceAccent.Telangana,
                _ => null,
            };
        }
    }
}