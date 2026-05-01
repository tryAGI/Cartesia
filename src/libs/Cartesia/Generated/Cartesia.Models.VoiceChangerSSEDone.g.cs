
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Generation completion signal. Final event in the stream.<br/>
    /// Example: {"done":true,"status_code":200}
    /// </summary>
    public sealed partial class VoiceChangerSSEDone
    {
        /// <summary>
        /// HTTP-style status code. Always `200` for done events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

        /// <summary>
        /// Whether generation is complete. Always `true` for done events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("done")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Done { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceChangerSSEDone" /> class.
        /// </summary>
        /// <param name="statusCode">
        /// HTTP-style status code. Always `200` for done events.
        /// </param>
        /// <param name="done">
        /// Whether generation is complete. Always `true` for done events.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceChangerSSEDone(
            int statusCode,
            bool done)
        {
            this.StatusCode = statusCode;
            this.Done = done;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceChangerSSEDone" /> class.
        /// </summary>
        public VoiceChangerSSEDone()
        {
        }
    }
}