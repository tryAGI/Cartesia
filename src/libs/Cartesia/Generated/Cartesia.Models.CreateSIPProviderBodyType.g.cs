
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Must be `"sip_trunk"`.
    /// </summary>
    public enum CreateSIPProviderBodyType
    {
        /// <summary>
        ///
        /// </summary>
        SipTrunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSIPProviderBodyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSIPProviderBodyType value)
        {
            return value switch
            {
                CreateSIPProviderBodyType.SipTrunk => "sip_trunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSIPProviderBodyType? ToEnum(string value)
        {
            return value switch
            {
                "sip_trunk" => CreateSIPProviderBodyType.SipTrunk,
                _ => null,
            };
        }
    }
}