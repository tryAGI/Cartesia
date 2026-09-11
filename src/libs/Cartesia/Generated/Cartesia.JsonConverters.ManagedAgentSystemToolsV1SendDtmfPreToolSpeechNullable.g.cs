#nullable enable

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class ManagedAgentSystemToolsV1SendDtmfPreToolSpeechNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.ManagedAgentSystemToolsV1SendDtmfPreToolSpeech?>
    {
        /// <inheritdoc />
        public override global::Cartesia.ManagedAgentSystemToolsV1SendDtmfPreToolSpeech? Read(
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
                        return global::Cartesia.ManagedAgentSystemToolsV1SendDtmfPreToolSpeechExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.ManagedAgentSystemToolsV1SendDtmfPreToolSpeech)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.ManagedAgentSystemToolsV1SendDtmfPreToolSpeech?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.ManagedAgentSystemToolsV1SendDtmfPreToolSpeech? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Cartesia.ManagedAgentSystemToolsV1SendDtmfPreToolSpeechExtensions.ToValueString(value.Value));
            }
        }
    }
}
