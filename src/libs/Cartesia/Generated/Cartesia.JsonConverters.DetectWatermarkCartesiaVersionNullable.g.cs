#nullable enable

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class DetectWatermarkCartesiaVersionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.DetectWatermarkCartesiaVersion?>
    {
        /// <inheritdoc />
        public override global::Cartesia.DetectWatermarkCartesiaVersion? Read(
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
                        return global::Cartesia.DetectWatermarkCartesiaVersionExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.DetectWatermarkCartesiaVersion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.DetectWatermarkCartesiaVersion?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.DetectWatermarkCartesiaVersion? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Cartesia.DetectWatermarkCartesiaVersionExtensions.ToValueString(value.Value));
            }
        }
    }
}
