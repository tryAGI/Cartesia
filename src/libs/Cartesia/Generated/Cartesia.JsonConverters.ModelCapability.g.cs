#nullable enable

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class ModelCapabilityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.ModelCapability>
    {
        /// <inheritdoc />
        public override global::Cartesia.ModelCapability Read(
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
                        return global::Cartesia.ModelCapabilityExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.ModelCapability)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.ModelCapability);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.ModelCapability value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Cartesia.ModelCapabilityExtensions.ToValueString(value));
        }
    }
}
