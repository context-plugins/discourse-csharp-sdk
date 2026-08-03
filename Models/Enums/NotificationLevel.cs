using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Core.Enum;

namespace DiscourseApiDocumentation.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<NotificationLevel>))]
public sealed record NotificationLevel : StringEnum<NotificationLevel>
{
    private NotificationLevel(string value) : base(value)
    {
    }

    public static readonly NotificationLevel _0 = new("0");

    public static readonly NotificationLevel _1 = new("1");

    public static readonly NotificationLevel _2 = new("2");

    public static readonly NotificationLevel _3 = new("3");

    public static NotificationLevel FromValue(string value) => FromValueCore(value);
}
