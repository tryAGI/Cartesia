
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Controls how the tool runs relative to the conversation. `immediate` runs in the current turn and can be interrupted by the caller, while `async` lets the turn finish while the tool runs.
    /// </summary>
    public enum ManagedWebhookToolV1ExecutionMode
    {
        /// <summary>
        ///
        /// </summary>
        Async,
        /// <summary>
        ///
        /// </summary>
        Immediate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManagedWebhookToolV1ExecutionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedWebhookToolV1ExecutionMode value)
        {
            return value switch
            {
                ManagedWebhookToolV1ExecutionMode.Async => "async",
                ManagedWebhookToolV1ExecutionMode.Immediate => "immediate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedWebhookToolV1ExecutionMode? ToEnum(string value)
        {
            return value switch
            {
                "async" => ManagedWebhookToolV1ExecutionMode.Async,
                "immediate" => ManagedWebhookToolV1ExecutionMode.Immediate,
                _ => null,
            };
        }
    }
}