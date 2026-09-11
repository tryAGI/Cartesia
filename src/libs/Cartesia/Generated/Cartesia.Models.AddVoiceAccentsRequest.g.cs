
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AddVoiceAccentsRequest
    {
        /// <summary>
        /// Additional accents you want this voice to speak natively. The voice must already have an accent of its own: if [Get Voice](/api-reference/voices/get) returns no `accents` field, set one with [Update Voice](/api-reference/voices/update) first. A voice can support up to 10 accents in total.<br/>
        /// Example: [british, parisian]
        /// </summary>
        /// <example>[british, parisian]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("accents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Cartesia.AttachVoiceAccent> Accents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddVoiceAccentsRequest" /> class.
        /// </summary>
        /// <param name="accents">
        /// Additional accents you want this voice to speak natively. The voice must already have an accent of its own: if [Get Voice](/api-reference/voices/get) returns no `accents` field, set one with [Update Voice](/api-reference/voices/update) first. A voice can support up to 10 accents in total.<br/>
        /// Example: [british, parisian]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddVoiceAccentsRequest(
            global::System.Collections.Generic.IList<global::Cartesia.AttachVoiceAccent> accents)
        {
            this.Accents = accents ?? throw new global::System.ArgumentNullException(nameof(accents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddVoiceAccentsRequest" /> class.
        /// </summary>
        public AddVoiceAccentsRequest()
        {
        }

    }
}