
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Status of the invite
    /// </summary>
    public enum OrganizationInviteStatus
    {
        /// <summary>
        ///
        /// </summary>
        Accepted,
        /// <summary>
        ///
        /// </summary>
        Expired,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Revoked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationInviteStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationInviteStatus value)
        {
            return value switch
            {
                OrganizationInviteStatus.Accepted => "accepted",
                OrganizationInviteStatus.Expired => "expired",
                OrganizationInviteStatus.Pending => "pending",
                OrganizationInviteStatus.Revoked => "revoked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationInviteStatus? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => OrganizationInviteStatus.Accepted,
                "expired" => OrganizationInviteStatus.Expired,
                "pending" => OrganizationInviteStatus.Pending,
                "revoked" => OrganizationInviteStatus.Revoked,
                _ => null,
            };
        }
    }
}