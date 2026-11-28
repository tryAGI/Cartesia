
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Example: en-IN
    /// </summary>
    public enum ManagedAgentNormalization
    {
        /// <summary>
        ///
        /// </summary>
        ArAe,
        /// <summary>
        ///
        /// </summary>
        ArEg,
        /// <summary>
        ///
        /// </summary>
        ArSa,
        /// <summary>
        ///
        /// </summary>
        BgBg,
        /// <summary>
        ///
        /// </summary>
        BnIn,
        /// <summary>
        ///
        /// </summary>
        CsCz,
        /// <summary>
        ///
        /// </summary>
        DaDk,
        /// <summary>
        ///
        /// </summary>
        DeAt,
        /// <summary>
        ///
        /// </summary>
        DeCh,
        /// <summary>
        ///
        /// </summary>
        DeDe,
        /// <summary>
        ///
        /// </summary>
        ElGr,
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
        EsAr,
        /// <summary>
        ///
        /// </summary>
        EsBo,
        /// <summary>
        ///
        /// </summary>
        EsCl,
        /// <summary>
        ///
        /// </summary>
        EsCo,
        /// <summary>
        ///
        /// </summary>
        EsDo,
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
        EsPa,
        /// <summary>
        ///
        /// </summary>
        EsPe,
        /// <summary>
        ///
        /// </summary>
        EsPr,
        /// <summary>
        ///
        /// </summary>
        EsUs,
        /// <summary>
        ///
        /// </summary>
        FiFi,
        /// <summary>
        ///
        /// </summary>
        FrBe,
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
        GuIn,
        /// <summary>
        ///
        /// </summary>
        HeIl,
        /// <summary>
        ///
        /// </summary>
        HiIn,
        /// <summary>
        ///
        /// </summary>
        HuHu,
        /// <summary>
        ///
        /// </summary>
        IdId,
        /// <summary>
        ///
        /// </summary>
        ItIt,
        /// <summary>
        ///
        /// </summary>
        JaJp,
        /// <summary>
        ///
        /// </summary>
        KaGe,
        /// <summary>
        ///
        /// </summary>
        KnIn,
        /// <summary>
        ///
        /// </summary>
        KoKr,
        /// <summary>
        ///
        /// </summary>
        MlIn,
        /// <summary>
        ///
        /// </summary>
        MrIn,
        /// <summary>
        ///
        /// </summary>
        MsMy,
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
        NoNo,
        /// <summary>
        ///
        /// </summary>
        OrIn,
        /// <summary>
        ///
        /// </summary>
        PaIn,
        /// <summary>
        ///
        /// </summary>
        PlPl,
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
        RoRo,
        /// <summary>
        ///
        /// </summary>
        RuRu,
        /// <summary>
        ///
        /// </summary>
        SkSk,
        /// <summary>
        ///
        /// </summary>
        SvSe,
        /// <summary>
        ///
        /// </summary>
        TaIn,
        /// <summary>
        ///
        /// </summary>
        TeIn,
        /// <summary>
        ///
        /// </summary>
        ThTh,
        /// <summary>
        ///
        /// </summary>
        TlPh,
        /// <summary>
        ///
        /// </summary>
        TrTr,
        /// <summary>
        ///
        /// </summary>
        UkUa,
        /// <summary>
        ///
        /// </summary>
        UrIn,
        /// <summary>
        ///
        /// </summary>
        ViVn,
        /// <summary>
        ///
        /// </summary>
        ZhCn,
        /// <summary>
        ///
        /// </summary>
        ZhTw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManagedAgentNormalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedAgentNormalization value)
        {
            return value switch
            {
                ManagedAgentNormalization.ArAe => "ar-AE",
                ManagedAgentNormalization.ArEg => "ar-EG",
                ManagedAgentNormalization.ArSa => "ar-SA",
                ManagedAgentNormalization.BgBg => "bg-BG",
                ManagedAgentNormalization.BnIn => "bn-IN",
                ManagedAgentNormalization.CsCz => "cs-CZ",
                ManagedAgentNormalization.DaDk => "da-DK",
                ManagedAgentNormalization.DeAt => "de-AT",
                ManagedAgentNormalization.DeCh => "de-CH",
                ManagedAgentNormalization.DeDe => "de-DE",
                ManagedAgentNormalization.ElGr => "el-GR",
                ManagedAgentNormalization.EnAu => "en-AU",
                ManagedAgentNormalization.EnCa => "en-CA",
                ManagedAgentNormalization.EnGb => "en-GB",
                ManagedAgentNormalization.EnIe => "en-IE",
                ManagedAgentNormalization.EnIn => "en-IN",
                ManagedAgentNormalization.EnNz => "en-NZ",
                ManagedAgentNormalization.EnSg => "en-SG",
                ManagedAgentNormalization.EnUs => "en-US",
                ManagedAgentNormalization.EnZa => "en-ZA",
                ManagedAgentNormalization.EsAr => "es-AR",
                ManagedAgentNormalization.EsBo => "es-BO",
                ManagedAgentNormalization.EsCl => "es-CL",
                ManagedAgentNormalization.EsCo => "es-CO",
                ManagedAgentNormalization.EsDo => "es-DO",
                ManagedAgentNormalization.EsEs => "es-ES",
                ManagedAgentNormalization.EsMx => "es-MX",
                ManagedAgentNormalization.EsPa => "es-PA",
                ManagedAgentNormalization.EsPe => "es-PE",
                ManagedAgentNormalization.EsPr => "es-PR",
                ManagedAgentNormalization.EsUs => "es-US",
                ManagedAgentNormalization.FiFi => "fi-FI",
                ManagedAgentNormalization.FrBe => "fr-BE",
                ManagedAgentNormalization.FrCa => "fr-CA",
                ManagedAgentNormalization.FrFr => "fr-FR",
                ManagedAgentNormalization.GuIn => "gu-IN",
                ManagedAgentNormalization.HeIl => "he-IL",
                ManagedAgentNormalization.HiIn => "hi-IN",
                ManagedAgentNormalization.HuHu => "hu-HU",
                ManagedAgentNormalization.IdId => "id-ID",
                ManagedAgentNormalization.ItIt => "it-IT",
                ManagedAgentNormalization.JaJp => "ja-JP",
                ManagedAgentNormalization.KaGe => "ka-GE",
                ManagedAgentNormalization.KnIn => "kn-IN",
                ManagedAgentNormalization.KoKr => "ko-KR",
                ManagedAgentNormalization.MlIn => "ml-IN",
                ManagedAgentNormalization.MrIn => "mr-IN",
                ManagedAgentNormalization.MsMy => "ms-MY",
                ManagedAgentNormalization.NlBe => "nl-BE",
                ManagedAgentNormalization.NlNl => "nl-NL",
                ManagedAgentNormalization.NoNo => "no-NO",
                ManagedAgentNormalization.OrIn => "or-IN",
                ManagedAgentNormalization.PaIn => "pa-IN",
                ManagedAgentNormalization.PlPl => "pl-PL",
                ManagedAgentNormalization.PtBr => "pt-BR",
                ManagedAgentNormalization.PtPt => "pt-PT",
                ManagedAgentNormalization.RoRo => "ro-RO",
                ManagedAgentNormalization.RuRu => "ru-RU",
                ManagedAgentNormalization.SkSk => "sk-SK",
                ManagedAgentNormalization.SvSe => "sv-SE",
                ManagedAgentNormalization.TaIn => "ta-IN",
                ManagedAgentNormalization.TeIn => "te-IN",
                ManagedAgentNormalization.ThTh => "th-TH",
                ManagedAgentNormalization.TlPh => "tl-PH",
                ManagedAgentNormalization.TrTr => "tr-TR",
                ManagedAgentNormalization.UkUa => "uk-UA",
                ManagedAgentNormalization.UrIn => "ur-IN",
                ManagedAgentNormalization.ViVn => "vi-VN",
                ManagedAgentNormalization.ZhCn => "zh-CN",
                ManagedAgentNormalization.ZhTw => "zh-TW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedAgentNormalization? ToEnum(string value)
        {
            return value switch
            {
                "ar-AE" => ManagedAgentNormalization.ArAe,
                "ar-EG" => ManagedAgentNormalization.ArEg,
                "ar-SA" => ManagedAgentNormalization.ArSa,
                "bg-BG" => ManagedAgentNormalization.BgBg,
                "bn-IN" => ManagedAgentNormalization.BnIn,
                "cs-CZ" => ManagedAgentNormalization.CsCz,
                "da-DK" => ManagedAgentNormalization.DaDk,
                "de-AT" => ManagedAgentNormalization.DeAt,
                "de-CH" => ManagedAgentNormalization.DeCh,
                "de-DE" => ManagedAgentNormalization.DeDe,
                "el-GR" => ManagedAgentNormalization.ElGr,
                "en-AU" => ManagedAgentNormalization.EnAu,
                "en-CA" => ManagedAgentNormalization.EnCa,
                "en-GB" => ManagedAgentNormalization.EnGb,
                "en-IE" => ManagedAgentNormalization.EnIe,
                "en-IN" => ManagedAgentNormalization.EnIn,
                "en-NZ" => ManagedAgentNormalization.EnNz,
                "en-SG" => ManagedAgentNormalization.EnSg,
                "en-US" => ManagedAgentNormalization.EnUs,
                "en-ZA" => ManagedAgentNormalization.EnZa,
                "es-AR" => ManagedAgentNormalization.EsAr,
                "es-BO" => ManagedAgentNormalization.EsBo,
                "es-CL" => ManagedAgentNormalization.EsCl,
                "es-CO" => ManagedAgentNormalization.EsCo,
                "es-DO" => ManagedAgentNormalization.EsDo,
                "es-ES" => ManagedAgentNormalization.EsEs,
                "es-MX" => ManagedAgentNormalization.EsMx,
                "es-PA" => ManagedAgentNormalization.EsPa,
                "es-PE" => ManagedAgentNormalization.EsPe,
                "es-PR" => ManagedAgentNormalization.EsPr,
                "es-US" => ManagedAgentNormalization.EsUs,
                "fi-FI" => ManagedAgentNormalization.FiFi,
                "fr-BE" => ManagedAgentNormalization.FrBe,
                "fr-CA" => ManagedAgentNormalization.FrCa,
                "fr-FR" => ManagedAgentNormalization.FrFr,
                "gu-IN" => ManagedAgentNormalization.GuIn,
                "he-IL" => ManagedAgentNormalization.HeIl,
                "hi-IN" => ManagedAgentNormalization.HiIn,
                "hu-HU" => ManagedAgentNormalization.HuHu,
                "id-ID" => ManagedAgentNormalization.IdId,
                "it-IT" => ManagedAgentNormalization.ItIt,
                "ja-JP" => ManagedAgentNormalization.JaJp,
                "ka-GE" => ManagedAgentNormalization.KaGe,
                "kn-IN" => ManagedAgentNormalization.KnIn,
                "ko-KR" => ManagedAgentNormalization.KoKr,
                "ml-IN" => ManagedAgentNormalization.MlIn,
                "mr-IN" => ManagedAgentNormalization.MrIn,
                "ms-MY" => ManagedAgentNormalization.MsMy,
                "nl-BE" => ManagedAgentNormalization.NlBe,
                "nl-NL" => ManagedAgentNormalization.NlNl,
                "no-NO" => ManagedAgentNormalization.NoNo,
                "or-IN" => ManagedAgentNormalization.OrIn,
                "pa-IN" => ManagedAgentNormalization.PaIn,
                "pl-PL" => ManagedAgentNormalization.PlPl,
                "pt-BR" => ManagedAgentNormalization.PtBr,
                "pt-PT" => ManagedAgentNormalization.PtPt,
                "ro-RO" => ManagedAgentNormalization.RoRo,
                "ru-RU" => ManagedAgentNormalization.RuRu,
                "sk-SK" => ManagedAgentNormalization.SkSk,
                "sv-SE" => ManagedAgentNormalization.SvSe,
                "ta-IN" => ManagedAgentNormalization.TaIn,
                "te-IN" => ManagedAgentNormalization.TeIn,
                "th-TH" => ManagedAgentNormalization.ThTh,
                "tl-PH" => ManagedAgentNormalization.TlPh,
                "tr-TR" => ManagedAgentNormalization.TrTr,
                "uk-UA" => ManagedAgentNormalization.UkUa,
                "ur-IN" => ManagedAgentNormalization.UrIn,
                "vi-VN" => ManagedAgentNormalization.ViVn,
                "zh-CN" => ManagedAgentNormalization.ZhCn,
                "zh-TW" => ManagedAgentNormalization.ZhTw,
                _ => null,
            };
        }
    }
}