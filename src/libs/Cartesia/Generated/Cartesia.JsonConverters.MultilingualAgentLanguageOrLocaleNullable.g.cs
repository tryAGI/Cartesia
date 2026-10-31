#nullable enable

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class MultilingualAgentLanguageOrLocaleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.MultilingualAgentLanguageOrLocale?>
    {
        /// <inheritdoc />
        public override global::Cartesia.MultilingualAgentLanguageOrLocale? Read(
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
                        return global::Cartesia.MultilingualAgentLanguageOrLocaleExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.MultilingualAgentLanguageOrLocale)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.MultilingualAgentLanguageOrLocale?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.MultilingualAgentLanguageOrLocale? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Cartesia.MultilingualAgentLanguageOrLocaleExtensions.ToValueString(value.Value));
            }
        }
    }
}
