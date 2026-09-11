
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Default Value: 2026-08-14<br/>
    /// Example: 2026-08-14
    /// </summary>
    public enum DeleteV1AgentsToolsByToolIdCartesiaVersion
    {
        /// <summary>
        ///
        /// </summary>
        x20260814,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteV1AgentsToolsByToolIdCartesiaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteV1AgentsToolsByToolIdCartesiaVersion value)
        {
            return value switch
            {
                DeleteV1AgentsToolsByToolIdCartesiaVersion.x20260814 => "2026-08-14",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteV1AgentsToolsByToolIdCartesiaVersion? ToEnum(string value)
        {
            return value switch
            {
                "2026-08-14" => DeleteV1AgentsToolsByToolIdCartesiaVersion.x20260814,
                _ => null,
            };
        }
    }
}