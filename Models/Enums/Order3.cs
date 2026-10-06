using System;
using System.Text.Json.Serialization;
using Discourse.Core.Enum;

namespace Discourse.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Order3>))]
public sealed record Order3 : OpenStringEnum<Order3>
{
    private Order3(string value) : base(value)
    {
    }

    public static readonly Order3 Created = new("created");

    public static readonly Order3 LastEmailed = new("last_emailed");

    public static readonly Order3 Seen = new("seen");

    public static readonly Order3 Username = new("username");

    public static readonly Order3 Email = new("email");

    public static readonly Order3 TrustLevel = new("trust_level");

    public static readonly Order3 DaysVisited = new("days_visited");

    public static readonly Order3 PostsRead = new("posts_read");

    public static readonly Order3 TopicsViewed = new("topics_viewed");

    public static readonly Order3 Posts = new("posts");

    public static readonly Order3 ReadTime = new("read_time");

    public TResult Match<TResult>(Func<TResult> onCreated,
        Func<TResult> onLastEmailed,
        Func<TResult> onSeen,
        Func<TResult> onUsername,
        Func<TResult> onEmail,
        Func<TResult> onTrustLevel,
        Func<TResult> onDaysVisited,
        Func<TResult> onPostsRead,
        Func<TResult> onTopicsViewed,
        Func<TResult> onPosts,
        Func<TResult> onReadTime,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Created => onCreated(),
            _ when this == LastEmailed => onLastEmailed(),
            _ when this == Seen => onSeen(),
            _ when this == Username => onUsername(),
            _ when this == Email => onEmail(),
            _ when this == TrustLevel => onTrustLevel(),
            _ when this == DaysVisited => onDaysVisited(),
            _ when this == PostsRead => onPostsRead(),
            _ when this == TopicsViewed => onTopicsViewed(),
            _ when this == Posts => onPosts(),
            _ when this == ReadTime => onReadTime(),
            _ => otherwise(Value)
        };

    public void Match(Action onCreated,
        Action onLastEmailed,
        Action onSeen,
        Action onUsername,
        Action onEmail,
        Action onTrustLevel,
        Action onDaysVisited,
        Action onPostsRead,
        Action onTopicsViewed,
        Action onPosts,
        Action onReadTime,
        Action<string> otherwise)
    {
        if (this == Created) onCreated();
        else if (this == LastEmailed) onLastEmailed();
        else if (this == Seen) onSeen();
        else if (this == Username) onUsername();
        else if (this == Email) onEmail();
        else if (this == TrustLevel) onTrustLevel();
        else if (this == DaysVisited) onDaysVisited();
        else if (this == PostsRead) onPostsRead();
        else if (this == TopicsViewed) onTopicsViewed();
        else if (this == Posts) onPosts();
        else if (this == ReadTime) onReadTime();
        else otherwise(Value);
    }
}
