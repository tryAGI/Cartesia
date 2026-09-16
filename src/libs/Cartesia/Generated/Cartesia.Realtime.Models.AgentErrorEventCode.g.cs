
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// `invalid_event` means a client event was rejected; `agent_failed` means the agent failed. The following errors prevent the session from starting:<br/>
    /// - `missing_dynamic_variables`: a value needed by the welcome message is missing.<br/>
    /// - `invalid_dynamic_variables`: the supplied names or values are invalid.<br/>
    /// - `dynamic_variables_not_allowed`: a browser access token was used to supply custom values.
    /// </summary>
    public enum AgentErrorEventCode
    {
        /// <summary>
        ///
        /// </summary>
        AgentFailed,
        /// <summary>
        /// a browser access token was used to supply custom values.
        /// </summary>
        DynamicVariablesNotAllowed,
        /// <summary>
        /// the supplied names or values are invalid.
        /// </summary>
        InvalidDynamicVariables,
        /// <summary>
        ///
        /// </summary>
        InvalidEvent,
        /// <summary>
        /// a value needed by the welcome message is missing.
        /// </summary>
        MissingDynamicVariables,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentErrorEventCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentErrorEventCode value)
        {
            return value switch
            {
                AgentErrorEventCode.AgentFailed => "agent_failed",
                AgentErrorEventCode.DynamicVariablesNotAllowed => "dynamic_variables_not_allowed",
                AgentErrorEventCode.InvalidDynamicVariables => "invalid_dynamic_variables",
                AgentErrorEventCode.InvalidEvent => "invalid_event",
                AgentErrorEventCode.MissingDynamicVariables => "missing_dynamic_variables",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentErrorEventCode? ToEnum(string value)
        {
            return value switch
            {
                "agent_failed" => AgentErrorEventCode.AgentFailed,
                "dynamic_variables_not_allowed" => AgentErrorEventCode.DynamicVariablesNotAllowed,
                "invalid_dynamic_variables" => AgentErrorEventCode.InvalidDynamicVariables,
                "invalid_event" => AgentErrorEventCode.InvalidEvent,
                "missing_dynamic_variables" => AgentErrorEventCode.MissingDynamicVariables,
                _ => null,
            };
        }
    }
}