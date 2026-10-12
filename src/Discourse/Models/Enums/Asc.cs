using System;
using System.Text.Json.Serialization;
using Discourse.Core.Enum;

namespace Discourse.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Asc>))]
public sealed record Asc : OpenStringEnum<Asc>
{
    private Asc(string value) : base(value)
    {
    }

    public static readonly Asc True = new("true");

    public TResult Match<TResult>(Func<TResult> onTrue, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == True => onTrue(),
            _ => otherwise(Value)
        };

    public void Match(Action onTrue, Action<string> otherwise)
    {
        if (this == True) onTrue();
        else otherwise(Value);
    }
}
