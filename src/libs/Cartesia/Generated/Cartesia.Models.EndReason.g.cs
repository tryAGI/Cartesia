
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
        AgentError,
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
        CallInactivity,
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
        ClientInactivity,
        /// <summary>
        ///
        /// </summary>
        ConcurrencyLimit,
        /// <summary>
        ///
        /// </summary>
        ConfigError,
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
        DialTimeout,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        MaxDuration,
        /// <summary>
        ///
        /// </summary>
        NetworkError,
        /// <summary>
        ///
        /// </summary>
        VoicemailDetected,
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
                EndReason.AgentError => "agent_error",
                EndReason.AgentHangup => "agent_hangup",
                EndReason.ApiCancelled => "api_cancelled",
                EndReason.CallInactivity => "call_inactivity",
                EndReason.ClientDisconnected => "client_disconnected",
                EndReason.ClientHangup => "client_hangup",
                EndReason.ClientInactivity => "client_inactivity",
                EndReason.ConcurrencyLimit => "concurrency_limit",
                EndReason.ConfigError => "config_error",
                EndReason.DialBusy => "dial_busy",
                EndReason.DialFailed => "dial_failed",
                EndReason.DialNoAnswer => "dial_no_answer",
                EndReason.DialTimeout => "dial_timeout",
                EndReason.Error => "error",
                EndReason.MaxDuration => "max_duration",
                EndReason.NetworkError => "network_error",
                EndReason.VoicemailDetected => "voicemail_detected",
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
                "agent_error" => EndReason.AgentError,
                "agent_hangup" => EndReason.AgentHangup,
                "api_cancelled" => EndReason.ApiCancelled,
                "call_inactivity" => EndReason.CallInactivity,
                "client_disconnected" => EndReason.ClientDisconnected,
                "client_hangup" => EndReason.ClientHangup,
                "client_inactivity" => EndReason.ClientInactivity,
                "concurrency_limit" => EndReason.ConcurrencyLimit,
                "config_error" => EndReason.ConfigError,
                "dial_busy" => EndReason.DialBusy,
                "dial_failed" => EndReason.DialFailed,
                "dial_no_answer" => EndReason.DialNoAnswer,
                "dial_timeout" => EndReason.DialTimeout,
                "error" => EndReason.Error,
                "max_duration" => EndReason.MaxDuration,
                "network_error" => EndReason.NetworkError,
                "voicemail_detected" => EndReason.VoicemailDetected,
                _ => null,
            };
        }
    }
}