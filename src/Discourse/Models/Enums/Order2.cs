using System;
using System.Text.Json.Serialization;
using Discourse.Core.Enum;

namespace Discourse.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Order2>))]
public sealed record Order2 : OpenStringEnum<Order2>
{
    private Order2(string value) : base(value)
    {
    }

    public static readonly Order2 LikesReceived = new("likes_received");

    public static readonly Order2 LikesGiven = new("likes_given");

    public static readonly Order2 TopicCount = new("topic_count");

    public static readonly Order2 PostCount = new("post_count");

    public static readonly Order2 TopicsEntered = new("topics_entered");

    public static readonly Order2 PostsRead = new("posts_read");

    public static readonly Order2 DaysVisited = new("days_visited");

    public TResult Match<TResult>(Func<TResult> onLikesReceived,
        Func<TResult> onLikesGiven,
        Func<TResult> onTopicCount,
        Func<TResult> onPostCount,
        Func<TResult> onTopicsEntered,
        Func<TResult> onPostsRead,
        Func<TResult> onDaysVisited,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == LikesReceived => onLikesReceived(),
            _ when this == LikesGiven => onLikesGiven(),
            _ when this == TopicCount => onTopicCount(),
            _ when this == PostCount => onPostCount(),
            _ when this == TopicsEntered => onTopicsEntered(),
            _ when this == PostsRead => onPostsRead(),
            _ when this == DaysVisited => onDaysVisited(),
            _ => otherwise(Value)
        };

    public void Match(Action onLikesReceived,
        Action onLikesGiven,
        Action onTopicCount,
        Action onPostCount,
        Action onTopicsEntered,
        Action onPostsRead,
        Action onDaysVisited,
        Action<string> otherwise)
    {
        if (this == LikesReceived) onLikesReceived();
        else if (this == LikesGiven) onLikesGiven();
        else if (this == TopicCount) onTopicCount();
        else if (this == PostCount) onPostCount();
        else if (this == TopicsEntered) onTopicsEntered();
        else if (this == PostsRead) onPostsRead();
        else if (this == DaysVisited) onDaysVisited();
        else otherwise(Value);
    }
}
