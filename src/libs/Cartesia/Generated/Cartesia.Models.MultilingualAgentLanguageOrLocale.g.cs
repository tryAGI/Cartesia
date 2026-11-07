
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum MultilingualAgentLanguageOrLocale
    {
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
        Fr,
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
        Hi,
        /// <summary>
        ///
        /// </summary>
        HiIn,
        /// <summary>
        ///
        /// </summary>
        Ja,
        /// <summary>
        ///
        /// </summary>
        JaJp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MultilingualAgentLanguageOrLocaleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MultilingualAgentLanguageOrLocale value)
        {
            return value switch
            {
                MultilingualAgentLanguageOrLocale.En => "en",
                MultilingualAgentLanguageOrLocale.EnAu => "en-AU",
                MultilingualAgentLanguageOrLocale.EnCa => "en-CA",
                MultilingualAgentLanguageOrLocale.EnGb => "en-GB",
                MultilingualAgentLanguageOrLocale.EnIe => "en-IE",
                MultilingualAgentLanguageOrLocale.EnIn => "en-IN",
                MultilingualAgentLanguageOrLocale.EnNz => "en-NZ",
                MultilingualAgentLanguageOrLocale.EnSg => "en-SG",
                MultilingualAgentLanguageOrLocale.EnUs => "en-US",
                MultilingualAgentLanguageOrLocale.EnZa => "en-ZA",
                MultilingualAgentLanguageOrLocale.Es => "es",
                MultilingualAgentLanguageOrLocale.EsAr => "es-AR",
                MultilingualAgentLanguageOrLocale.EsBo => "es-BO",
                MultilingualAgentLanguageOrLocale.EsCl => "es-CL",
                MultilingualAgentLanguageOrLocale.EsCo => "es-CO",
                MultilingualAgentLanguageOrLocale.EsDo => "es-DO",
                MultilingualAgentLanguageOrLocale.EsEs => "es-ES",
                MultilingualAgentLanguageOrLocale.EsMx => "es-MX",
                MultilingualAgentLanguageOrLocale.EsPa => "es-PA",
                MultilingualAgentLanguageOrLocale.EsPe => "es-PE",
                MultilingualAgentLanguageOrLocale.EsPr => "es-PR",
                MultilingualAgentLanguageOrLocale.EsUs => "es-US",
                MultilingualAgentLanguageOrLocale.Fr => "fr",
                MultilingualAgentLanguageOrLocale.FrBe => "fr-BE",
                MultilingualAgentLanguageOrLocale.FrCa => "fr-CA",
                MultilingualAgentLanguageOrLocale.FrFr => "fr-FR",
                MultilingualAgentLanguageOrLocale.Hi => "hi",
                MultilingualAgentLanguageOrLocale.HiIn => "hi-IN",
                MultilingualAgentLanguageOrLocale.Ja => "ja",
                MultilingualAgentLanguageOrLocale.JaJp => "ja-JP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MultilingualAgentLanguageOrLocale? ToEnum(string value)
        {
            return value switch
            {
                "en" => MultilingualAgentLanguageOrLocale.En,
                "en-AU" => MultilingualAgentLanguageOrLocale.EnAu,
                "en-CA" => MultilingualAgentLanguageOrLocale.EnCa,
                "en-GB" => MultilingualAgentLanguageOrLocale.EnGb,
                "en-IE" => MultilingualAgentLanguageOrLocale.EnIe,
                "en-IN" => MultilingualAgentLanguageOrLocale.EnIn,
                "en-NZ" => MultilingualAgentLanguageOrLocale.EnNz,
                "en-SG" => MultilingualAgentLanguageOrLocale.EnSg,
                "en-US" => MultilingualAgentLanguageOrLocale.EnUs,
                "en-ZA" => MultilingualAgentLanguageOrLocale.EnZa,
                "es" => MultilingualAgentLanguageOrLocale.Es,
                "es-AR" => MultilingualAgentLanguageOrLocale.EsAr,
                "es-BO" => MultilingualAgentLanguageOrLocale.EsBo,
                "es-CL" => MultilingualAgentLanguageOrLocale.EsCl,
                "es-CO" => MultilingualAgentLanguageOrLocale.EsCo,
                "es-DO" => MultilingualAgentLanguageOrLocale.EsDo,
                "es-ES" => MultilingualAgentLanguageOrLocale.EsEs,
                "es-MX" => MultilingualAgentLanguageOrLocale.EsMx,
                "es-PA" => MultilingualAgentLanguageOrLocale.EsPa,
                "es-PE" => MultilingualAgentLanguageOrLocale.EsPe,
                "es-PR" => MultilingualAgentLanguageOrLocale.EsPr,
                "es-US" => MultilingualAgentLanguageOrLocale.EsUs,
                "fr" => MultilingualAgentLanguageOrLocale.Fr,
                "fr-BE" => MultilingualAgentLanguageOrLocale.FrBe,
                "fr-CA" => MultilingualAgentLanguageOrLocale.FrCa,
                "fr-FR" => MultilingualAgentLanguageOrLocale.FrFr,
                "hi" => MultilingualAgentLanguageOrLocale.Hi,
                "hi-IN" => MultilingualAgentLanguageOrLocale.HiIn,
                "ja" => MultilingualAgentLanguageOrLocale.Ja,
                "ja-JP" => MultilingualAgentLanguageOrLocale.JaJp,
                _ => null,
            };
        }
    }
}