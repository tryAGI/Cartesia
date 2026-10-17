
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
                LocalizeVoiceAccent.Bulgarian => "bulgarian",
                LocalizeVoiceAccent.CanadianFrench => "canadian-french",
                LocalizeVoiceAccent.Castilian => "castilian",
                LocalizeVoiceAccent.CentralTamil => "central-tamil",
                LocalizeVoiceAccent.CentralThai => "central-thai",
                LocalizeVoiceAccent.Czech => "czech",
                LocalizeVoiceAccent.Danish => "danish",
                LocalizeVoiceAccent.EuropeanPortuguese => "european-portuguese",
                LocalizeVoiceAccent.GeneralAmerican => "general-american",
                LocalizeVoiceAccent.IndianEnglish => "indian-english",
                LocalizeVoiceAccent.IndianUrdu => "indian-urdu",
                LocalizeVoiceAccent.Israeli => "israeli",
                LocalizeVoiceAccent.Istanbul => "istanbul",
                LocalizeVoiceAccent.Konkani => "konkani",
                LocalizeVoiceAccent.Korean => "korean",
                LocalizeVoiceAccent.Mandarin => "mandarin",
                LocalizeVoiceAccent.Manila => "manila",
                LocalizeVoiceAccent.Mexican => "mexican",
                LocalizeVoiceAccent.ModernStandardArabic => "modern-standard-arabic",
                LocalizeVoiceAccent.NorthKerala => "north-kerala",
                LocalizeVoiceAccent.Odia => "odia",
                LocalizeVoiceAccent.Oslo => "oslo",
                LocalizeVoiceAccent.Parisian => "parisian",
                LocalizeVoiceAccent.Parsi => "parsi",
                LocalizeVoiceAccent.Polish => "polish",
                LocalizeVoiceAccent.Powadhi => "powadhi",
                LocalizeVoiceAccent.Randstad => "randstad",
                LocalizeVoiceAccent.Russian => "russian",
                LocalizeVoiceAccent.Slovak => "slovak",
                LocalizeVoiceAccent.SouthernKarnataka => "southern-karnataka",
                LocalizeVoiceAccent.SouthernUs => "southern-us",
                LocalizeVoiceAccent.StandardGerman => "standard-german",
                LocalizeVoiceAccent.StandardHindi => "standard-hindi",
                LocalizeVoiceAccent.StandardIndonesian => "standard-indonesian",
                LocalizeVoiceAccent.StandardItalian => "standard-italian",
                LocalizeVoiceAccent.StandardJapanese => "standard-japanese",
                LocalizeVoiceAccent.Stockholm => "stockholm",
                LocalizeVoiceAccent.TaiwaneseMandarin => "taiwanese-mandarin",
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
                "bulgarian" => LocalizeVoiceAccent.Bulgarian,
                "canadian-french" => LocalizeVoiceAccent.CanadianFrench,
                "castilian" => LocalizeVoiceAccent.Castilian,
                "central-tamil" => LocalizeVoiceAccent.CentralTamil,
                "central-thai" => LocalizeVoiceAccent.CentralThai,
                "czech" => LocalizeVoiceAccent.Czech,
                "danish" => LocalizeVoiceAccent.Danish,
                "european-portuguese" => LocalizeVoiceAccent.EuropeanPortuguese,
                "general-american" => LocalizeVoiceAccent.GeneralAmerican,
                "indian-english" => LocalizeVoiceAccent.IndianEnglish,
                "indian-urdu" => LocalizeVoiceAccent.IndianUrdu,
                "israeli" => LocalizeVoiceAccent.Israeli,
                "istanbul" => LocalizeVoiceAccent.Istanbul,
                "konkani" => LocalizeVoiceAccent.Konkani,
                "korean" => LocalizeVoiceAccent.Korean,
                "mandarin" => LocalizeVoiceAccent.Mandarin,
                "manila" => LocalizeVoiceAccent.Manila,
                "mexican" => LocalizeVoiceAccent.Mexican,
                "modern-standard-arabic" => LocalizeVoiceAccent.ModernStandardArabic,
                "north-kerala" => LocalizeVoiceAccent.NorthKerala,
                "odia" => LocalizeVoiceAccent.Odia,
                "oslo" => LocalizeVoiceAccent.Oslo,
                "parisian" => LocalizeVoiceAccent.Parisian,
                "parsi" => LocalizeVoiceAccent.Parsi,
                "polish" => LocalizeVoiceAccent.Polish,
                "powadhi" => LocalizeVoiceAccent.Powadhi,
                "randstad" => LocalizeVoiceAccent.Randstad,
                "russian" => LocalizeVoiceAccent.Russian,
                "slovak" => LocalizeVoiceAccent.Slovak,
                "southern-karnataka" => LocalizeVoiceAccent.SouthernKarnataka,
                "southern-us" => LocalizeVoiceAccent.SouthernUs,
                "standard-german" => LocalizeVoiceAccent.StandardGerman,
                "standard-hindi" => LocalizeVoiceAccent.StandardHindi,
                "standard-indonesian" => LocalizeVoiceAccent.StandardIndonesian,
                "standard-italian" => LocalizeVoiceAccent.StandardItalian,
                "standard-japanese" => LocalizeVoiceAccent.StandardJapanese,
                "stockholm" => LocalizeVoiceAccent.Stockholm,
                "taiwanese-mandarin" => LocalizeVoiceAccent.TaiwaneseMandarin,
                "telangana" => LocalizeVoiceAccent.Telangana,
                _ => null,
            };
        }
    }
}