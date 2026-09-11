#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ManagedToolDefinitionV1 : global::System.IEquatable<ManagedToolDefinitionV1>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedToolDefinitionV1DiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.ManagedWebhookToolDefinitionV1? Webhook { get; init; }
#else
        public global::Cartesia.ManagedWebhookToolDefinitionV1? Webhook { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Webhook))]
#endif
        public bool IsWebhook => Webhook != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebhook(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.ManagedWebhookToolDefinitionV1? value)
        {
            value = Webhook;
            return IsWebhook;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedWebhookToolDefinitionV1 PickWebhook() => IsWebhook
            ? Webhook!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Webhook' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.ManagedClientToolDefinitionV1? Client { get; init; }
#else
        public global::Cartesia.ManagedClientToolDefinitionV1? Client { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Client))]
#endif
        public bool IsClient => Client != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickClient(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.ManagedClientToolDefinitionV1? value)
        {
            value = Client;
            return IsClient;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedClientToolDefinitionV1 PickClient() => IsClient
            ? Client!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Client' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ManagedToolDefinitionV1(global::Cartesia.ManagedWebhookToolDefinitionV1 value) => new ManagedToolDefinitionV1((global::Cartesia.ManagedWebhookToolDefinitionV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.ManagedWebhookToolDefinitionV1?(ManagedToolDefinitionV1 @this) => @this.Webhook;

        /// <summary>
        ///
        /// </summary>
        public ManagedToolDefinitionV1(global::Cartesia.ManagedWebhookToolDefinitionV1? value)
        {
            Webhook = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ManagedToolDefinitionV1 FromWebhook(global::Cartesia.ManagedWebhookToolDefinitionV1? value) => new ManagedToolDefinitionV1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ManagedToolDefinitionV1(global::Cartesia.ManagedClientToolDefinitionV1 value) => new ManagedToolDefinitionV1((global::Cartesia.ManagedClientToolDefinitionV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.ManagedClientToolDefinitionV1?(ManagedToolDefinitionV1 @this) => @this.Client;

        /// <summary>
        ///
        /// </summary>
        public ManagedToolDefinitionV1(global::Cartesia.ManagedClientToolDefinitionV1? value)
        {
            Client = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ManagedToolDefinitionV1 FromClient(global::Cartesia.ManagedClientToolDefinitionV1? value) => new ManagedToolDefinitionV1(value);

        /// <summary>
        ///
        /// </summary>
        public ManagedToolDefinitionV1(
            global::Cartesia.ManagedToolDefinitionV1DiscriminatorType? type,
            global::Cartesia.ManagedWebhookToolDefinitionV1? webhook,
            global::Cartesia.ManagedClientToolDefinitionV1? client
            )
        {
            Type = type;

            Webhook = webhook;
            Client = client;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Client as object ??
            Webhook as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Webhook?.ToString() ??
            Client?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsWebhook && !IsClient || !IsWebhook && IsClient;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.ManagedWebhookToolDefinitionV1, TResult>? webhook = null,
            global::System.Func<global::Cartesia.ManagedClientToolDefinitionV1, TResult>? client = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhook && webhook != null)
            {
                return webhook(Webhook!);
            }
            else if (IsClient && client != null)
            {
                return client(Client!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Cartesia.ManagedWebhookToolDefinitionV1>? webhook = null,

            global::System.Action<global::Cartesia.ManagedClientToolDefinitionV1>? client = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhook)
            {
                webhook?.Invoke(Webhook!);
            }
            else if (IsClient)
            {
                client?.Invoke(Client!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Cartesia.ManagedWebhookToolDefinitionV1>? webhook = null,
            global::System.Action<global::Cartesia.ManagedClientToolDefinitionV1>? client = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhook)
            {
                webhook?.Invoke(Webhook!);
            }
            else if (IsClient)
            {
                client?.Invoke(Client!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Webhook,
                typeof(global::Cartesia.ManagedWebhookToolDefinitionV1),
                Client,
                typeof(global::Cartesia.ManagedClientToolDefinitionV1),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ManagedToolDefinitionV1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.ManagedWebhookToolDefinitionV1?>.Default.Equals(Webhook, other.Webhook) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.ManagedClientToolDefinitionV1?>.Default.Equals(Client, other.Client)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ManagedToolDefinitionV1 obj1, ManagedToolDefinitionV1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ManagedToolDefinitionV1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ManagedToolDefinitionV1 obj1, ManagedToolDefinitionV1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ManagedToolDefinitionV1 o && Equals(o);
        }
    }
}
