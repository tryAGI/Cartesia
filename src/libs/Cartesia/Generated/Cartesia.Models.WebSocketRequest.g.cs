#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct WebSocketRequest : global::System.IEquatable<WebSocketRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.GenerationRequest? GenerationRequest { get; init; }
#else
        public global::Cartesia.GenerationRequest? GenerationRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerationRequest))]
#endif
        public bool IsGenerationRequest => GenerationRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.CancelContextRequest? CancelContextRequest { get; init; }
#else
        public global::Cartesia.CancelContextRequest? CancelContextRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CancelContextRequest))]
#endif
        public bool IsCancelContextRequest => CancelContextRequest != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebSocketRequest(global::Cartesia.GenerationRequest value) => new WebSocketRequest((global::Cartesia.GenerationRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.GenerationRequest?(WebSocketRequest @this) => @this.GenerationRequest;

        /// <summary>
        /// 
        /// </summary>
        public WebSocketRequest(global::Cartesia.GenerationRequest? value)
        {
            GenerationRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebSocketRequest(global::Cartesia.CancelContextRequest value) => new WebSocketRequest((global::Cartesia.CancelContextRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.CancelContextRequest?(WebSocketRequest @this) => @this.CancelContextRequest;

        /// <summary>
        /// 
        /// </summary>
        public WebSocketRequest(global::Cartesia.CancelContextRequest? value)
        {
            CancelContextRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WebSocketRequest(
            global::Cartesia.GenerationRequest? generationRequest,
            global::Cartesia.CancelContextRequest? cancelContextRequest
            )
        {
            GenerationRequest = generationRequest;
            CancelContextRequest = cancelContextRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CancelContextRequest as object ??
            GenerationRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GenerationRequest?.ToString() ??
            CancelContextRequest?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGenerationRequest && !IsCancelContextRequest || !IsGenerationRequest && IsCancelContextRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.GenerationRequest?, TResult>? generationRequest = null,
            global::System.Func<global::Cartesia.CancelContextRequest?, TResult>? cancelContextRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGenerationRequest && generationRequest != null)
            {
                return generationRequest(GenerationRequest!);
            }
            else if (IsCancelContextRequest && cancelContextRequest != null)
            {
                return cancelContextRequest(CancelContextRequest!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cartesia.GenerationRequest?>? generationRequest = null,
            global::System.Action<global::Cartesia.CancelContextRequest?>? cancelContextRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGenerationRequest)
            {
                generationRequest?.Invoke(GenerationRequest!);
            }
            else if (IsCancelContextRequest)
            {
                cancelContextRequest?.Invoke(CancelContextRequest!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GenerationRequest,
                typeof(global::Cartesia.GenerationRequest),
                CancelContextRequest,
                typeof(global::Cartesia.CancelContextRequest),
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
        public bool Equals(WebSocketRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.GenerationRequest?>.Default.Equals(GenerationRequest, other.GenerationRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.CancelContextRequest?>.Default.Equals(CancelContextRequest, other.CancelContextRequest) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WebSocketRequest obj1, WebSocketRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebSocketRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WebSocketRequest obj1, WebSocketRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebSocketRequest o && Equals(o);
        }
    }
}
