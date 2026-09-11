
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum AgentDtmfOutputEventType
    {
        /// <summary>
        ///
        /// </summary>
        DtmfOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentDtmfOutputEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentDtmfOutputEventType value)
        {
            return value switch
            {
                AgentDtmfOutputEventType.DtmfOutput => "dtmf_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentDtmfOutputEventType? ToEnum(string value)
        {
            return value switch
            {
                "dtmf_output" => AgentDtmfOutputEventType.DtmfOutput,
                _ => null,
            };
        }
    }
}