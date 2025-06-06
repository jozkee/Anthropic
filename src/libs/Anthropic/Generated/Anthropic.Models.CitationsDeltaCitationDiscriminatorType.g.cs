
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum CitationsDeltaCitationDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        CharLocation,
        /// <summary>
        /// 
        /// </summary>
        ContentBlockLocation,
        /// <summary>
        /// 
        /// </summary>
        PageLocation,
        /// <summary>
        /// 
        /// </summary>
        WebSearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CitationsDeltaCitationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CitationsDeltaCitationDiscriminatorType value)
        {
            return value switch
            {
                CitationsDeltaCitationDiscriminatorType.CharLocation => "char_location",
                CitationsDeltaCitationDiscriminatorType.ContentBlockLocation => "content_block_location",
                CitationsDeltaCitationDiscriminatorType.PageLocation => "page_location",
                CitationsDeltaCitationDiscriminatorType.WebSearchResultLocation => "web_search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CitationsDeltaCitationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => CitationsDeltaCitationDiscriminatorType.CharLocation,
                "content_block_location" => CitationsDeltaCitationDiscriminatorType.ContentBlockLocation,
                "page_location" => CitationsDeltaCitationDiscriminatorType.PageLocation,
                "web_search_result_location" => CitationsDeltaCitationDiscriminatorType.WebSearchResultLocation,
                _ => null,
            };
        }
    }
}