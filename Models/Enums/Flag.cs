using System.Text.Json.Serialization;
using Discourse.Core.Enum;

namespace Discourse.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Flag>))]
public sealed record Flag : StringEnum<Flag>
{
    private Flag(string value) : base(value)
    {
    }

    public static readonly Flag Active = new("active");

    public static readonly Flag New = new("new");

    public static readonly Flag Staff = new("staff");

    public static readonly Flag Suspended = new("suspended");

    public static readonly Flag Blocked = new("blocked");

    public static readonly Flag Suspect = new("suspect");

    public static Flag FromValue(string value) => FromValueCore(value);
}
