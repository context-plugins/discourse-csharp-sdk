using System;
using System.Text.Json.Serialization;
using Discourse.Core.Enum;

namespace Discourse.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Period1>))]
public sealed record Period1 : OpenStringEnum<Period1>
{
    private Period1(string value) : base(value)
    {
    }

    public static readonly Period1 Daily = new("daily");

    public static readonly Period1 Weekly = new("weekly");

    public static readonly Period1 Monthly = new("monthly");

    public static readonly Period1 Quarterly = new("quarterly");

    public static readonly Period1 Yearly = new("yearly");

    public static readonly Period1 All = new("all");

    public TResult Match<TResult>(Func<TResult> onDaily,
        Func<TResult> onWeekly,
        Func<TResult> onMonthly,
        Func<TResult> onQuarterly,
        Func<TResult> onYearly,
        Func<TResult> onAll,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Daily => onDaily(),
            _ when this == Weekly => onWeekly(),
            _ when this == Monthly => onMonthly(),
            _ when this == Quarterly => onQuarterly(),
            _ when this == Yearly => onYearly(),
            _ when this == All => onAll(),
            _ => otherwise(Value)
        };

    public void Match(Action onDaily,
        Action onWeekly,
        Action onMonthly,
        Action onQuarterly,
        Action onYearly,
        Action onAll,
        Action<string> otherwise)
    {
        if (this == Daily) onDaily();
        else if (this == Weekly) onWeekly();
        else if (this == Monthly) onMonthly();
        else if (this == Quarterly) onQuarterly();
        else if (this == Yearly) onYearly();
        else if (this == All) onAll();
        else otherwise(Value);
    }
}
