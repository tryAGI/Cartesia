#nullable enable

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateSIPProviderBodyTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.CreateSIPProviderBodyType?>
    {
        /// <inheritdoc />
        public override global::Cartesia.CreateSIPProviderBodyType? Read(
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
                        return global::Cartesia.CreateSIPProviderBodyTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.CreateSIPProviderBodyType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.CreateSIPProviderBodyType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.CreateSIPProviderBodyType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Cartesia.CreateSIPProviderBodyTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
