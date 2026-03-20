#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The dialect to localize to. Only supported for English (`en`), Spanish (`es`), Portuguese (`pt`), and French (`fr`).
    /// </summary>
    public readonly partial struct LocalizeDialect : global::System.IEquatable<LocalizeDialect>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.LocalizeEnglishDialect? LocalizeEnglishDialect { get; init; }
#else
        public global::Cartesia.LocalizeEnglishDialect? LocalizeEnglishDialect { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LocalizeEnglishDialect))]
#endif
        public bool IsLocalizeEnglishDialect => LocalizeEnglishDialect != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.LocalizeSpanishDialect? LocalizeSpanishDialect { get; init; }
#else
        public global::Cartesia.LocalizeSpanishDialect? LocalizeSpanishDialect { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LocalizeSpanishDialect))]
#endif
        public bool IsLocalizeSpanishDialect => LocalizeSpanishDialect != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.LocalizePortugueseDialect? LocalizePortugueseDialect { get; init; }
#else
        public global::Cartesia.LocalizePortugueseDialect? LocalizePortugueseDialect { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LocalizePortugueseDialect))]
#endif
        public bool IsLocalizePortugueseDialect => LocalizePortugueseDialect != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.LocalizeFrenchDialect? LocalizeFrenchDialect { get; init; }
#else
        public global::Cartesia.LocalizeFrenchDialect? LocalizeFrenchDialect { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LocalizeFrenchDialect))]
#endif
        public bool IsLocalizeFrenchDialect => LocalizeFrenchDialect != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LocalizeDialect(global::Cartesia.LocalizeEnglishDialect value) => new LocalizeDialect((global::Cartesia.LocalizeEnglishDialect?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.LocalizeEnglishDialect?(LocalizeDialect @this) => @this.LocalizeEnglishDialect;

        /// <summary>
        /// 
        /// </summary>
        public LocalizeDialect(global::Cartesia.LocalizeEnglishDialect? value)
        {
            LocalizeEnglishDialect = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LocalizeDialect(global::Cartesia.LocalizeSpanishDialect value) => new LocalizeDialect((global::Cartesia.LocalizeSpanishDialect?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.LocalizeSpanishDialect?(LocalizeDialect @this) => @this.LocalizeSpanishDialect;

        /// <summary>
        /// 
        /// </summary>
        public LocalizeDialect(global::Cartesia.LocalizeSpanishDialect? value)
        {
            LocalizeSpanishDialect = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LocalizeDialect(global::Cartesia.LocalizePortugueseDialect value) => new LocalizeDialect((global::Cartesia.LocalizePortugueseDialect?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.LocalizePortugueseDialect?(LocalizeDialect @this) => @this.LocalizePortugueseDialect;

        /// <summary>
        /// 
        /// </summary>
        public LocalizeDialect(global::Cartesia.LocalizePortugueseDialect? value)
        {
            LocalizePortugueseDialect = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LocalizeDialect(global::Cartesia.LocalizeFrenchDialect value) => new LocalizeDialect((global::Cartesia.LocalizeFrenchDialect?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.LocalizeFrenchDialect?(LocalizeDialect @this) => @this.LocalizeFrenchDialect;

        /// <summary>
        /// 
        /// </summary>
        public LocalizeDialect(global::Cartesia.LocalizeFrenchDialect? value)
        {
            LocalizeFrenchDialect = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LocalizeDialect(
            global::Cartesia.LocalizeEnglishDialect? localizeEnglishDialect,
            global::Cartesia.LocalizeSpanishDialect? localizeSpanishDialect,
            global::Cartesia.LocalizePortugueseDialect? localizePortugueseDialect,
            global::Cartesia.LocalizeFrenchDialect? localizeFrenchDialect
            )
        {
            LocalizeEnglishDialect = localizeEnglishDialect;
            LocalizeSpanishDialect = localizeSpanishDialect;
            LocalizePortugueseDialect = localizePortugueseDialect;
            LocalizeFrenchDialect = localizeFrenchDialect;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LocalizeFrenchDialect as object ??
            LocalizePortugueseDialect as object ??
            LocalizeSpanishDialect as object ??
            LocalizeEnglishDialect as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            LocalizeEnglishDialect?.ToValueString() ??
            LocalizeSpanishDialect?.ToValueString() ??
            LocalizePortugueseDialect?.ToValueString() ??
            LocalizeFrenchDialect?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLocalizeEnglishDialect && !IsLocalizeSpanishDialect && !IsLocalizePortugueseDialect && !IsLocalizeFrenchDialect || !IsLocalizeEnglishDialect && IsLocalizeSpanishDialect && !IsLocalizePortugueseDialect && !IsLocalizeFrenchDialect || !IsLocalizeEnglishDialect && !IsLocalizeSpanishDialect && IsLocalizePortugueseDialect && !IsLocalizeFrenchDialect || !IsLocalizeEnglishDialect && !IsLocalizeSpanishDialect && !IsLocalizePortugueseDialect && IsLocalizeFrenchDialect;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.LocalizeEnglishDialect?, TResult>? localizeEnglishDialect = null,
            global::System.Func<global::Cartesia.LocalizeSpanishDialect?, TResult>? localizeSpanishDialect = null,
            global::System.Func<global::Cartesia.LocalizePortugueseDialect?, TResult>? localizePortugueseDialect = null,
            global::System.Func<global::Cartesia.LocalizeFrenchDialect?, TResult>? localizeFrenchDialect = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLocalizeEnglishDialect && localizeEnglishDialect != null)
            {
                return localizeEnglishDialect(LocalizeEnglishDialect!);
            }
            else if (IsLocalizeSpanishDialect && localizeSpanishDialect != null)
            {
                return localizeSpanishDialect(LocalizeSpanishDialect!);
            }
            else if (IsLocalizePortugueseDialect && localizePortugueseDialect != null)
            {
                return localizePortugueseDialect(LocalizePortugueseDialect!);
            }
            else if (IsLocalizeFrenchDialect && localizeFrenchDialect != null)
            {
                return localizeFrenchDialect(LocalizeFrenchDialect!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cartesia.LocalizeEnglishDialect?>? localizeEnglishDialect = null,
            global::System.Action<global::Cartesia.LocalizeSpanishDialect?>? localizeSpanishDialect = null,
            global::System.Action<global::Cartesia.LocalizePortugueseDialect?>? localizePortugueseDialect = null,
            global::System.Action<global::Cartesia.LocalizeFrenchDialect?>? localizeFrenchDialect = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLocalizeEnglishDialect)
            {
                localizeEnglishDialect?.Invoke(LocalizeEnglishDialect!);
            }
            else if (IsLocalizeSpanishDialect)
            {
                localizeSpanishDialect?.Invoke(LocalizeSpanishDialect!);
            }
            else if (IsLocalizePortugueseDialect)
            {
                localizePortugueseDialect?.Invoke(LocalizePortugueseDialect!);
            }
            else if (IsLocalizeFrenchDialect)
            {
                localizeFrenchDialect?.Invoke(LocalizeFrenchDialect!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                LocalizeEnglishDialect,
                typeof(global::Cartesia.LocalizeEnglishDialect),
                LocalizeSpanishDialect,
                typeof(global::Cartesia.LocalizeSpanishDialect),
                LocalizePortugueseDialect,
                typeof(global::Cartesia.LocalizePortugueseDialect),
                LocalizeFrenchDialect,
                typeof(global::Cartesia.LocalizeFrenchDialect),
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
        public bool Equals(LocalizeDialect other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.LocalizeEnglishDialect?>.Default.Equals(LocalizeEnglishDialect, other.LocalizeEnglishDialect) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.LocalizeSpanishDialect?>.Default.Equals(LocalizeSpanishDialect, other.LocalizeSpanishDialect) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.LocalizePortugueseDialect?>.Default.Equals(LocalizePortugueseDialect, other.LocalizePortugueseDialect) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.LocalizeFrenchDialect?>.Default.Equals(LocalizeFrenchDialect, other.LocalizeFrenchDialect) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LocalizeDialect obj1, LocalizeDialect obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LocalizeDialect>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LocalizeDialect obj1, LocalizeDialect obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LocalizeDialect o && Equals(o);
        }
    }
}
