using System.Text.Json.Serialization;
using Discourse.Core.Enum;

namespace Discourse.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type1>))]
public sealed record Type1 : StringEnum<Type1>
{
    private Type1(string value) : base(value)
    {
    }

    public static readonly Type1 Uploaded = new("uploaded");

    public static readonly Type1 Custom = new("custom");

    public static readonly Type1 Gravatar = new("gravatar");

    public static readonly Type1 System = new("system");

    public static Type1 FromValue(string value) => FromValueCore(value);
}
