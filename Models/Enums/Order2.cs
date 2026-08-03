using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Core.Enum;

namespace DiscourseApiDocumentation.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Order2>))]
public sealed record Order2 : StringEnum<Order2>
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

    public static Order2 FromValue(string value) => FromValueCore(value);
}
