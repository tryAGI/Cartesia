
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Default Value: pending
    /// </summary>
    public enum GetOrganizationsInvitesStatus
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
    public static class GetOrganizationsInvitesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsInvitesStatus value)
        {
            return value switch
            {
                GetOrganizationsInvitesStatus.Accepted => "accepted",
                GetOrganizationsInvitesStatus.Expired => "expired",
                GetOrganizationsInvitesStatus.Pending => "pending",
                GetOrganizationsInvitesStatus.Revoked => "revoked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsInvitesStatus? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => GetOrganizationsInvitesStatus.Accepted,
                "expired" => GetOrganizationsInvitesStatus.Expired,
                "pending" => GetOrganizationsInvitesStatus.Pending,
                "revoked" => GetOrganizationsInvitesStatus.Revoked,
                _ => null,
            };
        }
    }
}