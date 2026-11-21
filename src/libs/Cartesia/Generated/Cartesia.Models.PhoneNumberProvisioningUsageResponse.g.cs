
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Cartesia-managed phone number provisioning usage for the current month.
    /// </summary>
    public sealed partial class PhoneNumberProvisioningUsageResponse
    {
        /// <summary>
        /// Number of phone numbers provisioned during the current month. This includes active numbers and numbers deleted during the month.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MonthlyUsage { get; set; }

        /// <summary>
        /// Maximum phone numbers that can be provisioned during the current month. `null` means the plan has no monthly limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_limit")]
        public int? MonthlyLimit { get; set; }

        /// <summary>
        /// Phone numbers that can still be provisioned during the current month. `null` means the plan has no monthly limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining")]
        public int? Remaining { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberProvisioningUsageResponse" /> class.
        /// </summary>
        /// <param name="monthlyUsage">
        /// Number of phone numbers provisioned during the current month. This includes active numbers and numbers deleted during the month.
        /// </param>
        /// <param name="monthlyLimit">
        /// Maximum phone numbers that can be provisioned during the current month. `null` means the plan has no monthly limit.
        /// </param>
        /// <param name="remaining">
        /// Phone numbers that can still be provisioned during the current month. `null` means the plan has no monthly limit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumberProvisioningUsageResponse(
            int monthlyUsage,
            int? monthlyLimit,
            int? remaining)
        {
            this.MonthlyUsage = monthlyUsage;
            this.MonthlyLimit = monthlyLimit;
            this.Remaining = remaining;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberProvisioningUsageResponse" /> class.
        /// </summary>
        public PhoneNumberProvisioningUsageResponse()
        {
        }

    }
}