#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The voice to use for generation. Pass either a voice ID string or an object with a required `id` (additional object fields may be added in future API versions). Find a voice in the [Voice Library](https://play.cartesia.ai/voices) or via [List Voices](/api-reference/voices/list). Embeddings are not accepted in this API version.
    /// </summary>
    public readonly partial struct TTSRequestVoiceSpecifier : global::System.IEquatable<TTSRequestVoiceSpecifier>
    {
        /// <summary>
        /// The ID of the voice.<br/>
        /// Example: db6b0ed5-d5d3-463d-ae85-518a07d3c2b4
        /// </summary>
#if NET6_0_OR_GREATER
        public string? TTSRequestVoiceId { get; init; }
#else
        public string? TTSRequestVoiceId { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TTSRequestVoiceId))]
#endif
        public bool IsTTSRequestVoiceId => TTSRequestVoiceId != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTTSRequestVoiceId(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = TTSRequestVoiceId;
            return IsTTSRequestVoiceId;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickTTSRequestVoiceId() => IsTTSRequestVoiceId
            ? TTSRequestVoiceId!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TTSRequestVoiceId' but the value was {ToString()}.");

        /// <summary>
        /// Voice object. `id` is required; other fields may be added in future API versions.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.TTSRequestVoiceSpecifierTTSRequestVoiceObject? TTSRequestVoiceObject { get; init; }
#else
        public global::Cartesia.TTSRequestVoiceSpecifierTTSRequestVoiceObject? TTSRequestVoiceObject { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TTSRequestVoiceObject))]
#endif
        public bool IsTTSRequestVoiceObject => TTSRequestVoiceObject != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTTSRequestVoiceObject(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.TTSRequestVoiceSpecifierTTSRequestVoiceObject? value)
        {
            value = TTSRequestVoiceObject;
            return IsTTSRequestVoiceObject;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TTSRequestVoiceSpecifierTTSRequestVoiceObject PickTTSRequestVoiceObject() => IsTTSRequestVoiceObject
            ? TTSRequestVoiceObject!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TTSRequestVoiceObject' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TTSRequestVoiceSpecifier(string value) => new TTSRequestVoiceSpecifier((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(TTSRequestVoiceSpecifier @this) => @this.TTSRequestVoiceId;

        /// <summary>
        ///
        /// </summary>
        public TTSRequestVoiceSpecifier(string? value)
        {
            TTSRequestVoiceId = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TTSRequestVoiceSpecifier FromTTSRequestVoiceId(string? value) => new TTSRequestVoiceSpecifier(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TTSRequestVoiceSpecifier(global::Cartesia.TTSRequestVoiceSpecifierTTSRequestVoiceObject value) => new TTSRequestVoiceSpecifier((global::Cartesia.TTSRequestVoiceSpecifierTTSRequestVoiceObject?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.TTSRequestVoiceSpecifierTTSRequestVoiceObject?(TTSRequestVoiceSpecifier @this) => @this.TTSRequestVoiceObject;

        /// <summary>
        ///
        /// </summary>
        public TTSRequestVoiceSpecifier(global::Cartesia.TTSRequestVoiceSpecifierTTSRequestVoiceObject? value)
        {
            TTSRequestVoiceObject = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TTSRequestVoiceSpecifier FromTTSRequestVoiceObject(global::Cartesia.TTSRequestVoiceSpecifierTTSRequestVoiceObject? value) => new TTSRequestVoiceSpecifier(value);

        /// <summary>
        ///
        /// </summary>
        public TTSRequestVoiceSpecifier(
            string? tTSRequestVoiceId,
            global::Cartesia.TTSRequestVoiceSpecifierTTSRequestVoiceObject? tTSRequestVoiceObject
            )
        {
            TTSRequestVoiceId = tTSRequestVoiceId;
            TTSRequestVoiceObject = tTSRequestVoiceObject;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TTSRequestVoiceObject as object ??
            TTSRequestVoiceId as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            TTSRequestVoiceId?.ToString() ??
            TTSRequestVoiceObject?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTTSRequestVoiceId && !IsTTSRequestVoiceObject || !IsTTSRequestVoiceId && IsTTSRequestVoiceObject;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? tTSRequestVoiceId = null,
            global::System.Func<global::Cartesia.TTSRequestVoiceSpecifierTTSRequestVoiceObject, TResult>? tTSRequestVoiceObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTTSRequestVoiceId && tTSRequestVoiceId != null)
            {
                return tTSRequestVoiceId(TTSRequestVoiceId!);
            }
            else if (IsTTSRequestVoiceObject && tTSRequestVoiceObject != null)
            {
                return tTSRequestVoiceObject(TTSRequestVoiceObject!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? tTSRequestVoiceId = null,

            global::System.Action<global::Cartesia.TTSRequestVoiceSpecifierTTSRequestVoiceObject>? tTSRequestVoiceObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTTSRequestVoiceId)
            {
                tTSRequestVoiceId?.Invoke(TTSRequestVoiceId!);
            }
            else if (IsTTSRequestVoiceObject)
            {
                tTSRequestVoiceObject?.Invoke(TTSRequestVoiceObject!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? tTSRequestVoiceId = null,
            global::System.Action<global::Cartesia.TTSRequestVoiceSpecifierTTSRequestVoiceObject>? tTSRequestVoiceObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTTSRequestVoiceId)
            {
                tTSRequestVoiceId?.Invoke(TTSRequestVoiceId!);
            }
            else if (IsTTSRequestVoiceObject)
            {
                tTSRequestVoiceObject?.Invoke(TTSRequestVoiceObject!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TTSRequestVoiceId,
                typeof(string),
                TTSRequestVoiceObject,
                typeof(global::Cartesia.TTSRequestVoiceSpecifierTTSRequestVoiceObject),
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
        public bool Equals(TTSRequestVoiceSpecifier other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(TTSRequestVoiceId, other.TTSRequestVoiceId) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.TTSRequestVoiceSpecifierTTSRequestVoiceObject?>.Default.Equals(TTSRequestVoiceObject, other.TTSRequestVoiceObject)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TTSRequestVoiceSpecifier obj1, TTSRequestVoiceSpecifier obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TTSRequestVoiceSpecifier>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TTSRequestVoiceSpecifier obj1, TTSRequestVoiceSpecifier obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TTSRequestVoiceSpecifier o && Equals(o);
        }
    }
}
