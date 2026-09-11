#nullable enable

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetV1AgentsByAgentIdVersionsCartesiaVersionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.GetV1AgentsByAgentIdVersionsCartesiaVersion>
    {
        /// <inheritdoc />
        public override global::Cartesia.GetV1AgentsByAgentIdVersionsCartesiaVersion Read(
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
                        return global::Cartesia.GetV1AgentsByAgentIdVersionsCartesiaVersionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.GetV1AgentsByAgentIdVersionsCartesiaVersion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.GetV1AgentsByAgentIdVersionsCartesiaVersion);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.GetV1AgentsByAgentIdVersionsCartesiaVersion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Cartesia.GetV1AgentsByAgentIdVersionsCartesiaVersionExtensions.ToValueString(value));
        }
    }
}
