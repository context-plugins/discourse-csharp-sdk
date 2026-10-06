using System;
using System.Text.Json.Serialization;
using Discourse.Core.Enum;

namespace Discourse.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Status>))]
public sealed record Status : OpenStringEnum<Status>
{
    private Status(string value) : base(value)
    {
    }

    public static readonly Status Public = new("public");

    public static readonly Status Private = new("private");

    public static readonly Status Standalone = new("standalone");

    public TResult Match<TResult>(Func<TResult> onPublic,
        Func<TResult> onPrivate,
        Func<TResult> onStandalone,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Public => onPublic(),
            _ when this == Private => onPrivate(),
            _ when this == Standalone => onStandalone(),
            _ => otherwise(Value)
        };

    public void Match(Action onPublic, Action onPrivate, Action onStandalone, Action<string> otherwise)
    {
        if (this == Public) onPublic();
        else if (this == Private) onPrivate();
        else if (this == Standalone) onStandalone();
        else otherwise(Value);
    }
}
