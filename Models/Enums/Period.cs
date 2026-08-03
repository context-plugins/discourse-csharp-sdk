using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Core.Enum;

namespace DiscourseApiDocumentation.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Period>))]
public sealed record Period : StringEnum<Period>
{
    private Period(string value) : base(value)
    {
    }

    public static readonly Period Before = new("before");

    public static readonly Period After = new("after");

    public static Period FromValue(string value) => FromValueCore(value);
}
