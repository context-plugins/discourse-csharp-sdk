using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Core.Enum;

namespace DiscourseApiDocumentation.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<UploadType>))]
public sealed record UploadType : StringEnum<UploadType>
{
    private UploadType(string value) : base(value)
    {
    }

    public static readonly UploadType Avatar = new("avatar");

    public static readonly UploadType ProfileBackground = new("profile_background");

    public static readonly UploadType CardBackground = new("card_background");

    public static readonly UploadType CustomEmoji = new("custom_emoji");

    public static readonly UploadType Composer = new("composer");

    public static UploadType FromValue(string value) => FromValueCore(value);
}
