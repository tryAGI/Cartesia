
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The region from which the batch's outbound calls are dispatched. Valid only when `from_number_id` is a SIP-trunk number; rejected for other telephony account types. Omit to derive the region from the telephony account.
    /// </summary>
    public enum AgentCallBatchRequestRegion
    {
        /// <summary>
        ///
        /// </summary>
        Apac,
        /// <summary>
        ///
        /// </summary>
        Eu,
        /// <summary>
        ///
        /// </summary>
        Us,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentCallBatchRequestRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCallBatchRequestRegion value)
        {
            return value switch
            {
                AgentCallBatchRequestRegion.Apac => "APAC",
                AgentCallBatchRequestRegion.Eu => "EU",
                AgentCallBatchRequestRegion.Us => "US",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCallBatchRequestRegion? ToEnum(string value)
        {
            return value switch
            {
                "APAC" => AgentCallBatchRequestRegion.Apac,
                "EU" => AgentCallBatchRequestRegion.Eu,
                "US" => AgentCallBatchRequestRegion.Us,
                _ => null,
            };
        }
    }
}