#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public class CreateProviderBodyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.CreateProviderBody>
    {
        /// <inheritdoc />
        public override global::Cartesia.CreateProviderBody Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.CreateProviderBodyDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.CreateProviderBodyDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.CreateProviderBodyDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cartesia.CreateTwilioProviderBody? twilio = default;
            if (discriminator?.Type == global::Cartesia.CreateProviderBodyDiscriminatorType.Twilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.CreateTwilioProviderBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.CreateTwilioProviderBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.CreateTwilioProviderBody)}");
                twilio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.CreateSIPProviderBody? sipTrunk = default;
            if (discriminator?.Type == global::Cartesia.CreateProviderBodyDiscriminatorType.SipTrunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.CreateSIPProviderBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.CreateSIPProviderBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.CreateSIPProviderBody)}");
                sipTrunk = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Cartesia.CreateProviderBody(
                discriminator?.Type,
                twilio,

                sipTrunk
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.CreateProviderBody value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTwilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.CreateTwilioProviderBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.CreateTwilioProviderBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.CreateTwilioProviderBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio!, typeInfo);
            }
            else if (value.IsSipTrunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.CreateSIPProviderBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.CreateSIPProviderBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.CreateSIPProviderBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipTrunk!, typeInfo);
            }
        }
    }
}