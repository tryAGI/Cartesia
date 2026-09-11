
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Controls how the tool runs relative to the conversation. `immediate` runs in the current turn and can be interrupted by the caller. `async` lets the turn finish while the tool runs.
    /// </summary>
    public enum UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode
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
    public static class UpdateManagedToolV1RequestWebhookToolUpdateExecutionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode value)
        {
            return value switch
            {
                UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode.Async => "async",
                UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode.Immediate => "immediate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode? ToEnum(string value)
        {
            return value switch
            {
                "async" => UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode.Async,
                "immediate" => UpdateManagedToolV1RequestWebhookToolUpdateExecutionMode.Immediate,
                _ => null,
            };
        }
    }
}