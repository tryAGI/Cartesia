#nullable enable

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class ManagedAgentConfigV1AudioInputNoiseSuppressionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.ManagedAgentConfigV1AudioInputNoiseSuppression>
    {
        /// <inheritdoc />
        public override global::Cartesia.ManagedAgentConfigV1AudioInputNoiseSuppression Read(
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
                        return global::Cartesia.ManagedAgentConfigV1AudioInputNoiseSuppressionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.ManagedAgentConfigV1AudioInputNoiseSuppression)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.ManagedAgentConfigV1AudioInputNoiseSuppression);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.ManagedAgentConfigV1AudioInputNoiseSuppression value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Cartesia.ManagedAgentConfigV1AudioInputNoiseSuppressionExtensions.ToValueString(value));
        }
    }
}
