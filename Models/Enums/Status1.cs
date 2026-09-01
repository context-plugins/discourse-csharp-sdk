using System.Text.Json.Serialization;
using Discourse.Core.Enum;

namespace Discourse.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Status1>))]
public sealed record Status1 : StringEnum<Status1>
{
    private Status1(string value) : base(value)
    {
    }

    public static readonly Status1 Closed = new("closed");

    public static readonly Status1 Pinned = new("pinned");

    public static readonly Status1 PinnedGlobally = new("pinned_globally");

    public static readonly Status1 Archived = new("archived");

    public static readonly Status1 Visible = new("visible");

    public static Status1 FromValue(string value) => FromValueCore(value);
}
