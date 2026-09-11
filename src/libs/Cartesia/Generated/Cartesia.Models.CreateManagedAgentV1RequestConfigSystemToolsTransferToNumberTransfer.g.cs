
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer
    {
        /// <summary>
        /// When the agent should transfer the call to this destination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Condition { get; set; }

        /// <summary>
        /// Where to transfer the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestination Destination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer" /> class.
        /// </summary>
        /// <param name="condition">
        /// When the agent should transfer the call to this destination.
        /// </param>
        /// <param name="destination">
        /// Where to transfer the call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer(
            string condition,
            global::Cartesia.CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransferDestination destination)
        {
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
            this.Destination = destination ?? throw new global::System.ArgumentNullException(nameof(destination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer" /> class.
        /// </summary>
        public CreateManagedAgentV1RequestConfigSystemToolsTransferToNumberTransfer()
        {
        }

    }
}