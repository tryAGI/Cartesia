
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Role the invited user will receive when they accept
    /// </summary>
    public enum OrganizationInviteRole
    {
        /// <summary>
        ///
        /// </summary>
        Admin,
        /// <summary>
        ///
        /// </summary>
        Member,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationInviteRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationInviteRole value)
        {
            return value switch
            {
                OrganizationInviteRole.Admin => "admin",
                OrganizationInviteRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationInviteRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => OrganizationInviteRole.Admin,
                "member" => OrganizationInviteRole.Member,
                _ => null,
            };
        }
    }
}