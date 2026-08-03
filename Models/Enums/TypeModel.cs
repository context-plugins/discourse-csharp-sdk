using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Core.Enum;

namespace DiscourseApiDocumentation.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TypeModel>))]
public sealed record TypeModel : StringEnum<TypeModel>
{
    private TypeModel(string value) : base(value)
    {
    }

    public static readonly TypeModel Avatar = new("avatar");

    public static readonly TypeModel ProfileBackground = new("profile_background");

    public static readonly TypeModel CardBackground = new("card_background");

    public static readonly TypeModel CustomEmoji = new("custom_emoji");

    public static readonly TypeModel Composer = new("composer");

    public static TypeModel FromValue(string value) => FromValueCore(value);
}
