using System;
using System.Text.Json.Serialization;
using Discourse.Core.Enum;

namespace Discourse.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type1>))]
public sealed record Type1 : OpenStringEnum<Type1>
{
    private Type1(string value) : base(value)
    {
    }

    public static readonly Type1 Uploaded = new("uploaded");

    public static readonly Type1 Custom = new("custom");

    public static readonly Type1 Gravatar = new("gravatar");

    public static readonly Type1 System = new("system");

    public TResult Match<TResult>(Func<TResult> onUploaded,
        Func<TResult> onCustom,
        Func<TResult> onGravatar,
        Func<TResult> onSystem,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Uploaded => onUploaded(),
            _ when this == Custom => onCustom(),
            _ when this == Gravatar => onGravatar(),
            _ when this == System => onSystem(),
            _ => otherwise(Value)
        };

    public void Match(Action onUploaded, Action onCustom, Action onGravatar, Action onSystem, Action<string> otherwise)
    {
        if (this == Uploaded) onUploaded();
        else if (this == Custom) onCustom();
        else if (this == Gravatar) onGravatar();
        else if (this == System) onSystem();
        else otherwise(Value);
    }
}
