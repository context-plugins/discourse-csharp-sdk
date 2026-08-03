using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Core.Enum;

namespace DiscourseApiDocumentation.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Period1>))]
public sealed record Period1 : StringEnum<Period1>
{
    private Period1(string value) : base(value)
    {
    }

    public static readonly Period1 Daily = new("daily");

    public static readonly Period1 Weekly = new("weekly");

    public static readonly Period1 Monthly = new("monthly");

    public static readonly Period1 Quarterly = new("quarterly");

    public static readonly Period1 Yearly = new("yearly");

    public static readonly Period1 All = new("all");

    public static Period1 FromValue(string value) => FromValueCore(value);
}
