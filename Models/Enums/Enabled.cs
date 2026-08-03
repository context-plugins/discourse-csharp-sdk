using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Core.Enum;

namespace DiscourseApiDocumentation.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Enabled>))]
public sealed record Enabled : StringEnum<Enabled>
{
    private Enabled(string value) : base(value)
    {
    }

    public static readonly Enabled True = new("true");

    public static readonly Enabled False = new("false");

    public static Enabled FromValue(string value) => FromValueCore(value);
}
