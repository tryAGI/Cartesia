#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public class ProviderResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.ProviderResponse>
    {
        /// <inheritdoc />
        public override global::Cartesia.ProviderResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.ProviderResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.ProviderResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.ProviderResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cartesia.TwilioProviderResponse? twilio = default;
            if (discriminator?.Type == global::Cartesia.ProviderResponseDiscriminatorType.Twilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TwilioProviderResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TwilioProviderResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.TwilioProviderResponse)}");
                twilio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.CartesiaProviderResponse? cartesia = default;
            if (discriminator?.Type == global::Cartesia.ProviderResponseDiscriminatorType.Cartesia)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.CartesiaProviderResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.CartesiaProviderResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.CartesiaProviderResponse)}");
                cartesia = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.SIPTrunkEmbeddedResponse? sipTrunk = default;
            if (discriminator?.Type == global::Cartesia.ProviderResponseDiscriminatorType.SipTrunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.SIPTrunkEmbeddedResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.SIPTrunkEmbeddedResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.SIPTrunkEmbeddedResponse)}");
                sipTrunk = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Cartesia.ProviderResponse(
                discriminator?.Type,
                twilio,

                cartesia,

                sipTrunk
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.ProviderResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTwilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TwilioProviderResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TwilioProviderResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.TwilioProviderResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio!, typeInfo);
            }
            else if (value.IsCartesia)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.CartesiaProviderResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.CartesiaProviderResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.CartesiaProviderResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cartesia!, typeInfo);
            }
            else if (value.IsSipTrunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.SIPTrunkEmbeddedResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.SIPTrunkEmbeddedResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.SIPTrunkEmbeddedResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipTrunk!, typeInfo);
            }
        }
    }
}