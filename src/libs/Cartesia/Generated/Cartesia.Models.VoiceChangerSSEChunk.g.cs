
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Audio data chunk.<br/>
    /// Example: {"done":false,"status_code":206,"step_time":123,"data":"aSDinaTvuI8gbWludGxpZnk=","sample_rate":44100}
    /// </summary>
    public sealed partial class VoiceChangerSSEChunk
    {
        /// <summary>
        /// HTTP-style status code. Always `206` for chunk events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

        /// <summary>
        /// Whether this is the final event for the request. Always `false` for chunk events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("done")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Done { get; set; }

        /// <summary>
        /// Base64-encoded audio data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// The sample rate of the audio in Hz.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SampleRate { get; set; }

        /// <summary>
        /// Server-side processing time for this chunk in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StepTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceChangerSSEChunk" /> class.
        /// </summary>
        /// <param name="statusCode">
        /// HTTP-style status code. Always `206` for chunk events.
        /// </param>
        /// <param name="done">
        /// Whether this is the final event for the request. Always `false` for chunk events.
        /// </param>
        /// <param name="data">
        /// Base64-encoded audio data.
        /// </param>
        /// <param name="sampleRate">
        /// The sample rate of the audio in Hz.
        /// </param>
        /// <param name="stepTime">
        /// Server-side processing time for this chunk in milliseconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceChangerSSEChunk(
            int statusCode,
            bool done,
            string data,
            int sampleRate,
            double stepTime)
        {
            this.StatusCode = statusCode;
            this.Done = done;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.SampleRate = sampleRate;
            this.StepTime = stepTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceChangerSSEChunk" /> class.
        /// </summary>
        public VoiceChangerSSEChunk()
        {
        }
    }
}