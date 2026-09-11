
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// SRTP policy for call audio. `disabled` does not negotiate encryption, `allowed` uses encryption when available, and `required` rejects calls that cannot use encryption.
    /// </summary>
    public enum SIPMediaEncryption
    {
        /// <summary>
        ///
        /// </summary>
        Allowed,
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SIPMediaEncryptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SIPMediaEncryption value)
        {
            return value switch
            {
                SIPMediaEncryption.Allowed => "allowed",
                SIPMediaEncryption.Disabled => "disabled",
                SIPMediaEncryption.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SIPMediaEncryption? ToEnum(string value)
        {
            return value switch
            {
                "allowed" => SIPMediaEncryption.Allowed,
                "disabled" => SIPMediaEncryption.Disabled,
                "required" => SIPMediaEncryption.Required,
                _ => null,
            };
        }
    }
}