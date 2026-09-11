
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Role of a user in the organization
    /// </summary>
    public enum OrganizationUserRole
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
    public static class OrganizationUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationUserRole value)
        {
            return value switch
            {
                OrganizationUserRole.Admin => "admin",
                OrganizationUserRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => OrganizationUserRole.Admin,
                "member" => OrganizationUserRole.Member,
                _ => null,
            };
        }
    }
}