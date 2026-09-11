#nullable enable

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class DeleteV1AgentsToolsByToolIdCartesiaVersionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion>
    {
        /// <inheritdoc />
        public override global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion Read(
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
                        return global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Cartesia.DeleteV1AgentsToolsByToolIdCartesiaVersionExtensions.ToValueString(value));
        }
    }
}
