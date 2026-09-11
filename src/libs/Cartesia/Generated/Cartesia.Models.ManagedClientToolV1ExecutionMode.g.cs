
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Controls how the tool runs relative to the conversation. `immediate` runs in the current turn and can be interrupted by the caller, while `async` lets the turn finish while the tool runs.
    /// </summary>
    public enum ManagedClientToolV1ExecutionMode
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
    public static class ManagedClientToolV1ExecutionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedClientToolV1ExecutionMode value)
        {
            return value switch
            {
                ManagedClientToolV1ExecutionMode.Async => "async",
                ManagedClientToolV1ExecutionMode.Immediate => "immediate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedClientToolV1ExecutionMode? ToEnum(string value)
        {
            return value switch
            {
                "async" => ManagedClientToolV1ExecutionMode.Async,
                "immediate" => ManagedClientToolV1ExecutionMode.Immediate,
                _ => null,
            };
        }
    }
}