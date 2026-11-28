
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BalanceResponse
    {
        /// <summary>
        /// Model credits remaining.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining_credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RemainingCredits { get; set; }

        /// <summary>
        /// Voice agent balance remaining, in US cents. `4210` is $42.10. Can be negative when calls run past the balance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining_agent_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RemainingAgentCents { get; set; }

        /// <summary>
        /// When the balance was read.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("as_of")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime AsOf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceResponse" /> class.
        /// </summary>
        /// <param name="remainingCredits">
        /// Model credits remaining.
        /// </param>
        /// <param name="remainingAgentCents">
        /// Voice agent balance remaining, in US cents. `4210` is $42.10. Can be negative when calls run past the balance.
        /// </param>
        /// <param name="asOf">
        /// When the balance was read.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BalanceResponse(
            int remainingCredits,
            int remainingAgentCents,
            global::System.DateTime asOf)
        {
            this.RemainingCredits = remainingCredits;
            this.RemainingAgentCents = remainingAgentCents;
            this.AsOf = asOf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceResponse" /> class.
        /// </summary>
        public BalanceResponse()
        {
        }

    }
}