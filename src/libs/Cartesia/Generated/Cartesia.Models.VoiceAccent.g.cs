
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Accent id from GET /accents, valid for the selected language.
    /// </summary>
    public enum VoiceAccent
    {
        /// <summary>
        ///
        /// </summary>
        AbruzzoItalian,
        /// <summary>
        ///
        /// </summary>
        AfricanAmerican,
        /// <summary>
        ///
        /// </summary>
        AfricanFrench,
        /// <summary>
        ///
        /// </summary>
        ArabicEnglish,
        /// <summary>
        ///
        /// </summary>
        Australian,
        /// <summary>
        ///
        /// </summary>
        Bagheli,
        /// <summary>
        ///
        /// </summary>
        BelgianFrench,
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
        Budapest,
        /// <summary>
        ///
        /// </summary>
        Bulgarian,
        /// <summary>
        ///
        /// </summary>
        California,
        /// <summary>
        ///
        /// </summary>
        Camba,
        /// <summary>
        ///
        /// </summary>
        Campania,
        /// <summary>
        ///
        /// </summary>
        CanadianEnglish,
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
        CentralVietnamese,
        /// <summary>
        ///
        /// </summary>
        Chilean,
        /// <summary>
        ///
        /// </summary>
        Colombian,
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
        Finnish,
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
        Irish,
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
        Jessore,
        /// <summary>
        ///
        /// </summary>
        Khaleeji,
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
        Kyiv,
        /// <summary>
        ///
        /// </summary>
        Malay,
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
        MiddleEasternArabic,
        /// <summary>
        ///
        /// </summary>
        MidwesternAmerican,
        /// <summary>
        ///
        /// </summary>
        ModernStandardArabic,
        /// <summary>
        ///
        /// </summary>
        Moldovan,
        /// <summary>
        ///
        /// </summary>
        NewYork,
        /// <summary>
        ///
        /// </summary>
        NewZealand,
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
        Peruvian,
        /// <summary>
        ///
        /// </summary>
        PhilippineEnglish,
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
        Romanian,
        /// <summary>
        ///
        /// </summary>
        Russian,
        /// <summary>
        ///
        /// </summary>
        Singaporean,
        /// <summary>
        ///
        /// </summary>
        Slovak,
        /// <summary>
        ///
        /// </summary>
        SouthAfrican,
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
        SouthernVietnamese,
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
        SwissStandard,
        /// <summary>
        ///
        /// </summary>
        TaiwaneseMandarin,
        /// <summary>
        ///
        /// </summary>
        Tbilisi,
        /// <summary>
        ///
        /// </summary>
        Telangana,
        /// <summary>
        ///
        /// </summary>
        Thessaloniki,
        /// <summary>
        ///
        /// </summary>
        Urdu,
        /// <summary>
        ///
        /// </summary>
        Zagreb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceAccentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceAccent value)
        {
            return value switch
            {
                VoiceAccent.AbruzzoItalian => "abruzzo-italian",
                VoiceAccent.AfricanAmerican => "african-american",
                VoiceAccent.AfricanFrench => "african-french",
                VoiceAccent.ArabicEnglish => "arabic-english",
                VoiceAccent.Australian => "australian",
                VoiceAccent.Bagheli => "bagheli",
                VoiceAccent.BelgianFrench => "belgian-french",
                VoiceAccent.BrazilianPortuguese => "brazilian-portuguese",
                VoiceAccent.British => "british",
                VoiceAccent.Budapest => "budapest",
                VoiceAccent.Bulgarian => "bulgarian",
                VoiceAccent.California => "california",
                VoiceAccent.Camba => "camba",
                VoiceAccent.Campania => "campania",
                VoiceAccent.CanadianEnglish => "canadian-english",
                VoiceAccent.CanadianFrench => "canadian-french",
                VoiceAccent.Castilian => "castilian",
                VoiceAccent.CentralTamil => "central-tamil",
                VoiceAccent.CentralThai => "central-thai",
                VoiceAccent.CentralVietnamese => "central-vietnamese",
                VoiceAccent.Chilean => "chilean",
                VoiceAccent.Colombian => "colombian",
                VoiceAccent.Czech => "czech",
                VoiceAccent.Danish => "danish",
                VoiceAccent.EuropeanPortuguese => "european-portuguese",
                VoiceAccent.Finnish => "finnish",
                VoiceAccent.GeneralAmerican => "general-american",
                VoiceAccent.IndianEnglish => "indian-english",
                VoiceAccent.IndianUrdu => "indian-urdu",
                VoiceAccent.Irish => "irish",
                VoiceAccent.Israeli => "israeli",
                VoiceAccent.Istanbul => "istanbul",
                VoiceAccent.Jessore => "jessore",
                VoiceAccent.Khaleeji => "khaleeji",
                VoiceAccent.Konkani => "konkani",
                VoiceAccent.Korean => "korean",
                VoiceAccent.Kyiv => "kyiv",
                VoiceAccent.Malay => "malay",
                VoiceAccent.Mandarin => "mandarin",
                VoiceAccent.Manila => "manila",
                VoiceAccent.Mexican => "mexican",
                VoiceAccent.MiddleEasternArabic => "middle-eastern-arabic",
                VoiceAccent.MidwesternAmerican => "midwestern-american",
                VoiceAccent.ModernStandardArabic => "modern-standard-arabic",
                VoiceAccent.Moldovan => "moldovan",
                VoiceAccent.NewYork => "new-york",
                VoiceAccent.NewZealand => "new-zealand",
                VoiceAccent.NorthKerala => "north-kerala",
                VoiceAccent.Odia => "odia",
                VoiceAccent.Oslo => "oslo",
                VoiceAccent.Parisian => "parisian",
                VoiceAccent.Parsi => "parsi",
                VoiceAccent.Peruvian => "peruvian",
                VoiceAccent.PhilippineEnglish => "philippine-english",
                VoiceAccent.Polish => "polish",
                VoiceAccent.Powadhi => "powadhi",
                VoiceAccent.Randstad => "randstad",
                VoiceAccent.Romanian => "romanian",
                VoiceAccent.Russian => "russian",
                VoiceAccent.Singaporean => "singaporean",
                VoiceAccent.Slovak => "slovak",
                VoiceAccent.SouthAfrican => "south-african",
                VoiceAccent.SouthernKarnataka => "southern-karnataka",
                VoiceAccent.SouthernUs => "southern-us",
                VoiceAccent.SouthernVietnamese => "southern-vietnamese",
                VoiceAccent.StandardGerman => "standard-german",
                VoiceAccent.StandardHindi => "standard-hindi",
                VoiceAccent.StandardIndonesian => "standard-indonesian",
                VoiceAccent.StandardItalian => "standard-italian",
                VoiceAccent.StandardJapanese => "standard-japanese",
                VoiceAccent.Stockholm => "stockholm",
                VoiceAccent.SwissStandard => "swiss-standard",
                VoiceAccent.TaiwaneseMandarin => "taiwanese-mandarin",
                VoiceAccent.Tbilisi => "tbilisi",
                VoiceAccent.Telangana => "telangana",
                VoiceAccent.Thessaloniki => "thessaloniki",
                VoiceAccent.Urdu => "urdu",
                VoiceAccent.Zagreb => "zagreb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceAccent? ToEnum(string value)
        {
            return value switch
            {
                "abruzzo-italian" => VoiceAccent.AbruzzoItalian,
                "african-american" => VoiceAccent.AfricanAmerican,
                "african-french" => VoiceAccent.AfricanFrench,
                "arabic-english" => VoiceAccent.ArabicEnglish,
                "australian" => VoiceAccent.Australian,
                "bagheli" => VoiceAccent.Bagheli,
                "belgian-french" => VoiceAccent.BelgianFrench,
                "brazilian-portuguese" => VoiceAccent.BrazilianPortuguese,
                "british" => VoiceAccent.British,
                "budapest" => VoiceAccent.Budapest,
                "bulgarian" => VoiceAccent.Bulgarian,
                "california" => VoiceAccent.California,
                "camba" => VoiceAccent.Camba,
                "campania" => VoiceAccent.Campania,
                "canadian-english" => VoiceAccent.CanadianEnglish,
                "canadian-french" => VoiceAccent.CanadianFrench,
                "castilian" => VoiceAccent.Castilian,
                "central-tamil" => VoiceAccent.CentralTamil,
                "central-thai" => VoiceAccent.CentralThai,
                "central-vietnamese" => VoiceAccent.CentralVietnamese,
                "chilean" => VoiceAccent.Chilean,
                "colombian" => VoiceAccent.Colombian,
                "czech" => VoiceAccent.Czech,
                "danish" => VoiceAccent.Danish,
                "european-portuguese" => VoiceAccent.EuropeanPortuguese,
                "finnish" => VoiceAccent.Finnish,
                "general-american" => VoiceAccent.GeneralAmerican,
                "indian-english" => VoiceAccent.IndianEnglish,
                "indian-urdu" => VoiceAccent.IndianUrdu,
                "irish" => VoiceAccent.Irish,
                "israeli" => VoiceAccent.Israeli,
                "istanbul" => VoiceAccent.Istanbul,
                "jessore" => VoiceAccent.Jessore,
                "khaleeji" => VoiceAccent.Khaleeji,
                "konkani" => VoiceAccent.Konkani,
                "korean" => VoiceAccent.Korean,
                "kyiv" => VoiceAccent.Kyiv,
                "malay" => VoiceAccent.Malay,
                "mandarin" => VoiceAccent.Mandarin,
                "manila" => VoiceAccent.Manila,
                "mexican" => VoiceAccent.Mexican,
                "middle-eastern-arabic" => VoiceAccent.MiddleEasternArabic,
                "midwestern-american" => VoiceAccent.MidwesternAmerican,
                "modern-standard-arabic" => VoiceAccent.ModernStandardArabic,
                "moldovan" => VoiceAccent.Moldovan,
                "new-york" => VoiceAccent.NewYork,
                "new-zealand" => VoiceAccent.NewZealand,
                "north-kerala" => VoiceAccent.NorthKerala,
                "odia" => VoiceAccent.Odia,
                "oslo" => VoiceAccent.Oslo,
                "parisian" => VoiceAccent.Parisian,
                "parsi" => VoiceAccent.Parsi,
                "peruvian" => VoiceAccent.Peruvian,
                "philippine-english" => VoiceAccent.PhilippineEnglish,
                "polish" => VoiceAccent.Polish,
                "powadhi" => VoiceAccent.Powadhi,
                "randstad" => VoiceAccent.Randstad,
                "romanian" => VoiceAccent.Romanian,
                "russian" => VoiceAccent.Russian,
                "singaporean" => VoiceAccent.Singaporean,
                "slovak" => VoiceAccent.Slovak,
                "south-african" => VoiceAccent.SouthAfrican,
                "southern-karnataka" => VoiceAccent.SouthernKarnataka,
                "southern-us" => VoiceAccent.SouthernUs,
                "southern-vietnamese" => VoiceAccent.SouthernVietnamese,
                "standard-german" => VoiceAccent.StandardGerman,
                "standard-hindi" => VoiceAccent.StandardHindi,
                "standard-indonesian" => VoiceAccent.StandardIndonesian,
                "standard-italian" => VoiceAccent.StandardItalian,
                "standard-japanese" => VoiceAccent.StandardJapanese,
                "stockholm" => VoiceAccent.Stockholm,
                "swiss-standard" => VoiceAccent.SwissStandard,
                "taiwanese-mandarin" => VoiceAccent.TaiwaneseMandarin,
                "tbilisi" => VoiceAccent.Tbilisi,
                "telangana" => VoiceAccent.Telangana,
                "thessaloniki" => VoiceAccent.Thessaloniki,
                "urdu" => VoiceAccent.Urdu,
                "zagreb" => VoiceAccent.Zagreb,
                _ => null,
            };
        }
    }
}