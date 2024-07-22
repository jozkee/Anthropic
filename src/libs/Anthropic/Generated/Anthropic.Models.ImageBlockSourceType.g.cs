
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The type of image source.
    /// </summary>
    public enum ImageBlockSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Base64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageBlockSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageBlockSourceType value)
        {
            return value switch
            {
                ImageBlockSourceType.Base64 => "base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageBlockSourceType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => ImageBlockSourceType.Base64,
                _ => null,
            };
        }
    }
}