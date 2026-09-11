
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Controls how the tool runs relative to the conversation. `immediate` runs in the current turn and can be interrupted by the caller. `async` lets the turn finish while the tool runs.
    /// </summary>
    public enum UpdateManagedToolV1RequestClientToolUpdateExecutionMode
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
    public static class UpdateManagedToolV1RequestClientToolUpdateExecutionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateManagedToolV1RequestClientToolUpdateExecutionMode value)
        {
            return value switch
            {
                UpdateManagedToolV1RequestClientToolUpdateExecutionMode.Async => "async",
                UpdateManagedToolV1RequestClientToolUpdateExecutionMode.Immediate => "immediate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateManagedToolV1RequestClientToolUpdateExecutionMode? ToEnum(string value)
        {
            return value switch
            {
                "async" => UpdateManagedToolV1RequestClientToolUpdateExecutionMode.Async,
                "immediate" => UpdateManagedToolV1RequestClientToolUpdateExecutionMode.Immediate,
                _ => null,
            };
        }
    }
}