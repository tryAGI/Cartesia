
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Who can use the cloned voice. Prefer `"public"` | `"private"`. Deprecated form field `access[type]` is still accepted.<br/>
    /// Default Value: private
    /// </summary>
    public enum VoicesCloneRequestAccess
    {
        /// <summary>
        ///
        /// </summary>
        Private,
        /// <summary>
        ///
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoicesCloneRequestAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoicesCloneRequestAccess value)
        {
            return value switch
            {
                VoicesCloneRequestAccess.Private => "private",
                VoicesCloneRequestAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoicesCloneRequestAccess? ToEnum(string value)
        {
            return value switch
            {
                "private" => VoicesCloneRequestAccess.Private,
                "public" => VoicesCloneRequestAccess.Public,
                _ => null,
            };
        }
    }
}