using System.Text.Json.Serialization;
using Discourse.Core.Enum;

namespace Discourse.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TypeEnum>))]
public sealed record TypeEnum : StringEnum<TypeEnum>
{
    private TypeEnum(string value) : base(value)
    {
    }

    public static readonly TypeEnum Avatar = new("avatar");

    public static readonly TypeEnum ProfileBackground = new("profile_background");

    public static readonly TypeEnum CardBackground = new("card_background");

    public static readonly TypeEnum CustomEmoji = new("custom_emoji");

    public static readonly TypeEnum Composer = new("composer");

    public static TypeEnum FromValue(string value) => FromValueCore(value);
}
