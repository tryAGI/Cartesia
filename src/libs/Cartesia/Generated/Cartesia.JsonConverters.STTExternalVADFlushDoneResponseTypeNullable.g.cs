#nullable enable

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class STTExternalVADFlushDoneResponseTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.STTExternalVADFlushDoneResponseType?>
    {
        /// <inheritdoc />
        public override global::Cartesia.STTExternalVADFlushDoneResponseType? Read(
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
                        return global::Cartesia.STTExternalVADFlushDoneResponseTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.STTExternalVADFlushDoneResponseType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.STTExternalVADFlushDoneResponseType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.STTExternalVADFlushDoneResponseType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Cartesia.STTExternalVADFlushDoneResponseTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
