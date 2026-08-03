using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Core.Enum;

namespace DiscourseApiDocumentation.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Reason>))]
public sealed record Reason : StringEnum<Reason>
{
    private Reason(string value) : base(value)
    {
    }

    public static readonly Reason EnabledForEveryone = new("enabled_for_everyone");

    public static readonly Reason EnabledForNoOne = new("enabled_for_no_one");

    public static readonly Reason InSpecificGroups = new("in_specific_groups");

    public static readonly Reason NotInSpecificGroups = new("not_in_specific_groups");

    public static Reason FromValue(string value) => FromValueCore(value);
}
