using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Core.Enum;

namespace DiscourseApiDocumentation.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Order3>))]
public sealed record Order3 : StringEnum<Order3>
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

    public static Order3 FromValue(string value) => FromValueCore(value);
}
