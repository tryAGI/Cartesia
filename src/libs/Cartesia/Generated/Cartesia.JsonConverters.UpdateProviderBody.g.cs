#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public class UpdateProviderBodyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.UpdateProviderBody>
    {
        /// <inheritdoc />
        public override global::Cartesia.UpdateProviderBody Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.UpdateProviderBodyDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.UpdateProviderBodyDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.UpdateProviderBodyDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cartesia.UpdateTwilioProviderBody? twilio = default;
            if (discriminator?.Type == global::Cartesia.UpdateProviderBodyDiscriminatorType.Twilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.UpdateTwilioProviderBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.UpdateTwilioProviderBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.UpdateTwilioProviderBody)}");
                twilio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.UpdateSIPTrunkProviderBody? sipTrunk = default;
            if (discriminator?.Type == global::Cartesia.UpdateProviderBodyDiscriminatorType.SipTrunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.UpdateSIPTrunkProviderBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.UpdateSIPTrunkProviderBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.UpdateSIPTrunkProviderBody)}");
                sipTrunk = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Cartesia.UpdateProviderBody(
                discriminator?.Type,
                twilio,

                sipTrunk
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.UpdateProviderBody value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTwilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.UpdateTwilioProviderBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.UpdateTwilioProviderBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.UpdateTwilioProviderBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio!, typeInfo);
            }
            else if (value.IsSipTrunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.UpdateSIPTrunkProviderBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.UpdateSIPTrunkProviderBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.UpdateSIPTrunkProviderBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipTrunk!, typeInfo);
            }
        }
    }
}