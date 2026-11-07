
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum NullableManagedAgentLanguageOrLocaleEnum
    {
        /// <summary>
        ///
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NullableManagedAgentLanguageOrLocaleEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NullableManagedAgentLanguageOrLocaleEnum value)
        {
            return value switch
            {
                NullableManagedAgentLanguageOrLocaleEnum.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NullableManagedAgentLanguageOrLocaleEnum? ToEnum(string value)
        {
            return value switch
            {
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => NullableManagedAgentLanguageOrLocaleEnum.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}