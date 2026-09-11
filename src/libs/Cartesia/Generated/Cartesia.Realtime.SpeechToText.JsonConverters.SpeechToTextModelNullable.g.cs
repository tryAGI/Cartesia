#nullable enable

namespace Cartesia.Realtime.SpeechToText.JsonConverters
{
    /// <inheritdoc />
    public sealed class SpeechToTextModelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.Realtime.SpeechToText.SpeechToTextModel?>
    {
        /// <inheritdoc />
        public override global::Cartesia.Realtime.SpeechToText.SpeechToTextModel? Read(
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
                        return global::Cartesia.Realtime.SpeechToText.SpeechToTextModelExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.Realtime.SpeechToText.SpeechToTextModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.Realtime.SpeechToText.SpeechToTextModel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.Realtime.SpeechToText.SpeechToTextModel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Cartesia.Realtime.SpeechToText.SpeechToTextModelExtensions.ToValueString(value.Value));
            }
        }
    }
}
