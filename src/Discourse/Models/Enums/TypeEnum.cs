using System;
using System.Text.Json.Serialization;
using Discourse.Core.Enum;

namespace Discourse.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TypeEnum>))]
public sealed record TypeEnum : OpenStringEnum<TypeEnum>
{
    private TypeEnum(string value) : base(value)
    {
    }

    public static readonly TypeEnum Avatar = new("avatar");

    public static readonly TypeEnum ProfileBackground = new("profile_background");

    public static readonly TypeEnum CardBackground = new("card_background");

    public static readonly TypeEnum CustomEmoji = new("custom_emoji");

    public static readonly TypeEnum Composer = new("composer");

    public TResult Match<TResult>(Func<TResult> onAvatar,
        Func<TResult> onProfileBackground,
        Func<TResult> onCardBackground,
        Func<TResult> onCustomEmoji,
        Func<TResult> onComposer,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Avatar => onAvatar(),
            _ when this == ProfileBackground => onProfileBackground(),
            _ when this == CardBackground => onCardBackground(),
            _ when this == CustomEmoji => onCustomEmoji(),
            _ when this == Composer => onComposer(),
            _ => otherwise(Value)
        };

    public void Match(Action onAvatar,
        Action onProfileBackground,
        Action onCardBackground,
        Action onCustomEmoji,
        Action onComposer,
        Action<string> otherwise)
    {
        if (this == Avatar) onAvatar();
        else if (this == ProfileBackground) onProfileBackground();
        else if (this == CardBackground) onCardBackground();
        else if (this == CustomEmoji) onCustomEmoji();
        else if (this == Composer) onComposer();
        else otherwise(Value);
    }
}
