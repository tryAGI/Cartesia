#nullable enable

namespace Cartesia.Realtime.SpeechToTextTurns.JsonConverters
{
    /// <inheritdoc />
    public sealed class SpeechToTextTurnsEncodingNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.Realtime.SpeechToTextTurns.SpeechToTextTurnsEncoding?>
    {
        /// <inheritdoc />
        public override global::Cartesia.Realtime.SpeechToTextTurns.SpeechToTextTurnsEncoding? Read(
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
                        return global::Cartesia.Realtime.SpeechToTextTurns.SpeechToTextTurnsEncodingExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.Realtime.SpeechToTextTurns.SpeechToTextTurnsEncoding)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.Realtime.SpeechToTextTurns.SpeechToTextTurnsEncoding?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.Realtime.SpeechToTextTurns.SpeechToTextTurnsEncoding? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Cartesia.Realtime.SpeechToTextTurns.SpeechToTextTurnsEncodingExtensions.ToValueString(value.Value));
            }
        }
    }
}
