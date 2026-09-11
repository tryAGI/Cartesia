
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// A pronunciation dictionary item mapping text to a custom pronunciation
    /// </summary>
    public sealed partial class PronunciationDictItem
    {
        /// <summary>
        /// The original text to be replaced
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// A phonetic representation or text to be said in place of the original text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pronunciation { get; set; }

        /// <summary>
        /// When false (default), match every capitalization of `text` on Sonic 3.6+. When true, a lowercase key also matches sentence-start capitalization (`cat`/`Cat`, not `CAT`).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("case_sensitive")]
        public bool? CaseSensitive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictItem" /> class.
        /// </summary>
        /// <param name="text">
        /// The original text to be replaced
        /// </param>
        /// <param name="pronunciation">
        /// A phonetic representation or text to be said in place of the original text
        /// </param>
        /// <param name="caseSensitive">
        /// When false (default), match every capitalization of `text` on Sonic 3.6+. When true, a lowercase key also matches sentence-start capitalization (`cat`/`Cat`, not `CAT`).<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PronunciationDictItem(
            string text,
            string pronunciation,
            bool? caseSensitive)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Pronunciation = pronunciation ?? throw new global::System.ArgumentNullException(nameof(pronunciation));
            this.CaseSensitive = caseSensitive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictItem" /> class.
        /// </summary>
        public PronunciationDictItem()
        {
        }

    }
}