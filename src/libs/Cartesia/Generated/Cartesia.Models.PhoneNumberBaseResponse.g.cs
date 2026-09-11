
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Common phone number fields.
    /// </summary>
    public sealed partial class PhoneNumberBaseResponse
    {
        /// <summary>
        /// Unique identifier for the phone number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A human-readable name for the phone number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// The phone number in E.164 format (e.g. +14155551234).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Number { get; set; }

        /// <summary>
        /// The agent that answers inbound calls to this number, or `null` if unassigned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::Cartesia.PhoneNumberBaseResponseAgent? Agent { get; set; }

        /// <summary>
        /// UTC timestamp when the phone number was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// UTC timestamp when the phone number was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberBaseResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the phone number.
        /// </param>
        /// <param name="number">
        /// The phone number in E.164 format (e.g. +14155551234).
        /// </param>
        /// <param name="createdAt">
        /// UTC timestamp when the phone number was created.
        /// </param>
        /// <param name="updatedAt">
        /// UTC timestamp when the phone number was last updated.
        /// </param>
        /// <param name="label">
        /// A human-readable name for the phone number.
        /// </param>
        /// <param name="agent">
        /// The agent that answers inbound calls to this number, or `null` if unassigned
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumberBaseResponse(
            string id,
            string number,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? label,
            global::Cartesia.PhoneNumberBaseResponseAgent? agent)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Label = label;
            this.Number = number ?? throw new global::System.ArgumentNullException(nameof(number));
            this.Agent = agent;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberBaseResponse" /> class.
        /// </summary>
        public PhoneNumberBaseResponse()
        {
        }

    }
}