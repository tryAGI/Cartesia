#nullable enable

namespace Cartesia.Realtime.TextToSpeech.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerationRequestOutputFormatEncodingJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.Realtime.TextToSpeech.GenerationRequestOutputFormatEncoding>
    {
        /// <inheritdoc />
        public override global::Cartesia.Realtime.TextToSpeech.GenerationRequestOutputFormatEncoding Read(
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
                        return global::Cartesia.Realtime.TextToSpeech.GenerationRequestOutputFormatEncodingExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.Realtime.TextToSpeech.GenerationRequestOutputFormatEncoding)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.Realtime.TextToSpeech.GenerationRequestOutputFormatEncoding);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.Realtime.TextToSpeech.GenerationRequestOutputFormatEncoding value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Cartesia.Realtime.TextToSpeech.GenerationRequestOutputFormatEncodingExtensions.ToValueString(value));
        }
    }
}
