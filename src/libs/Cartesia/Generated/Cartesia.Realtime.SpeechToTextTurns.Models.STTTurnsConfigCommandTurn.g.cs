
#nullable enable

namespace Cartesia.Realtime.SpeechToTextTurns
{
    /// <summary>
    /// Turn detection settings
    /// </summary>
    public sealed partial class STTTurnsConfigCommandTurn
    {
        /// <summary>
        /// Threshold above which the turn starts. Default: 0.8. Range: 0.5–0.9. Must stay above `eager_end_threshold`.<br/>
        /// See [Configuring turn detection](/use-the-api/stt/turns#configuring-turn-detection) for details.<br/>
        /// Default Value: 0.8F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_threshold")]
        public double? StartThreshold { get; set; }

        /// <summary>
        /// Threshold below which `turn.eager_end` fires. Default: 0.6. Range: 0.3–0.8. Must stay between `end_threshold` and `start_threshold`.<br/>
        /// See [Configuring turn detection](/use-the-api/stt/turns#configuring-turn-detection) for details.<br/>
        /// Default Value: 0.6F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eager_end_threshold")]
        public double? EagerEndThreshold { get; set; }

        /// <summary>
        /// Threshold below which the turn ends. Default: 0.3. Range: 0.05–0.5. Must stay below `eager_end_threshold`.<br/>
        /// See [Configuring turn detection](/use-the-api/stt/turns#configuring-turn-detection) for details.<br/>
        /// Default Value: 0.3F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_threshold")]
        public double? EndThreshold { get; set; }

        /// <summary>
        /// The longest the model waits after the user stops speaking before it ends the turn, in milliseconds. Default: 5600. Range: 640–11200.<br/>
        /// See [Configuring turn detection](/use-the-api/stt/turns#configuring-turn-detection) for details.<br/>
        /// Default Value: 5600
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_timeout_ms")]
        public double? EndTimeoutMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTTurnsConfigCommandTurn" /> class.
        /// </summary>
        /// <param name="startThreshold">
        /// Threshold above which the turn starts. Default: 0.8. Range: 0.5–0.9. Must stay above `eager_end_threshold`.<br/>
        /// See [Configuring turn detection](/use-the-api/stt/turns#configuring-turn-detection) for details.<br/>
        /// Default Value: 0.8F
        /// </param>
        /// <param name="eagerEndThreshold">
        /// Threshold below which `turn.eager_end` fires. Default: 0.6. Range: 0.3–0.8. Must stay between `end_threshold` and `start_threshold`.<br/>
        /// See [Configuring turn detection](/use-the-api/stt/turns#configuring-turn-detection) for details.<br/>
        /// Default Value: 0.6F
        /// </param>
        /// <param name="endThreshold">
        /// Threshold below which the turn ends. Default: 0.3. Range: 0.05–0.5. Must stay below `eager_end_threshold`.<br/>
        /// See [Configuring turn detection](/use-the-api/stt/turns#configuring-turn-detection) for details.<br/>
        /// Default Value: 0.3F
        /// </param>
        /// <param name="endTimeoutMs">
        /// The longest the model waits after the user stops speaking before it ends the turn, in milliseconds. Default: 5600. Range: 640–11200.<br/>
        /// See [Configuring turn detection](/use-the-api/stt/turns#configuring-turn-detection) for details.<br/>
        /// Default Value: 5600
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTTurnsConfigCommandTurn(
            double? startThreshold,
            double? eagerEndThreshold,
            double? endThreshold,
            double? endTimeoutMs)
        {
            this.StartThreshold = startThreshold;
            this.EagerEndThreshold = eagerEndThreshold;
            this.EndThreshold = endThreshold;
            this.EndTimeoutMs = endTimeoutMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTTurnsConfigCommandTurn" /> class.
        /// </summary>
        public STTTurnsConfigCommandTurn()
        {
        }

    }
}