
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum LocalizeFrenchDialect
    {
        /// <summary>
        /// 
        /// </summary>
        Eu,
        /// <summary>
        /// 
        /// </summary>
        Ca,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LocalizeFrenchDialectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalizeFrenchDialect value)
        {
            return value switch
            {
                LocalizeFrenchDialect.Eu => "eu",
                LocalizeFrenchDialect.Ca => "ca",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalizeFrenchDialect? ToEnum(string value)
        {
            return value switch
            {
                "eu" => LocalizeFrenchDialect.Eu,
                "ca" => LocalizeFrenchDialect.Ca,
                _ => null,
            };
        }
    }
}