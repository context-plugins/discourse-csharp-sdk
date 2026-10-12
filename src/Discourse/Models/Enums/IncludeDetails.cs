using System;
using System.Text.Json.Serialization;
using Discourse.Core.Enum;

namespace Discourse.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<IncludeDetails>))]
public sealed record IncludeDetails : OpenStringEnum<IncludeDetails>
{
    private IncludeDetails(string value) : base(value)
    {
    }

    public static readonly IncludeDetails True = new("true");

    public static readonly IncludeDetails False = new("false");

    public TResult Match<TResult>(Func<TResult> onTrue, Func<TResult> onFalse, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == True => onTrue(),
            _ when this == False => onFalse(),
            _ => otherwise(Value)
        };

    public void Match(Action onTrue, Action onFalse, Action<string> otherwise)
    {
        if (this == True) onTrue();
        else if (this == False) onFalse();
        else otherwise(Value);
    }
}
