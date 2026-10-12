using System;
using System.Text.Json.Serialization;
using Discourse.Core.Enum;

namespace Discourse.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<NotificationLevel>))]
public sealed record NotificationLevel : OpenStringEnum<NotificationLevel>
{
    private NotificationLevel(string value) : base(value)
    {
    }

    public static readonly NotificationLevel _0 = new("0");

    public static readonly NotificationLevel _1 = new("1");

    public static readonly NotificationLevel _2 = new("2");

    public static readonly NotificationLevel _3 = new("3");

    public TResult Match<TResult>(Func<TResult> on_0,
        Func<TResult> on_1,
        Func<TResult> on_2,
        Func<TResult> on_3,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _0 => on_0(),
            _ when this == _1 => on_1(),
            _ when this == _2 => on_2(),
            _ when this == _3 => on_3(),
            _ => otherwise(Value)
        };

    public void Match(Action on_0, Action on_1, Action on_2, Action on_3, Action<string> otherwise)
    {
        if (this == _0) on_0();
        else if (this == _1) on_1();
        else if (this == _2) on_2();
        else if (this == _3) on_3();
        else otherwise(Value);
    }
}
