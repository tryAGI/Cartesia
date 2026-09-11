
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public enum ManagedAgentModelV1PricingCurrency
    {
        /// <summary>
        ///
        /// </summary>
        Usd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManagedAgentModelV1PricingCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedAgentModelV1PricingCurrency value)
        {
            return value switch
            {
                ManagedAgentModelV1PricingCurrency.Usd => "USD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedAgentModelV1PricingCurrency? ToEnum(string value)
        {
            return value switch
            {
                "USD" => ManagedAgentModelV1PricingCurrency.Usd,
                _ => null,
            };
        }
    }
}