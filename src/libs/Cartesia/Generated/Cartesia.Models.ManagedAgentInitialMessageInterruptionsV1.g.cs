
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Controls how the agent handles interruptions while `initial_message` plays. `allow` lets the caller interrupt it, `ignore` plays it in full and adds what the caller says meanwhile to the LLM context without answering it, and `respond_after` plays it in full, then replies. Defaults to `allow`.
    /// </summary>
    public enum ManagedAgentInitialMessageInterruptionsV1
    {
        /// <summary>
        ///
        /// </summary>
        Allow,
        /// <summary>
        ///
        /// </summary>
        Ignore,
        /// <summary>
        ///
        /// </summary>
        RespondAfter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManagedAgentInitialMessageInterruptionsV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedAgentInitialMessageInterruptionsV1 value)
        {
            return value switch
            {
                ManagedAgentInitialMessageInterruptionsV1.Allow => "allow",
                ManagedAgentInitialMessageInterruptionsV1.Ignore => "ignore",
                ManagedAgentInitialMessageInterruptionsV1.RespondAfter => "respond_after",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedAgentInitialMessageInterruptionsV1? ToEnum(string value)
        {
            return value switch
            {
                "allow" => ManagedAgentInitialMessageInterruptionsV1.Allow,
                "ignore" => ManagedAgentInitialMessageInterruptionsV1.Ignore,
                "respond_after" => ManagedAgentInitialMessageInterruptionsV1.RespondAfter,
                _ => null,
            };
        }
    }
}