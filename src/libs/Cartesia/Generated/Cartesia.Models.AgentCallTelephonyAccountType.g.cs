
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The telephony account type backing the call. `cartesia` is the default Cartesia-hosted path; `twilio` indicates a customer-owned Twilio subaccount; `sip_trunk` indicates a customer-connected SIP trunk.
    /// </summary>
    public enum AgentCallTelephonyAccountType
    {
        /// <summary>
        ///
        /// </summary>
        Cartesia,
        /// <summary>
        ///
        /// </summary>
        SipTrunk,
        /// <summary>
        ///
        /// </summary>
        Twilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentCallTelephonyAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCallTelephonyAccountType value)
        {
            return value switch
            {
                AgentCallTelephonyAccountType.Cartesia => "cartesia",
                AgentCallTelephonyAccountType.SipTrunk => "sip_trunk",
                AgentCallTelephonyAccountType.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCallTelephonyAccountType? ToEnum(string value)
        {
            return value switch
            {
                "cartesia" => AgentCallTelephonyAccountType.Cartesia,
                "sip_trunk" => AgentCallTelephonyAccountType.SipTrunk,
                "twilio" => AgentCallTelephonyAccountType.Twilio,
                _ => null,
            };
        }
    }
}