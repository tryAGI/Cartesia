
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DetectWatermarkResponse
    {
        /// <summary>
        /// Whether a Cartesia watermark was detected in the audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Detected { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectWatermarkResponse" /> class.
        /// </summary>
        /// <param name="detected">
        /// Whether a Cartesia watermark was detected in the audio
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectWatermarkResponse(
            bool detected)
        {
            this.Detected = detected;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectWatermarkResponse" /> class.
        /// </summary>
        public DetectWatermarkResponse()
        {
        }

    }
}