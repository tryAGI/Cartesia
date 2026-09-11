#nullable enable

namespace Cartesia.Realtime.TextToSpeech.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerationRequestLocaleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.Realtime.TextToSpeech.GenerationRequestLocale?>
    {
        /// <inheritdoc />
        public override global::Cartesia.Realtime.TextToSpeech.GenerationRequestLocale? Read(
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
                        return global::Cartesia.Realtime.TextToSpeech.GenerationRequestLocaleExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.Realtime.TextToSpeech.GenerationRequestLocale)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.Realtime.TextToSpeech.GenerationRequestLocale?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.Realtime.TextToSpeech.GenerationRequestLocale? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Cartesia.Realtime.TextToSpeech.GenerationRequestLocaleExtensions.ToValueString(value.Value));
            }
        }
    }
}
