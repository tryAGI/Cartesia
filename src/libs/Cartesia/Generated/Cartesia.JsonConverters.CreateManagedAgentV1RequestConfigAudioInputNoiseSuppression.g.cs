#nullable enable

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateManagedAgentV1RequestConfigAudioInputNoiseSuppressionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression>
    {
        /// <inheritdoc />
        public override global::Cartesia.CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression Read(
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
                        return global::Cartesia.CreateManagedAgentV1RequestConfigAudioInputNoiseSuppressionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.CreateManagedAgentV1RequestConfigAudioInputNoiseSuppression value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Cartesia.CreateManagedAgentV1RequestConfigAudioInputNoiseSuppressionExtensions.ToValueString(value));
        }
    }
}
