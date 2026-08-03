using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Core.Enum;

namespace DiscourseApiDocumentation.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Order>))]
public sealed record Order : StringEnum<Order>
{
    private Order(string value) : base(value)
    {
    }

    public static readonly Order Asc = new("asc");

    public static readonly Order Desc = new("desc");

    public static Order FromValue(string value) => FromValueCore(value);
}
