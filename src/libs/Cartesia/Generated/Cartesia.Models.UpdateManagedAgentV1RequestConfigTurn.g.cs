
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateManagedAgentV1RequestConfigTurn
    {
        /// <summary>
        /// Seconds of inactivity before the agent says a farewell message and ends the call, from `20` to `240`. Defaults to `240`; cannot be `null`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inactivity_end_call_secs")]
        public int? InactivityEndCallSecs { get; set; }

        /// <summary>
        /// Seconds of inactivity before the agent checks in, from `5` to `60`. Defaults to `8`. Set to `null` to disable check-ins. When enabled, it must be less than `inactivity_end_call_secs`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inactivity_check_in_secs")]
        public int? InactivityCheckInSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateManagedAgentV1RequestConfigTurn" /> class.
        /// </summary>
        /// <param name="inactivityEndCallSecs">
        /// Seconds of inactivity before the agent says a farewell message and ends the call, from `20` to `240`. Defaults to `240`; cannot be `null`.
        /// </param>
        /// <param name="inactivityCheckInSecs">
        /// Seconds of inactivity before the agent checks in, from `5` to `60`. Defaults to `8`. Set to `null` to disable check-ins. When enabled, it must be less than `inactivity_end_call_secs`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateManagedAgentV1RequestConfigTurn(
            int? inactivityEndCallSecs,
            int? inactivityCheckInSecs)
        {
            this.InactivityEndCallSecs = inactivityEndCallSecs;
            this.InactivityCheckInSecs = inactivityCheckInSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateManagedAgentV1RequestConfigTurn" /> class.
        /// </summary>
        public UpdateManagedAgentV1RequestConfigTurn()
        {
        }

    }
}