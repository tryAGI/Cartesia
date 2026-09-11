#nullable enable

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class ManagedWebhookToolV1ExecutionModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.ManagedWebhookToolV1ExecutionMode?>
    {
        /// <inheritdoc />
        public override global::Cartesia.ManagedWebhookToolV1ExecutionMode? Read(
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
                        return global::Cartesia.ManagedWebhookToolV1ExecutionModeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.ManagedWebhookToolV1ExecutionMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.ManagedWebhookToolV1ExecutionMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.ManagedWebhookToolV1ExecutionMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Cartesia.ManagedWebhookToolV1ExecutionModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
