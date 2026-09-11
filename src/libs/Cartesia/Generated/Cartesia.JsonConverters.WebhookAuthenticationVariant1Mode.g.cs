#nullable enable

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookAuthenticationVariant1ModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.WebhookAuthenticationVariant1Mode>
    {
        /// <inheritdoc />
        public override global::Cartesia.WebhookAuthenticationVariant1Mode Read(
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
                        return global::Cartesia.WebhookAuthenticationVariant1ModeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.WebhookAuthenticationVariant1Mode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.WebhookAuthenticationVariant1Mode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.WebhookAuthenticationVariant1Mode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Cartesia.WebhookAuthenticationVariant1ModeExtensions.ToValueString(value));
        }
    }
}
