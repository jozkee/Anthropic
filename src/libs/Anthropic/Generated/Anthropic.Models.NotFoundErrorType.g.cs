
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: not_found_error
    /// </summary>
    public enum NotFoundErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        NotFoundError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NotFoundErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NotFoundErrorType value)
        {
            return value switch
            {
                NotFoundErrorType.NotFoundError => "not_found_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NotFoundErrorType? ToEnum(string value)
        {
            return value switch
            {
                "not_found_error" => NotFoundErrorType.NotFoundError,
                _ => null,
            };
        }
    }
}