using System.Text.Json.Serialization;
using Discourse.Core.Enum;

namespace Discourse.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Asc>))]
public sealed record Asc : StringEnum<Asc>
{
    private Asc(string value) : base(value)
    {
    }

    public static readonly Asc True = new("true");

    public static Asc FromValue(string value) => FromValueCore(value);
}
