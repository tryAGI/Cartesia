
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Background audio played during the conversation. Set to `null` to disable it.
    /// </summary>
    public sealed partial class CreateManagedAgentV1RequestConfigAudioOutputBackgroundSound
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
        public double? Volume { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagedAgentV1RequestConfigAudioOutputBackgroundSound" /> class.
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
        public CreateManagedAgentV1RequestConfigAudioOutputBackgroundSound(
            string fileId,
            double? volume)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Volume = volume;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagedAgentV1RequestConfigAudioOutputBackgroundSound" /> class.
        /// </summary>
        public CreateManagedAgentV1RequestConfigAudioOutputBackgroundSound()
        {
        }

    }
}