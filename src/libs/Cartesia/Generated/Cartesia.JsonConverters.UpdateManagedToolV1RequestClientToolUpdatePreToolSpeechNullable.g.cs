#nullable enable

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateManagedToolV1RequestClientToolUpdatePreToolSpeechNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech?>
    {
        /// <inheritdoc />
        public override global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech? Read(
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
                        return global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeechExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeech? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdatePreToolSpeechExtensions.ToValueString(value.Value));
            }
        }
    }
}
