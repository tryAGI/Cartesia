
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Deprecated. Prefer a top-level `access` string (`"public"` | `"private"`).
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class UpdateVoiceRequestAccessEnum2
    {
        /// <summary>
        /// Set to `"public"` to let any Cartesia user with the resource ID use it, or `"private"` to restrict it to your organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.UpdateVoiceRequestAccessEnumTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required global::Cartesia.UpdateVoiceRequestAccessEnumType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVoiceRequestAccessEnum2" /> class.
        /// </summary>
        /// <param name="type">
        /// Set to `"public"` to let any Cartesia user with the resource ID use it, or `"private"` to restrict it to your organization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateVoiceRequestAccessEnum2(
            global::Cartesia.UpdateVoiceRequestAccessEnumType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVoiceRequestAccessEnum2" /> class.
        /// </summary>
        public UpdateVoiceRequestAccessEnum2()
        {
        }

    }
}