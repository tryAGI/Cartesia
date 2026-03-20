#nullable enable

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class OutputFormatMP3OutputFormatContainerNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.OutputFormatMP3OutputFormatContainer?>
    {
        /// <inheritdoc />
        public override global::Cartesia.OutputFormatMP3OutputFormatContainer? Read(
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
                        return global::Cartesia.OutputFormatMP3OutputFormatContainerExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.OutputFormatMP3OutputFormatContainer)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.OutputFormatMP3OutputFormatContainer?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.OutputFormatMP3OutputFormatContainer? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Cartesia.OutputFormatMP3OutputFormatContainerExtensions.ToValueString(value.Value));
            }
        }
    }
}
