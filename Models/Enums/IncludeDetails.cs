using System.Text.Json.Serialization;
using Discourse.Core.Enum;

namespace Discourse.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<IncludeDetails>))]
public sealed record IncludeDetails : StringEnum<IncludeDetails>
{
    private IncludeDetails(string value) : base(value)
    {
    }

    public static readonly IncludeDetails True = new("true");

    public static readonly IncludeDetails False = new("false");

    public static IncludeDetails FromValue(string value) => FromValueCore(value);
}
