using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A block of content in a message.
    /// </summary>
    public readonly partial struct Block : global::System.IEquatable<Block>
    {
        /// <summary>
        /// A block of text content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.TextBlock? Text { get; init; }
#else
        public global::Anthropic.TextBlock? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Block(global::Anthropic.TextBlock value) => new Block(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.TextBlock?(Block @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public Block(global::Anthropic.TextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        /// A block of image content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ImageBlock? Image { get; init; }
#else
        public global::Anthropic.ImageBlock? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Block(global::Anthropic.ImageBlock value) => new Block(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ImageBlock?(Block @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public Block(global::Anthropic.ImageBlock? value)
        {
            Image = value;
        }

        /// <summary>
        /// The tool the model wants to use.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ToolUseBlock? ToolUse { get; init; }
#else
        public global::Anthropic.ToolUseBlock? ToolUse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolUse))]
#endif
        public bool IsToolUse => ToolUse != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Block(global::Anthropic.ToolUseBlock value) => new Block(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ToolUseBlock?(Block @this) => @this.ToolUse;

        /// <summary>
        /// 
        /// </summary>
        public Block(global::Anthropic.ToolUseBlock? value)
        {
            ToolUse = value;
        }

        /// <summary>
        /// The result of using a tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ToolResultBlock? ToolResult { get; init; }
#else
        public global::Anthropic.ToolResultBlock? ToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolResult))]
#endif
        public bool IsToolResult => ToolResult != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Block(global::Anthropic.ToolResultBlock value) => new Block(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ToolResultBlock?(Block @this) => @this.ToolResult;

        /// <summary>
        /// 
        /// </summary>
        public Block(global::Anthropic.ToolResultBlock? value)
        {
            ToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Block(
            global::Anthropic.TextBlock? text,
            global::Anthropic.ImageBlock? image,
            global::Anthropic.ToolUseBlock? toolUse,
            global::Anthropic.ToolResultBlock? toolResult
            )
        {
            Text = text;
            Image = image;
            ToolUse = toolUse;
            ToolResult = toolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolResult as object ??
            ToolUse as object ??
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsToolUse && !IsToolResult || !IsText && IsImage && !IsToolUse && !IsToolResult || !IsText && !IsImage && IsToolUse && !IsToolResult || !IsText && !IsImage && !IsToolUse && IsToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Anthropic.TextBlock),
                Image,
                typeof(global::Anthropic.ImageBlock),
                ToolUse,
                typeof(global::Anthropic.ToolUseBlock),
                ToolResult,
                typeof(global::Anthropic.ToolResultBlock),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Block other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.TextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ImageBlock?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ToolUseBlock?>.Default.Equals(ToolUse, other.ToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ToolResultBlock?>.Default.Equals(ToolResult, other.ToolResult) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Block obj1, Block obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Block>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Block obj1, Block obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Block o && Equals(o);
        }
    }
}
