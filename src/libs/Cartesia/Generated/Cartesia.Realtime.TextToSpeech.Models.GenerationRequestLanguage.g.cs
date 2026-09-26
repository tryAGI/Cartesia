
#nullable enable

namespace Cartesia.Realtime.TextToSpeech
{
    /// <summary>
    /// The transcript's language or locale. Use a base language code such as `en` or a regional locale code such as `en-GB`. `language` and `locale` accept the same values. Set one or the other, never both; setting both returns an error. The enum lists canonical codes; matching is case-insensitive, and underscore locale aliases such as `en_GB` are also accepted. See [supported codes](/build-with-cartesia/capability-guides/advanced-capabilities#which-locales-are-supported).
    /// </summary>
    public enum GenerationRequestLanguage
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
        BgBg,
        /// <summary>
        ///
        /// </summary>
        Bn,
        /// <summary>
        ///
        /// </summary>
        BnIn,
        /// <summary>
        ///
        /// </summary>
        Cs,
        /// <summary>
        ///
        /// </summary>
        CsCz,
        /// <summary>
        ///
        /// </summary>
        Da,
        /// <summary>
        ///
        /// </summary>
        DaDk,
        /// <summary>
        ///
        /// </summary>
        De,
        /// <summary>
        ///
        /// </summary>
        DeDe,
        /// <summary>
        ///
        /// </summary>
        El,
        /// <summary>
        ///
        /// </summary>
        ElGr,
        /// <summary>
        ///
        /// </summary>
        En,
        /// <summary>
        ///
        /// </summary>
        EnAu,
        /// <summary>
        ///
        /// </summary>
        EnCa,
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
        ///
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
        FiFi,
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
        ///
        /// </summary>
        Gu,
        /// <summary>
        ///
        /// </summary>
        GuIn,
        /// <summary>
        ///
        /// </summary>
        He,
        /// <summary>
        ///
        /// </summary>
        HeIl,
        /// <summary>
        ///
        /// </summary>
        Hi,
        /// <summary>
        ///
        /// </summary>
        HiIn,
        /// <summary>
        ///
        /// </summary>
        Hr,
        /// <summary>
        ///
        /// </summary>
        HrHr,
        /// <summary>
        ///
        /// </summary>
        Hu,
        /// <summary>
        ///
        /// </summary>
        HuHu,
        /// <summary>
        ///
        /// </summary>
        Id,
        /// <summary>
        ///
        /// </summary>
        IdId,
        /// <summary>
        ///
        /// </summary>
        It,
        /// <summary>
        ///
        /// </summary>
        ItIt,
        /// <summary>
        ///
        /// </summary>
        Ja,
        /// <summary>
        ///
        /// </summary>
        JaJp,
        /// <summary>
        ///
        /// </summary>
        Ka,
        /// <summary>
        ///
        /// </summary>
        KaGe,
        /// <summary>
        ///
        /// </summary>
        Kn,
        /// <summary>
        ///
        /// </summary>
        KnIn,
        /// <summary>
        ///
        /// </summary>
        Ko,
        /// <summary>
        ///
        /// </summary>
        KoKr,
        /// <summary>
        ///
        /// </summary>
        Ml,
        /// <summary>
        ///
        /// </summary>
        MlIn,
        /// <summary>
        ///
        /// </summary>
        Mr,
        /// <summary>
        ///
        /// </summary>
        MrIn,
        /// <summary>
        ///
        /// </summary>
        Ms,
        /// <summary>
        ///
        /// </summary>
        MsMy,
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
        ///
        /// </summary>
        NoNo,
        /// <summary>
        ///
        /// </summary>
        Or,
        /// <summary>
        ///
        /// </summary>
        OrIn,
        /// <summary>
        ///
        /// </summary>
        Pa,
        /// <summary>
        ///
        /// </summary>
        PaIn,
        /// <summary>
        ///
        /// </summary>
        Pl,
        /// <summary>
        ///
        /// </summary>
        PlPl,
        /// <summary>
        ///
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
        RoRo,
        /// <summary>
        ///
        /// </summary>
        Ru,
        /// <summary>
        ///
        /// </summary>
        RuRu,
        /// <summary>
        ///
        /// </summary>
        Sk,
        /// <summary>
        ///
        /// </summary>
        SkSk,
        /// <summary>
        ///
        /// </summary>
        Sv,
        /// <summary>
        ///
        /// </summary>
        SvSe,
        /// <summary>
        ///
        /// </summary>
        Ta,
        /// <summary>
        ///
        /// </summary>
        TaIn,
        /// <summary>
        ///
        /// </summary>
        Te,
        /// <summary>
        ///
        /// </summary>
        TeIn,
        /// <summary>
        ///
        /// </summary>
        Th,
        /// <summary>
        ///
        /// </summary>
        ThTh,
        /// <summary>
        ///
        /// </summary>
        Tl,
        /// <summary>
        ///
        /// </summary>
        TlPh,
        /// <summary>
        ///
        /// </summary>
        Tr,
        /// <summary>
        ///
        /// </summary>
        TrTr,
        /// <summary>
        ///
        /// </summary>
        Uk,
        /// <summary>
        ///
        /// </summary>
        UkUa,
        /// <summary>
        ///
        /// </summary>
        Ur,
        /// <summary>
        ///
        /// </summary>
        UrIn,
        /// <summary>
        ///
        /// </summary>
        Vi,
        /// <summary>
        ///
        /// </summary>
        ViVn,
        /// <summary>
        ///
        /// </summary>
        Zh,
        /// <summary>
        ///
        /// </summary>
        ZhCn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationRequestLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationRequestLanguage value)
        {
            return value switch
            {
                GenerationRequestLanguage.Ar => "ar",
                GenerationRequestLanguage.Bg => "bg",
                GenerationRequestLanguage.BgBg => "bg-BG",
                GenerationRequestLanguage.Bn => "bn",
                GenerationRequestLanguage.BnIn => "bn-IN",
                GenerationRequestLanguage.Cs => "cs",
                GenerationRequestLanguage.CsCz => "cs-CZ",
                GenerationRequestLanguage.Da => "da",
                GenerationRequestLanguage.DaDk => "da-DK",
                GenerationRequestLanguage.De => "de",
                GenerationRequestLanguage.DeDe => "de-DE",
                GenerationRequestLanguage.El => "el",
                GenerationRequestLanguage.ElGr => "el-GR",
                GenerationRequestLanguage.En => "en",
                GenerationRequestLanguage.EnAu => "en-AU",
                GenerationRequestLanguage.EnCa => "en-CA",
                GenerationRequestLanguage.EnGb => "en-GB",
                GenerationRequestLanguage.EnIe => "en-IE",
                GenerationRequestLanguage.EnIn => "en-IN",
                GenerationRequestLanguage.EnNz => "en-NZ",
                GenerationRequestLanguage.EnSg => "en-SG",
                GenerationRequestLanguage.EnUs => "en-US",
                GenerationRequestLanguage.EnZa => "en-ZA",
                GenerationRequestLanguage.Es => "es",
                GenerationRequestLanguage.EsEs => "es-ES",
                GenerationRequestLanguage.EsMx => "es-MX",
                GenerationRequestLanguage.EsUs => "es-US",
                GenerationRequestLanguage.Fi => "fi",
                GenerationRequestLanguage.FiFi => "fi-FI",
                GenerationRequestLanguage.Fr => "fr",
                GenerationRequestLanguage.FrCa => "fr-CA",
                GenerationRequestLanguage.FrFr => "fr-FR",
                GenerationRequestLanguage.Gu => "gu",
                GenerationRequestLanguage.GuIn => "gu-IN",
                GenerationRequestLanguage.He => "he",
                GenerationRequestLanguage.HeIl => "he-IL",
                GenerationRequestLanguage.Hi => "hi",
                GenerationRequestLanguage.HiIn => "hi-IN",
                GenerationRequestLanguage.Hr => "hr",
                GenerationRequestLanguage.HrHr => "hr-HR",
                GenerationRequestLanguage.Hu => "hu",
                GenerationRequestLanguage.HuHu => "hu-HU",
                GenerationRequestLanguage.Id => "id",
                GenerationRequestLanguage.IdId => "id-ID",
                GenerationRequestLanguage.It => "it",
                GenerationRequestLanguage.ItIt => "it-IT",
                GenerationRequestLanguage.Ja => "ja",
                GenerationRequestLanguage.JaJp => "ja-JP",
                GenerationRequestLanguage.Ka => "ka",
                GenerationRequestLanguage.KaGe => "ka-GE",
                GenerationRequestLanguage.Kn => "kn",
                GenerationRequestLanguage.KnIn => "kn-IN",
                GenerationRequestLanguage.Ko => "ko",
                GenerationRequestLanguage.KoKr => "ko-KR",
                GenerationRequestLanguage.Ml => "ml",
                GenerationRequestLanguage.MlIn => "ml-IN",
                GenerationRequestLanguage.Mr => "mr",
                GenerationRequestLanguage.MrIn => "mr-IN",
                GenerationRequestLanguage.Ms => "ms",
                GenerationRequestLanguage.MsMy => "ms-MY",
                GenerationRequestLanguage.Nl => "nl",
                GenerationRequestLanguage.NlBe => "nl-BE",
                GenerationRequestLanguage.NlNl => "nl-NL",
                GenerationRequestLanguage.No => "no",
                GenerationRequestLanguage.NoNo => "no-NO",
                GenerationRequestLanguage.Or => "or",
                GenerationRequestLanguage.OrIn => "or-IN",
                GenerationRequestLanguage.Pa => "pa",
                GenerationRequestLanguage.PaIn => "pa-IN",
                GenerationRequestLanguage.Pl => "pl",
                GenerationRequestLanguage.PlPl => "pl-PL",
                GenerationRequestLanguage.Pt => "pt",
                GenerationRequestLanguage.PtBr => "pt-BR",
                GenerationRequestLanguage.PtPt => "pt-PT",
                GenerationRequestLanguage.Ro => "ro",
                GenerationRequestLanguage.RoRo => "ro-RO",
                GenerationRequestLanguage.Ru => "ru",
                GenerationRequestLanguage.RuRu => "ru-RU",
                GenerationRequestLanguage.Sk => "sk",
                GenerationRequestLanguage.SkSk => "sk-SK",
                GenerationRequestLanguage.Sv => "sv",
                GenerationRequestLanguage.SvSe => "sv-SE",
                GenerationRequestLanguage.Ta => "ta",
                GenerationRequestLanguage.TaIn => "ta-IN",
                GenerationRequestLanguage.Te => "te",
                GenerationRequestLanguage.TeIn => "te-IN",
                GenerationRequestLanguage.Th => "th",
                GenerationRequestLanguage.ThTh => "th-TH",
                GenerationRequestLanguage.Tl => "tl",
                GenerationRequestLanguage.TlPh => "tl-PH",
                GenerationRequestLanguage.Tr => "tr",
                GenerationRequestLanguage.TrTr => "tr-TR",
                GenerationRequestLanguage.Uk => "uk",
                GenerationRequestLanguage.UkUa => "uk-UA",
                GenerationRequestLanguage.Ur => "ur",
                GenerationRequestLanguage.UrIn => "ur-IN",
                GenerationRequestLanguage.Vi => "vi",
                GenerationRequestLanguage.ViVn => "vi-VN",
                GenerationRequestLanguage.Zh => "zh",
                GenerationRequestLanguage.ZhCn => "zh-CN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationRequestLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => GenerationRequestLanguage.Ar,
                "bg" => GenerationRequestLanguage.Bg,
                "bg-BG" => GenerationRequestLanguage.BgBg,
                "bn" => GenerationRequestLanguage.Bn,
                "bn-IN" => GenerationRequestLanguage.BnIn,
                "cs" => GenerationRequestLanguage.Cs,
                "cs-CZ" => GenerationRequestLanguage.CsCz,
                "da" => GenerationRequestLanguage.Da,
                "da-DK" => GenerationRequestLanguage.DaDk,
                "de" => GenerationRequestLanguage.De,
                "de-DE" => GenerationRequestLanguage.DeDe,
                "el" => GenerationRequestLanguage.El,
                "el-GR" => GenerationRequestLanguage.ElGr,
                "en" => GenerationRequestLanguage.En,
                "en-AU" => GenerationRequestLanguage.EnAu,
                "en-CA" => GenerationRequestLanguage.EnCa,
                "en-GB" => GenerationRequestLanguage.EnGb,
                "en-IE" => GenerationRequestLanguage.EnIe,
                "en-IN" => GenerationRequestLanguage.EnIn,
                "en-NZ" => GenerationRequestLanguage.EnNz,
                "en-SG" => GenerationRequestLanguage.EnSg,
                "en-US" => GenerationRequestLanguage.EnUs,
                "en-ZA" => GenerationRequestLanguage.EnZa,
                "es" => GenerationRequestLanguage.Es,
                "es-ES" => GenerationRequestLanguage.EsEs,
                "es-MX" => GenerationRequestLanguage.EsMx,
                "es-US" => GenerationRequestLanguage.EsUs,
                "fi" => GenerationRequestLanguage.Fi,
                "fi-FI" => GenerationRequestLanguage.FiFi,
                "fr" => GenerationRequestLanguage.Fr,
                "fr-CA" => GenerationRequestLanguage.FrCa,
                "fr-FR" => GenerationRequestLanguage.FrFr,
                "gu" => GenerationRequestLanguage.Gu,
                "gu-IN" => GenerationRequestLanguage.GuIn,
                "he" => GenerationRequestLanguage.He,
                "he-IL" => GenerationRequestLanguage.HeIl,
                "hi" => GenerationRequestLanguage.Hi,
                "hi-IN" => GenerationRequestLanguage.HiIn,
                "hr" => GenerationRequestLanguage.Hr,
                "hr-HR" => GenerationRequestLanguage.HrHr,
                "hu" => GenerationRequestLanguage.Hu,
                "hu-HU" => GenerationRequestLanguage.HuHu,
                "id" => GenerationRequestLanguage.Id,
                "id-ID" => GenerationRequestLanguage.IdId,
                "it" => GenerationRequestLanguage.It,
                "it-IT" => GenerationRequestLanguage.ItIt,
                "ja" => GenerationRequestLanguage.Ja,
                "ja-JP" => GenerationRequestLanguage.JaJp,
                "ka" => GenerationRequestLanguage.Ka,
                "ka-GE" => GenerationRequestLanguage.KaGe,
                "kn" => GenerationRequestLanguage.Kn,
                "kn-IN" => GenerationRequestLanguage.KnIn,
                "ko" => GenerationRequestLanguage.Ko,
                "ko-KR" => GenerationRequestLanguage.KoKr,
                "ml" => GenerationRequestLanguage.Ml,
                "ml-IN" => GenerationRequestLanguage.MlIn,
                "mr" => GenerationRequestLanguage.Mr,
                "mr-IN" => GenerationRequestLanguage.MrIn,
                "ms" => GenerationRequestLanguage.Ms,
                "ms-MY" => GenerationRequestLanguage.MsMy,
                "nl" => GenerationRequestLanguage.Nl,
                "nl-BE" => GenerationRequestLanguage.NlBe,
                "nl-NL" => GenerationRequestLanguage.NlNl,
                "no" => GenerationRequestLanguage.No,
                "no-NO" => GenerationRequestLanguage.NoNo,
                "or" => GenerationRequestLanguage.Or,
                "or-IN" => GenerationRequestLanguage.OrIn,
                "pa" => GenerationRequestLanguage.Pa,
                "pa-IN" => GenerationRequestLanguage.PaIn,
                "pl" => GenerationRequestLanguage.Pl,
                "pl-PL" => GenerationRequestLanguage.PlPl,
                "pt" => GenerationRequestLanguage.Pt,
                "pt-BR" => GenerationRequestLanguage.PtBr,
                "pt-PT" => GenerationRequestLanguage.PtPt,
                "ro" => GenerationRequestLanguage.Ro,
                "ro-RO" => GenerationRequestLanguage.RoRo,
                "ru" => GenerationRequestLanguage.Ru,
                "ru-RU" => GenerationRequestLanguage.RuRu,
                "sk" => GenerationRequestLanguage.Sk,
                "sk-SK" => GenerationRequestLanguage.SkSk,
                "sv" => GenerationRequestLanguage.Sv,
                "sv-SE" => GenerationRequestLanguage.SvSe,
                "ta" => GenerationRequestLanguage.Ta,
                "ta-IN" => GenerationRequestLanguage.TaIn,
                "te" => GenerationRequestLanguage.Te,
                "te-IN" => GenerationRequestLanguage.TeIn,
                "th" => GenerationRequestLanguage.Th,
                "th-TH" => GenerationRequestLanguage.ThTh,
                "tl" => GenerationRequestLanguage.Tl,
                "tl-PH" => GenerationRequestLanguage.TlPh,
                "tr" => GenerationRequestLanguage.Tr,
                "tr-TR" => GenerationRequestLanguage.TrTr,
                "uk" => GenerationRequestLanguage.Uk,
                "uk-UA" => GenerationRequestLanguage.UkUa,
                "ur" => GenerationRequestLanguage.Ur,
                "ur-IN" => GenerationRequestLanguage.UrIn,
                "vi" => GenerationRequestLanguage.Vi,
                "vi-VN" => GenerationRequestLanguage.ViVn,
                "zh" => GenerationRequestLanguage.Zh,
                "zh-CN" => GenerationRequestLanguage.ZhCn,
                _ => null,
            };
        }
    }
}