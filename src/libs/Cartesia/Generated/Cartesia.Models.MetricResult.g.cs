
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetricResult
    {
        /// <summary>
        /// The unique identifier for the metric result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The identifier of the metric being measured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metricId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MetricId { get; set; }

        /// <summary>
        /// The name of the metric being measured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metricName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MetricName { get; set; }

        /// <summary>
        /// A summary of the transcript of the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Summary { get; set; }

        /// <summary>
        /// The transcript of the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public global::System.Collections.Generic.IList<global::Cartesia.AgentTranscript>? Transcript { get; set; }

        /// <summary>
        /// The identifier of the agent associated with the metric result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The identifier of the call associated with the metric result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// The identifier of the deployment associated with the metric result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentId { get; set; }

        /// <summary>
        /// The raw result of the metric in a string format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Result { get; set; }

        /// <summary>
        /// The structured JSON result of the metric.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jsonResult")]
        public object? JsonResult { get; set; }

        /// <summary>
        /// The value of the metric result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// The status of an agent metric result. `failed` indicates that the metric result was not computed or parsed properly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.AgentMetricResultStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.AgentMetricResultStatus Status { get; set; }

        /// <summary>
        /// The identifier of the run associated with the metric result, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runId")]
        public string? RunId { get; set; }

        /// <summary>
        /// The UTC timestamp when the metric result was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricResult" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the metric result.
        /// </param>
        /// <param name="metricId">
        /// The identifier of the metric being measured.
        /// </param>
        /// <param name="metricName">
        /// The name of the metric being measured.
        /// </param>
        /// <param name="summary">
        /// A summary of the transcript of the call.
        /// </param>
        /// <param name="transcript">
        /// The transcript of the call.
        /// </param>
        /// <param name="agentId">
        /// The identifier of the agent associated with the metric result.
        /// </param>
        /// <param name="callId">
        /// The identifier of the call associated with the metric result.
        /// </param>
        /// <param name="deploymentId">
        /// The identifier of the deployment associated with the metric result.
        /// </param>
        /// <param name="result">
        /// The raw result of the metric in a string format.
        /// </param>
        /// <param name="jsonResult">
        /// The structured JSON result of the metric.
        /// </param>
        /// <param name="value">
        /// The value of the metric result.
        /// </param>
        /// <param name="status">
        /// The status of an agent metric result. `failed` indicates that the metric result was not computed or parsed properly.
        /// </param>
        /// <param name="runId">
        /// The identifier of the run associated with the metric result, if applicable.
        /// </param>
        /// <param name="createdAt">
        /// The UTC timestamp when the metric result was created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetricResult(
            string id,
            string metricId,
            string metricName,
            string summary,
            string agentId,
            string callId,
            string deploymentId,
            string result,
            global::Cartesia.AgentMetricResultStatus status,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.IList<global::Cartesia.AgentTranscript>? transcript,
            object? jsonResult,
            object? value,
            string? runId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MetricId = metricId ?? throw new global::System.ArgumentNullException(nameof(metricId));
            this.MetricName = metricName ?? throw new global::System.ArgumentNullException(nameof(metricName));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.Status = status;
            this.CreatedAt = createdAt;
            this.Transcript = transcript;
            this.JsonResult = jsonResult;
            this.Value = value;
            this.RunId = runId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricResult" /> class.
        /// </summary>
        public MetricResult()
        {
        }
    }
}