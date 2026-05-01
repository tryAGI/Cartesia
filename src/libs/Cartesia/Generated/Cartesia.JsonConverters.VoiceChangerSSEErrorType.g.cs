#nullable enable

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class VoiceChangerSSEErrorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.VoiceChangerSSEErrorType>
    {
        /// <inheritdoc />
        public override global::Cartesia.VoiceChangerSSEErrorType Read(
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
                        return global::Cartesia.VoiceChangerSSEErrorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.VoiceChangerSSEErrorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.VoiceChangerSSEErrorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.VoiceChangerSSEErrorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Cartesia.VoiceChangerSSEErrorTypeExtensions.ToValueString(value));
        }
    }
}
