
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The language of the input audio in ISO-639-1 format. Defaults to `en`.<br/>
    /// See [the docs](https://docs.cartesia.ai/build-with-cartesia/stt-models/latest) for current language support.
    /// </summary>
    public enum STTManualFinalizeWebSocketQueryParamsLanguage
    {
        /// <summary>
        /// //docs.cartesia.ai/build-with-cartesia/stt-models/latest) for current language support.
        /// </summary>
        En,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTManualFinalizeWebSocketQueryParamsLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTManualFinalizeWebSocketQueryParamsLanguage value)
        {
            return value switch
            {
                STTManualFinalizeWebSocketQueryParamsLanguage.En => "en",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTManualFinalizeWebSocketQueryParamsLanguage? ToEnum(string value)
        {
            return value switch
            {
                "en" => STTManualFinalizeWebSocketQueryParamsLanguage.En,
                _ => null,
            };
        }
    }
}