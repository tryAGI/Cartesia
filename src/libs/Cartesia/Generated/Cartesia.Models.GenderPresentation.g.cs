
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenderPresentation
    {
        /// <summary>
        /// 
        /// </summary>
        Masculine,
        /// <summary>
        /// 
        /// </summary>
        Feminine,
        /// <summary>
        /// 
        /// </summary>
        GenderNeutral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenderPresentationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenderPresentation value)
        {
            return value switch
            {
                GenderPresentation.Masculine => "masculine",
                GenderPresentation.Feminine => "feminine",
                GenderPresentation.GenderNeutral => "gender_neutral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenderPresentation? ToEnum(string value)
        {
            return value switch
            {
                "masculine" => GenderPresentation.Masculine,
                "feminine" => GenderPresentation.Feminine,
                "gender_neutral" => GenderPresentation.GenderNeutral,
                _ => null,
            };
        }
    }
}