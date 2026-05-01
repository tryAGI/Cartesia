
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Word-level timing information.
    /// </summary>
    public sealed partial class WordTimestamps
    {
        /// <summary>
        /// List of words in order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Words { get; set; }

        /// <summary>
        /// Start times in seconds for each word.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Start { get; set; }

        /// <summary>
        /// End times in seconds for each word.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WordTimestamps" /> class.
        /// </summary>
        /// <param name="words">
        /// List of words in order.
        /// </param>
        /// <param name="start">
        /// Start times in seconds for each word.
        /// </param>
        /// <param name="end">
        /// End times in seconds for each word.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WordTimestamps(
            global::System.Collections.Generic.IList<string> words,
            global::System.Collections.Generic.IList<double> start,
            global::System.Collections.Generic.IList<double> end)
        {
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
            this.Start = start ?? throw new global::System.ArgumentNullException(nameof(start));
            this.End = end ?? throw new global::System.ArgumentNullException(nameof(end));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordTimestamps" /> class.
        /// </summary>
        public WordTimestamps()
        {
        }
    }
}