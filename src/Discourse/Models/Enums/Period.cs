using System;
using System.Text.Json.Serialization;
using Discourse.Core.Enum;

namespace Discourse.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Period>))]
public sealed record Period : OpenStringEnum<Period>
{
    private Period(string value) : base(value)
    {
    }

    public static readonly Period Before = new("before");

    public static readonly Period After = new("after");

    public TResult Match<TResult>(Func<TResult> onBefore, Func<TResult> onAfter, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Before => onBefore(),
            _ when this == After => onAfter(),
            _ => otherwise(Value)
        };

    public void Match(Action onBefore, Action onAfter, Action<string> otherwise)
    {
        if (this == Before) onBefore();
        else if (this == After) onAfter();
        else otherwise(Value);
    }
}
