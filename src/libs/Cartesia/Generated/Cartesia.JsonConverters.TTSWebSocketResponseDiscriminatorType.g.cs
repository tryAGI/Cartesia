#nullable enable

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class TTSWebSocketResponseDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.TTSWebSocketResponseDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::Cartesia.TTSWebSocketResponseDiscriminatorType Read(
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
                        return global::Cartesia.TTSWebSocketResponseDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.TTSWebSocketResponseDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.TTSWebSocketResponseDiscriminatorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.TTSWebSocketResponseDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Cartesia.TTSWebSocketResponseDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
