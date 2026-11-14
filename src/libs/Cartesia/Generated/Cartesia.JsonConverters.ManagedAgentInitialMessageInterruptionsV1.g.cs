#nullable enable

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class ManagedAgentInitialMessageInterruptionsV1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.ManagedAgentInitialMessageInterruptionsV1>
    {
        /// <inheritdoc />
        public override global::Cartesia.ManagedAgentInitialMessageInterruptionsV1 Read(
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
                        return global::Cartesia.ManagedAgentInitialMessageInterruptionsV1Extensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cartesia.ManagedAgentInitialMessageInterruptionsV1)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cartesia.ManagedAgentInitialMessageInterruptionsV1);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.ManagedAgentInitialMessageInterruptionsV1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Cartesia.ManagedAgentInitialMessageInterruptionsV1Extensions.ToValueString(value));
        }
    }
}
