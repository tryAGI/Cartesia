#nullable enable

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class UsageConcurrencyCartesiaVersionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.UsageConcurrencyCartesiaVersion?>
    {
        /// <inheritdoc />
        public override global::Cartesia.UsageConcurrencyCartesiaVersion? Read(
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
                        return global::Cartesia.UsageConcurrencyCartesiaVersionExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.UsageConcurrencyCartesiaVersion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.UsageConcurrencyCartesiaVersion?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.UsageConcurrencyCartesiaVersion? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Cartesia.UsageConcurrencyCartesiaVersionExtensions.ToValueString(value.Value));
            }
        }
    }
}
