#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia.JsonConverters
{
    /// <inheritdoc />
    public class ManagedToolV1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cartesia.ManagedToolV1>
    {
        /// <inheritdoc />
        public override global::Cartesia.ManagedToolV1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.ManagedToolV1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.ManagedToolV1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.ManagedToolV1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cartesia.ManagedWebhookToolV1? webhook = default;
            if (discriminator?.Type == global::Cartesia.ManagedToolV1DiscriminatorType.Webhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.ManagedWebhookToolV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.ManagedWebhookToolV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.ManagedWebhookToolV1)}");
                webhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cartesia.ManagedClientToolV1? client = default;
            if (discriminator?.Type == global::Cartesia.ManagedToolV1DiscriminatorType.Client)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.ManagedClientToolV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.ManagedClientToolV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cartesia.ManagedClientToolV1)}");
                client = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Cartesia.ManagedToolV1(
                discriminator?.Type,
                webhook,

                client
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cartesia.ManagedToolV1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.ManagedWebhookToolV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.ManagedWebhookToolV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.ManagedWebhookToolV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Webhook!, typeInfo);
            }
            else if (value.IsClient)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cartesia.ManagedClientToolV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cartesia.ManagedClientToolV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cartesia.ManagedClientToolV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Client!, typeInfo);
            }
        }
    }
}