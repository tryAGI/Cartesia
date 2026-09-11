
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Event type identifier.
    /// </summary>
    public enum AgentDtmfInputEventType
    {
        /// <summary>
        ///
        /// </summary>
        DtmfInput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentDtmfInputEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentDtmfInputEventType value)
        {
            return value switch
            {
                AgentDtmfInputEventType.DtmfInput => "dtmf_input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentDtmfInputEventType? ToEnum(string value)
        {
            return value switch
            {
                "dtmf_input" => AgentDtmfInputEventType.DtmfInput,
                _ => null,
            };
        }
    }
}