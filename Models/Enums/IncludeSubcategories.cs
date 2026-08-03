using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Core.Enum;

namespace DiscourseApiDocumentation.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<IncludeSubcategories>))]
public sealed record IncludeSubcategories : StringEnum<IncludeSubcategories>
{
    private IncludeSubcategories(string value) : base(value)
    {
    }

    public static readonly IncludeSubcategories True = new("true");

    public static readonly IncludeSubcategories False = new("false");

    public static IncludeSubcategories FromValue(string value) => FromValueCore(value);
}
