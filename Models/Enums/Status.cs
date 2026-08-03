using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Core.Enum;

namespace DiscourseApiDocumentation.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Status>))]
public sealed record Status : StringEnum<Status>
{
    private Status(string value) : base(value)
    {
    }

    public static readonly Status Public = new("public");

    public static readonly Status Private = new("private");

    public static readonly Status Standalone = new("standalone");

    public static Status FromValue(string value) => FromValueCore(value);
}
