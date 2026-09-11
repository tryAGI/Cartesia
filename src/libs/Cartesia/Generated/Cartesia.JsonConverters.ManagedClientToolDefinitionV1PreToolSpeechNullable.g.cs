#nullable enable

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class ManagedClientToolDefinitionV1PreToolSpeechNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeech?>
    {
        /// <inheritdoc />
        public override global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeech? Read(
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
                        return global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeechExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeech)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeech?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeech? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Cartesia.ManagedClientToolDefinitionV1PreToolSpeechExtensions.ToValueString(value.Value));
            }
        }
    }
}
