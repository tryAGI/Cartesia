
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Background audio played during the conversation.
    /// </summary>
    public sealed partial class ManagedAgentConfigV1AudioOutputBackgroundSound
    {
        /// <summary>
        /// ID of the audio file to play in the background.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Background audio volume, from `0` to `2`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Volume { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentConfigV1AudioOutputBackgroundSound" /> class.
        /// </summary>
        /// <param name="fileId">
        /// ID of the audio file to play in the background.
        /// </param>
        /// <param name="volume">
        /// Background audio volume, from `0` to `2`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedAgentConfigV1AudioOutputBackgroundSound(
            string fileId,
            double volume)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Volume = volume;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAgentConfigV1AudioOutputBackgroundSound" /> class.
        /// </summary>
        public ManagedAgentConfigV1AudioOutputBackgroundSound()
        {
        }

    }
}