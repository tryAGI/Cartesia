
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// A machine-readable enum indicating why a call ended.
    /// </summary>
    public enum EndReason
    {
        /// <summary>
        ///
        /// </summary>
        AgentHangup,
        /// <summary>
        ///
        /// </summary>
        ApiCancelled,
        /// <summary>
        ///
        /// </summary>
        ClientDisconnected,
        /// <summary>
        ///
        /// </summary>
        ClientHangup,
        /// <summary>
        ///
        /// </summary>
        DialBusy,
        /// <summary>
        ///
        /// </summary>
        DialFailed,
        /// <summary>
        ///
        /// </summary>
        DialNoAnswer,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Inactivity,
        /// <summary>
        ///
        /// </summary>
        MaxDuration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndReason value)
        {
            return value switch
            {
                EndReason.AgentHangup => "agent_hangup",
                EndReason.ApiCancelled => "api_cancelled",
                EndReason.ClientDisconnected => "client_disconnected",
                EndReason.ClientHangup => "client_hangup",
                EndReason.DialBusy => "dial_busy",
                EndReason.DialFailed => "dial_failed",
                EndReason.DialNoAnswer => "dial_no_answer",
                EndReason.Error => "error",
                EndReason.Inactivity => "inactivity",
                EndReason.MaxDuration => "max_duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndReason? ToEnum(string value)
        {
            return value switch
            {
                "agent_hangup" => EndReason.AgentHangup,
                "api_cancelled" => EndReason.ApiCancelled,
                "client_disconnected" => EndReason.ClientDisconnected,
                "client_hangup" => EndReason.ClientHangup,
                "dial_busy" => EndReason.DialBusy,
                "dial_failed" => EndReason.DialFailed,
                "dial_no_answer" => EndReason.DialNoAnswer,
                "error" => EndReason.Error,
                "inactivity" => EndReason.Inactivity,
                "max_duration" => EndReason.MaxDuration,
                _ => null,
            };
        }
    }
}