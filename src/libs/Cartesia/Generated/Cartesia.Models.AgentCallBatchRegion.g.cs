
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The region that handles the batch.
    /// </summary>
    public enum AgentCallBatchRegion
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
    public static class AgentCallBatchRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCallBatchRegion value)
        {
            return value switch
            {
                AgentCallBatchRegion.Apac => "APAC",
                AgentCallBatchRegion.Eu => "EU",
                AgentCallBatchRegion.Us => "US",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCallBatchRegion? ToEnum(string value)
        {
            return value switch
            {
                "APAC" => AgentCallBatchRegion.Apac,
                "EU" => AgentCallBatchRegion.Eu,
                "US" => AgentCallBatchRegion.Us,
                _ => null,
            };
        }
    }
}