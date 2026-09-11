#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct UpdateManagedToolV1Request : global::System.IEquatable<UpdateManagedToolV1Request>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdate? WebhookToolUpdate { get; init; }
#else
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdate? WebhookToolUpdate { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookToolUpdate))]
#endif
        public bool IsWebhookToolUpdate => WebhookToolUpdate != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebhookToolUpdate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdate? value)
        {
            value = WebhookToolUpdate;
            return IsWebhookToolUpdate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdate PickWebhookToolUpdate() => IsWebhookToolUpdate
            ? WebhookToolUpdate!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebhookToolUpdate' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.UpdateManagedToolV1RequestClientToolUpdate? ClientToolUpdate { get; init; }
#else
        public global::Cartesia.UpdateManagedToolV1RequestClientToolUpdate? ClientToolUpdate { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClientToolUpdate))]
#endif
        public bool IsClientToolUpdate => ClientToolUpdate != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickClientToolUpdate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.UpdateManagedToolV1RequestClientToolUpdate? value)
        {
            value = ClientToolUpdate;
            return IsClientToolUpdate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateManagedToolV1RequestClientToolUpdate PickClientToolUpdate() => IsClientToolUpdate
            ? ClientToolUpdate!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ClientToolUpdate' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateManagedToolV1Request(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdate value) => new UpdateManagedToolV1Request((global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdate?(UpdateManagedToolV1Request @this) => @this.WebhookToolUpdate;

        /// <summary>
        ///
        /// </summary>
        public UpdateManagedToolV1Request(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdate? value)
        {
            WebhookToolUpdate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateManagedToolV1Request FromWebhookToolUpdate(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdate? value) => new UpdateManagedToolV1Request(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateManagedToolV1Request(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdate value) => new UpdateManagedToolV1Request((global::Cartesia.UpdateManagedToolV1RequestClientToolUpdate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.UpdateManagedToolV1RequestClientToolUpdate?(UpdateManagedToolV1Request @this) => @this.ClientToolUpdate;

        /// <summary>
        ///
        /// </summary>
        public UpdateManagedToolV1Request(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdate? value)
        {
            ClientToolUpdate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateManagedToolV1Request FromClientToolUpdate(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdate? value) => new UpdateManagedToolV1Request(value);

        /// <summary>
        ///
        /// </summary>
        public UpdateManagedToolV1Request(
            global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdate? webhookToolUpdate,
            global::Cartesia.UpdateManagedToolV1RequestClientToolUpdate? clientToolUpdate
            )
        {
            WebhookToolUpdate = webhookToolUpdate;
            ClientToolUpdate = clientToolUpdate;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ClientToolUpdate as object ??
            WebhookToolUpdate as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            WebhookToolUpdate?.ToString() ??
            ClientToolUpdate?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsWebhookToolUpdate || IsClientToolUpdate;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdate, TResult>? webhookToolUpdate = null,
            global::System.Func<global::Cartesia.UpdateManagedToolV1RequestClientToolUpdate, TResult>? clientToolUpdate = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhookToolUpdate && webhookToolUpdate != null)
            {
                return webhookToolUpdate(WebhookToolUpdate!);
            }
            else if (IsClientToolUpdate && clientToolUpdate != null)
            {
                return clientToolUpdate(ClientToolUpdate!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdate>? webhookToolUpdate = null,

            global::System.Action<global::Cartesia.UpdateManagedToolV1RequestClientToolUpdate>? clientToolUpdate = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhookToolUpdate)
            {
                webhookToolUpdate?.Invoke(WebhookToolUpdate!);
            }
            else if (IsClientToolUpdate)
            {
                clientToolUpdate?.Invoke(ClientToolUpdate!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdate>? webhookToolUpdate = null,
            global::System.Action<global::Cartesia.UpdateManagedToolV1RequestClientToolUpdate>? clientToolUpdate = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhookToolUpdate)
            {
                webhookToolUpdate?.Invoke(WebhookToolUpdate!);
            }
            else if (IsClientToolUpdate)
            {
                clientToolUpdate?.Invoke(ClientToolUpdate!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WebhookToolUpdate,
                typeof(global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdate),
                ClientToolUpdate,
                typeof(global::Cartesia.UpdateManagedToolV1RequestClientToolUpdate),
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
        public bool Equals(UpdateManagedToolV1Request other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.UpdateManagedToolV1RequestWebhookToolUpdate?>.Default.Equals(WebhookToolUpdate, other.WebhookToolUpdate) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.UpdateManagedToolV1RequestClientToolUpdate?>.Default.Equals(ClientToolUpdate, other.ClientToolUpdate)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UpdateManagedToolV1Request obj1, UpdateManagedToolV1Request obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateManagedToolV1Request>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UpdateManagedToolV1Request obj1, UpdateManagedToolV1Request obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateManagedToolV1Request o && Equals(o);
        }
    }
}
