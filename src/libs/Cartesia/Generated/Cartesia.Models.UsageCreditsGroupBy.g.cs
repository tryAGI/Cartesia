
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Dimension to break credit usage down by.
    /// </summary>
    public enum UsageCreditsGroupBy
    {
        /// <summary>
        ///
        /// </summary>
        ApiKey,
        /// <summary>
        ///
        /// </summary>
        Capability,
        /// <summary>
        ///
        /// </summary>
        Model,
        /// <summary>
        ///
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageCreditsGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageCreditsGroupBy value)
        {
            return value switch
            {
                UsageCreditsGroupBy.ApiKey => "api_key",
                UsageCreditsGroupBy.Capability => "capability",
                UsageCreditsGroupBy.Model => "model",
                UsageCreditsGroupBy.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageCreditsGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => UsageCreditsGroupBy.ApiKey,
                "capability" => UsageCreditsGroupBy.Capability,
                "model" => UsageCreditsGroupBy.Model,
                "voice" => UsageCreditsGroupBy.Voice,
                _ => null,
            };
        }
    }
}