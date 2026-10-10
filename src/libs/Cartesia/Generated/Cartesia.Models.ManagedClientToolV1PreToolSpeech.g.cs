
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Controls whether the agent speaks before using the tool. `auto` lets the agent decide, `force` asks the agent to speak first, and `off` doesn't ask it to.
    /// </summary>
    public enum ManagedClientToolV1PreToolSpeech
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Force,
        /// <summary>
        ///
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManagedClientToolV1PreToolSpeechExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedClientToolV1PreToolSpeech value)
        {
            return value switch
            {
                ManagedClientToolV1PreToolSpeech.Auto => "auto",
                ManagedClientToolV1PreToolSpeech.Force => "force",
                ManagedClientToolV1PreToolSpeech.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedClientToolV1PreToolSpeech? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ManagedClientToolV1PreToolSpeech.Auto,
                "force" => ManagedClientToolV1PreToolSpeech.Force,
                "off" => ManagedClientToolV1PreToolSpeech.Off,
                _ => null,
            };
        }
    }
}