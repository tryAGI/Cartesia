
#nullable enable

namespace Cartesia.Realtime.TextToSpeech
{
    /// <summary>
    /// The transcript's language or locale. Use a base language code such as `en` or a regional locale code such as `en-GB`. `language` and `locale` accept the same values. Set one or the other, never both; setting both returns an error. The enum lists canonical codes; matching is case-insensitive, and underscore locale aliases such as `en_GB` are also accepted. See [supported codes](/build-with-cartesia/capability-guides/advanced-capabilities#which-locales-are-supported).
    /// </summary>
    public enum GenerationRequestLocale
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
    public static class GenerationRequestLocaleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationRequestLocale value)
        {
            return value switch
            {
                GenerationRequestLocale.Ar => "ar",
                GenerationRequestLocale.Bg => "bg",
                GenerationRequestLocale.BgBg => "bg-BG",
                GenerationRequestLocale.Bn => "bn",
                GenerationRequestLocale.BnIn => "bn-IN",
                GenerationRequestLocale.Cs => "cs",
                GenerationRequestLocale.CsCz => "cs-CZ",
                GenerationRequestLocale.Da => "da",
                GenerationRequestLocale.DaDk => "da-DK",
                GenerationRequestLocale.De => "de",
                GenerationRequestLocale.DeDe => "de-DE",
                GenerationRequestLocale.El => "el",
                GenerationRequestLocale.ElGr => "el-GR",
                GenerationRequestLocale.En => "en",
                GenerationRequestLocale.EnAu => "en-AU",
                GenerationRequestLocale.EnGb => "en-GB",
                GenerationRequestLocale.EnIe => "en-IE",
                GenerationRequestLocale.EnIn => "en-IN",
                GenerationRequestLocale.EnNz => "en-NZ",
                GenerationRequestLocale.EnSg => "en-SG",
                GenerationRequestLocale.EnUs => "en-US",
                GenerationRequestLocale.EnZa => "en-ZA",
                GenerationRequestLocale.Es => "es",
                GenerationRequestLocale.EsEs => "es-ES",
                GenerationRequestLocale.EsMx => "es-MX",
                GenerationRequestLocale.EsUs => "es-US",
                GenerationRequestLocale.Fi => "fi",
                GenerationRequestLocale.FiFi => "fi-FI",
                GenerationRequestLocale.Fr => "fr",
                GenerationRequestLocale.FrCa => "fr-CA",
                GenerationRequestLocale.FrFr => "fr-FR",
                GenerationRequestLocale.Gu => "gu",
                GenerationRequestLocale.GuIn => "gu-IN",
                GenerationRequestLocale.He => "he",
                GenerationRequestLocale.HeIl => "he-IL",
                GenerationRequestLocale.Hi => "hi",
                GenerationRequestLocale.HiIn => "hi-IN",
                GenerationRequestLocale.Hr => "hr",
                GenerationRequestLocale.HrHr => "hr-HR",
                GenerationRequestLocale.Hu => "hu",
                GenerationRequestLocale.HuHu => "hu-HU",
                GenerationRequestLocale.Id => "id",
                GenerationRequestLocale.IdId => "id-ID",
                GenerationRequestLocale.It => "it",
                GenerationRequestLocale.ItIt => "it-IT",
                GenerationRequestLocale.Ja => "ja",
                GenerationRequestLocale.JaJp => "ja-JP",
                GenerationRequestLocale.Ka => "ka",
                GenerationRequestLocale.KaGe => "ka-GE",
                GenerationRequestLocale.Kn => "kn",
                GenerationRequestLocale.KnIn => "kn-IN",
                GenerationRequestLocale.Ko => "ko",
                GenerationRequestLocale.KoKr => "ko-KR",
                GenerationRequestLocale.Ml => "ml",
                GenerationRequestLocale.MlIn => "ml-IN",
                GenerationRequestLocale.Mr => "mr",
                GenerationRequestLocale.MrIn => "mr-IN",
                GenerationRequestLocale.Ms => "ms",
                GenerationRequestLocale.MsMy => "ms-MY",
                GenerationRequestLocale.Nl => "nl",
                GenerationRequestLocale.NlBe => "nl-BE",
                GenerationRequestLocale.NlNl => "nl-NL",
                GenerationRequestLocale.No => "no",
                GenerationRequestLocale.NoNo => "no-NO",
                GenerationRequestLocale.Or => "or",
                GenerationRequestLocale.OrIn => "or-IN",
                GenerationRequestLocale.Pa => "pa",
                GenerationRequestLocale.PaIn => "pa-IN",
                GenerationRequestLocale.Pl => "pl",
                GenerationRequestLocale.PlPl => "pl-PL",
                GenerationRequestLocale.Pt => "pt",
                GenerationRequestLocale.PtBr => "pt-BR",
                GenerationRequestLocale.PtPt => "pt-PT",
                GenerationRequestLocale.Ro => "ro",
                GenerationRequestLocale.RoRo => "ro-RO",
                GenerationRequestLocale.Ru => "ru",
                GenerationRequestLocale.RuRu => "ru-RU",
                GenerationRequestLocale.Sk => "sk",
                GenerationRequestLocale.SkSk => "sk-SK",
                GenerationRequestLocale.Sv => "sv",
                GenerationRequestLocale.SvSe => "sv-SE",
                GenerationRequestLocale.Ta => "ta",
                GenerationRequestLocale.TaIn => "ta-IN",
                GenerationRequestLocale.Te => "te",
                GenerationRequestLocale.TeIn => "te-IN",
                GenerationRequestLocale.Th => "th",
                GenerationRequestLocale.ThTh => "th-TH",
                GenerationRequestLocale.Tl => "tl",
                GenerationRequestLocale.TlPh => "tl-PH",
                GenerationRequestLocale.Tr => "tr",
                GenerationRequestLocale.TrTr => "tr-TR",
                GenerationRequestLocale.Uk => "uk",
                GenerationRequestLocale.UkUa => "uk-UA",
                GenerationRequestLocale.Ur => "ur",
                GenerationRequestLocale.UrIn => "ur-IN",
                GenerationRequestLocale.Vi => "vi",
                GenerationRequestLocale.ViVn => "vi-VN",
                GenerationRequestLocale.Zh => "zh",
                GenerationRequestLocale.ZhCn => "zh-CN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationRequestLocale? ToEnum(string value)
        {
            return value switch
            {
                "ar" => GenerationRequestLocale.Ar,
                "bg" => GenerationRequestLocale.Bg,
                "bg-BG" => GenerationRequestLocale.BgBg,
                "bn" => GenerationRequestLocale.Bn,
                "bn-IN" => GenerationRequestLocale.BnIn,
                "cs" => GenerationRequestLocale.Cs,
                "cs-CZ" => GenerationRequestLocale.CsCz,
                "da" => GenerationRequestLocale.Da,
                "da-DK" => GenerationRequestLocale.DaDk,
                "de" => GenerationRequestLocale.De,
                "de-DE" => GenerationRequestLocale.DeDe,
                "el" => GenerationRequestLocale.El,
                "el-GR" => GenerationRequestLocale.ElGr,
                "en" => GenerationRequestLocale.En,
                "en-AU" => GenerationRequestLocale.EnAu,
                "en-GB" => GenerationRequestLocale.EnGb,
                "en-IE" => GenerationRequestLocale.EnIe,
                "en-IN" => GenerationRequestLocale.EnIn,
                "en-NZ" => GenerationRequestLocale.EnNz,
                "en-SG" => GenerationRequestLocale.EnSg,
                "en-US" => GenerationRequestLocale.EnUs,
                "en-ZA" => GenerationRequestLocale.EnZa,
                "es" => GenerationRequestLocale.Es,
                "es-ES" => GenerationRequestLocale.EsEs,
                "es-MX" => GenerationRequestLocale.EsMx,
                "es-US" => GenerationRequestLocale.EsUs,
                "fi" => GenerationRequestLocale.Fi,
                "fi-FI" => GenerationRequestLocale.FiFi,
                "fr" => GenerationRequestLocale.Fr,
                "fr-CA" => GenerationRequestLocale.FrCa,
                "fr-FR" => GenerationRequestLocale.FrFr,
                "gu" => GenerationRequestLocale.Gu,
                "gu-IN" => GenerationRequestLocale.GuIn,
                "he" => GenerationRequestLocale.He,
                "he-IL" => GenerationRequestLocale.HeIl,
                "hi" => GenerationRequestLocale.Hi,
                "hi-IN" => GenerationRequestLocale.HiIn,
                "hr" => GenerationRequestLocale.Hr,
                "hr-HR" => GenerationRequestLocale.HrHr,
                "hu" => GenerationRequestLocale.Hu,
                "hu-HU" => GenerationRequestLocale.HuHu,
                "id" => GenerationRequestLocale.Id,
                "id-ID" => GenerationRequestLocale.IdId,
                "it" => GenerationRequestLocale.It,
                "it-IT" => GenerationRequestLocale.ItIt,
                "ja" => GenerationRequestLocale.Ja,
                "ja-JP" => GenerationRequestLocale.JaJp,
                "ka" => GenerationRequestLocale.Ka,
                "ka-GE" => GenerationRequestLocale.KaGe,
                "kn" => GenerationRequestLocale.Kn,
                "kn-IN" => GenerationRequestLocale.KnIn,
                "ko" => GenerationRequestLocale.Ko,
                "ko-KR" => GenerationRequestLocale.KoKr,
                "ml" => GenerationRequestLocale.Ml,
                "ml-IN" => GenerationRequestLocale.MlIn,
                "mr" => GenerationRequestLocale.Mr,
                "mr-IN" => GenerationRequestLocale.MrIn,
                "ms" => GenerationRequestLocale.Ms,
                "ms-MY" => GenerationRequestLocale.MsMy,
                "nl" => GenerationRequestLocale.Nl,
                "nl-BE" => GenerationRequestLocale.NlBe,
                "nl-NL" => GenerationRequestLocale.NlNl,
                "no" => GenerationRequestLocale.No,
                "no-NO" => GenerationRequestLocale.NoNo,
                "or" => GenerationRequestLocale.Or,
                "or-IN" => GenerationRequestLocale.OrIn,
                "pa" => GenerationRequestLocale.Pa,
                "pa-IN" => GenerationRequestLocale.PaIn,
                "pl" => GenerationRequestLocale.Pl,
                "pl-PL" => GenerationRequestLocale.PlPl,
                "pt" => GenerationRequestLocale.Pt,
                "pt-BR" => GenerationRequestLocale.PtBr,
                "pt-PT" => GenerationRequestLocale.PtPt,
                "ro" => GenerationRequestLocale.Ro,
                "ro-RO" => GenerationRequestLocale.RoRo,
                "ru" => GenerationRequestLocale.Ru,
                "ru-RU" => GenerationRequestLocale.RuRu,
                "sk" => GenerationRequestLocale.Sk,
                "sk-SK" => GenerationRequestLocale.SkSk,
                "sv" => GenerationRequestLocale.Sv,
                "sv-SE" => GenerationRequestLocale.SvSe,
                "ta" => GenerationRequestLocale.Ta,
                "ta-IN" => GenerationRequestLocale.TaIn,
                "te" => GenerationRequestLocale.Te,
                "te-IN" => GenerationRequestLocale.TeIn,
                "th" => GenerationRequestLocale.Th,
                "th-TH" => GenerationRequestLocale.ThTh,
                "tl" => GenerationRequestLocale.Tl,
                "tl-PH" => GenerationRequestLocale.TlPh,
                "tr" => GenerationRequestLocale.Tr,
                "tr-TR" => GenerationRequestLocale.TrTr,
                "uk" => GenerationRequestLocale.Uk,
                "uk-UA" => GenerationRequestLocale.UkUa,
                "ur" => GenerationRequestLocale.Ur,
                "ur-IN" => GenerationRequestLocale.UrIn,
                "vi" => GenerationRequestLocale.Vi,
                "vi-VN" => GenerationRequestLocale.ViVn,
                "zh" => GenerationRequestLocale.Zh,
                "zh-CN" => GenerationRequestLocale.ZhCn,
                _ => null,
            };
        }
    }
}