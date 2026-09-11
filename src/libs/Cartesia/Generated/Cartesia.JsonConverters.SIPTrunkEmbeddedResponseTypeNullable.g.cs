#nullable enable

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class SIPTrunkEmbeddedResponseTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.SIPTrunkEmbeddedResponseType?>
    {
        /// <inheritdoc />
        public override global::Cartesia.SIPTrunkEmbeddedResponseType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Cartesia.SIPTrunkEmbeddedResponseTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.SIPTrunkEmbeddedResponseType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.SIPTrunkEmbeddedResponseType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.SIPTrunkEmbeddedResponseType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Cartesia.SIPTrunkEmbeddedResponseTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
