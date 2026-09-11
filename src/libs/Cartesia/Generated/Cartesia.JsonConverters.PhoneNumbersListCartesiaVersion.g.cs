#nullable enable

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class PhoneNumbersListCartesiaVersionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.PhoneNumbersListCartesiaVersion>
    {
        /// <inheritdoc />
        public override global::Cartesia.PhoneNumbersListCartesiaVersion Read(
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
                        return global::Cartesia.PhoneNumbersListCartesiaVersionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.PhoneNumbersListCartesiaVersion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.PhoneNumbersListCartesiaVersion);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.PhoneNumbersListCartesiaVersion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Cartesia.PhoneNumbersListCartesiaVersionExtensions.ToValueString(value));
        }
    }
}
