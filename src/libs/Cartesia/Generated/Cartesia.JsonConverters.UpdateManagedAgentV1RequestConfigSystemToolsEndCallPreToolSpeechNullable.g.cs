#nullable enable

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeechNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech?>
    {
        /// <inheritdoc />
        public override global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech? Read(
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
                        return global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeechExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeech? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Cartesia.UpdateManagedAgentV1RequestConfigSystemToolsEndCallPreToolSpeechExtensions.ToValueString(value.Value));
            }
        }
    }
}
