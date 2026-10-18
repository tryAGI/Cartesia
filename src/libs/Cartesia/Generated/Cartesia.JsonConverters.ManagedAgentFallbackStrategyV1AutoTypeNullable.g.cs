#nullable enable

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class ManagedAgentFallbackStrategyV1AutoTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.ManagedAgentFallbackStrategyV1AutoType?>
    {
        /// <inheritdoc />
        public override global::Cartesia.ManagedAgentFallbackStrategyV1AutoType? Read(
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
                        return global::Cartesia.ManagedAgentFallbackStrategyV1AutoTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.ManagedAgentFallbackStrategyV1AutoType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.ManagedAgentFallbackStrategyV1AutoType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.ManagedAgentFallbackStrategyV1AutoType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Cartesia.ManagedAgentFallbackStrategyV1AutoTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
