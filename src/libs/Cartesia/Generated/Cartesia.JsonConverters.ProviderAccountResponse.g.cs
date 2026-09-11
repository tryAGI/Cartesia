#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public class ProviderAccountResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.ProviderAccountResponse>
    {
        /// <inheritdoc />
        public override global::Cartesia.ProviderAccountResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.ProviderAccountResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.ProviderAccountResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.ProviderAccountResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cartesia.TwilioProviderResponse? twilio = default;
            if (discriminator?.Type == global::Cartesia.ProviderAccountResponseDiscriminatorType.Twilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.TwilioProviderResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.TwilioProviderResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.TwilioProviderResponse)}");
                twilio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.SIPTrunkProviderResponse? sipTrunk = default;
            if (discriminator?.Type == global::Cartesia.ProviderAccountResponseDiscriminatorType.SipTrunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.SIPTrunkProviderResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.SIPTrunkProviderResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.SIPTrunkProviderResponse)}");
                sipTrunk = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Cartesia.ProviderAccountResponse(
                discriminator?.Type,
                twilio,

                sipTrunk
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.ProviderAccountResponse value,
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
            else if (value.IsSipTrunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.SIPTrunkProviderResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.SIPTrunkProviderResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.SIPTrunkProviderResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipTrunk!, typeInfo);
            }
        }
    }
}