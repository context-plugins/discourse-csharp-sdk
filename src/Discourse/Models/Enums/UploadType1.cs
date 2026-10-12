using System;
using System.Text.Json.Serialization;
using Discourse.Core.Enum;

namespace Discourse.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<UploadType1>))]
public sealed record UploadType1 : OpenStringEnum<UploadType1>
{
    private UploadType1(string value) : base(value)
    {
    }

    public static readonly UploadType1 Avatar = new("avatar");

    public static readonly UploadType1 ProfileBackground = new("profile_background");

    public static readonly UploadType1 CardBackground = new("card_background");

    public static readonly UploadType1 CustomEmoji = new("custom_emoji");

    public static readonly UploadType1 Composer = new("composer");

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
