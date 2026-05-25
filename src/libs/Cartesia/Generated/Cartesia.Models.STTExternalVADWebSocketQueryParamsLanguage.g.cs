
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The language of the input audio in ISO-639-1 format. Defaults to `en`.<br/>
    /// See [the docs](https://docs.cartesia.ai/build-with-cartesia/stt-models/latest) for current language support.
    /// </summary>
    public enum STTExternalVADWebSocketQueryParamsLanguage
    {
        /// <summary>
        /// //docs.cartesia.ai/build-with-cartesia/stt-models/latest) for current language support.
        /// </summary>
        En,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTExternalVADWebSocketQueryParamsLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTExternalVADWebSocketQueryParamsLanguage value)
        {
            return value switch
            {
                STTExternalVADWebSocketQueryParamsLanguage.En => "en",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTExternalVADWebSocketQueryParamsLanguage? ToEnum(string value)
        {
            return value switch
            {
                "en" => STTExternalVADWebSocketQueryParamsLanguage.En,
                _ => null,
            };
        }
    }
}