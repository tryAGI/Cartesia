#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Request body for updating a provider. Discriminated by `type`.
    /// </summary>
    public readonly partial struct UpdateProviderBody : global::System.IEquatable<UpdateProviderBody>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateProviderBodyDiscriminatorType? Type { get; }

        /// <summary>
        /// Update Twilio API key credentials and optionally the region. Credentials are validated before applying. If phone numbers using this provider cannot be verified with the new credentials, the update is rejected with a list of unreachable numbers.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.UpdateTwilioProviderBody? Twilio { get; init; }
#else
        public global::Cartesia.UpdateTwilioProviderBody? Twilio { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Twilio))]
#endif
        public bool IsTwilio => Twilio != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTwilio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.UpdateTwilioProviderBody? value)
        {
            value = Twilio;
            return IsTwilio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateTwilioProviderBody PickTwilio() => IsTwilio
            ? Twilio!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Twilio' but the value was {ToString()}.");

        /// <summary>
        /// Update a SIP trunk provider's inbound and/or outbound configuration. Merge-patch semantics: omitted fields are unchanged. To add outbound to an inbound-only provider, send `outbound` with both `address` and `transport`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.UpdateSIPTrunkProviderBody? SipTrunk { get; init; }
#else
        public global::Cartesia.UpdateSIPTrunkProviderBody? SipTrunk { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SipTrunk))]
#endif
        public bool IsSipTrunk => SipTrunk != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSipTrunk(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.UpdateSIPTrunkProviderBody? value)
        {
            value = SipTrunk;
            return IsSipTrunk;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.UpdateSIPTrunkProviderBody PickSipTrunk() => IsSipTrunk
            ? SipTrunk!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SipTrunk' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateProviderBody(global::Cartesia.UpdateTwilioProviderBody value) => new UpdateProviderBody((global::Cartesia.UpdateTwilioProviderBody?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.UpdateTwilioProviderBody?(UpdateProviderBody @this) => @this.Twilio;

        /// <summary>
        ///
        /// </summary>
        public UpdateProviderBody(global::Cartesia.UpdateTwilioProviderBody? value)
        {
            Twilio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateProviderBody FromTwilio(global::Cartesia.UpdateTwilioProviderBody? value) => new UpdateProviderBody(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateProviderBody(global::Cartesia.UpdateSIPTrunkProviderBody value) => new UpdateProviderBody((global::Cartesia.UpdateSIPTrunkProviderBody?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.UpdateSIPTrunkProviderBody?(UpdateProviderBody @this) => @this.SipTrunk;

        /// <summary>
        ///
        /// </summary>
        public UpdateProviderBody(global::Cartesia.UpdateSIPTrunkProviderBody? value)
        {
            SipTrunk = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateProviderBody FromSipTrunk(global::Cartesia.UpdateSIPTrunkProviderBody? value) => new UpdateProviderBody(value);

        /// <summary>
        ///
        /// </summary>
        public UpdateProviderBody(
            global::Cartesia.UpdateProviderBodyDiscriminatorType? type,
            global::Cartesia.UpdateTwilioProviderBody? twilio,
            global::Cartesia.UpdateSIPTrunkProviderBody? sipTrunk
            )
        {
            Type = type;

            Twilio = twilio;
            SipTrunk = sipTrunk;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SipTrunk as object ??
            Twilio as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Twilio?.ToString() ??
            SipTrunk?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTwilio && !IsSipTrunk || !IsTwilio && IsSipTrunk;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.UpdateTwilioProviderBody, TResult>? twilio = null,
            global::System.Func<global::Cartesia.UpdateSIPTrunkProviderBody, TResult>? sipTrunk = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTwilio && twilio != null)
            {
                return twilio(Twilio!);
            }
            else if (IsSipTrunk && sipTrunk != null)
            {
                return sipTrunk(SipTrunk!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Cartesia.UpdateTwilioProviderBody>? twilio = null,

            global::System.Action<global::Cartesia.UpdateSIPTrunkProviderBody>? sipTrunk = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTwilio)
            {
                twilio?.Invoke(Twilio!);
            }
            else if (IsSipTrunk)
            {
                sipTrunk?.Invoke(SipTrunk!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Cartesia.UpdateTwilioProviderBody>? twilio = null,
            global::System.Action<global::Cartesia.UpdateSIPTrunkProviderBody>? sipTrunk = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTwilio)
            {
                twilio?.Invoke(Twilio!);
            }
            else if (IsSipTrunk)
            {
                sipTrunk?.Invoke(SipTrunk!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Twilio,
                typeof(global::Cartesia.UpdateTwilioProviderBody),
                SipTrunk,
                typeof(global::Cartesia.UpdateSIPTrunkProviderBody),
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
        public bool Equals(UpdateProviderBody other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.UpdateTwilioProviderBody?>.Default.Equals(Twilio, other.Twilio) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.UpdateSIPTrunkProviderBody?>.Default.Equals(SipTrunk, other.SipTrunk)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UpdateProviderBody obj1, UpdateProviderBody obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateProviderBody>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UpdateProviderBody obj1, UpdateProviderBody obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateProviderBody o && Equals(o);
        }
    }
}
