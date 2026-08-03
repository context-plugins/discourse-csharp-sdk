using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Core.Enum;

namespace DiscourseApiDocumentation.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<UploadType1>))]
public sealed record UploadType1 : StringEnum<UploadType1>
{
    private UploadType1(string value) : base(value)
    {
    }

    public static readonly UploadType1 Avatar = new("avatar");

    public static readonly UploadType1 ProfileBackground = new("profile_background");

    public static readonly UploadType1 CardBackground = new("card_background");

    public static readonly UploadType1 CustomEmoji = new("custom_emoji");

    public static readonly UploadType1 Composer = new("composer");

    public static UploadType1 FromValue(string value) => FromValueCore(value);
}
