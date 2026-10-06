using System;
using System.Text.Json.Serialization;
using Discourse.Core.Enum;

namespace Discourse.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Reason>))]
public sealed record Reason : OpenStringEnum<Reason>
{
    private Reason(string value) : base(value)
    {
    }

    public static readonly Reason EnabledForEveryone = new("enabled_for_everyone");

    public static readonly Reason EnabledForNoOne = new("enabled_for_no_one");

    public static readonly Reason InSpecificGroups = new("in_specific_groups");

    public static readonly Reason NotInSpecificGroups = new("not_in_specific_groups");

    public TResult Match<TResult>(Func<TResult> onEnabledForEveryone,
        Func<TResult> onEnabledForNoOne,
        Func<TResult> onInSpecificGroups,
        Func<TResult> onNotInSpecificGroups,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == EnabledForEveryone => onEnabledForEveryone(),
            _ when this == EnabledForNoOne => onEnabledForNoOne(),
            _ when this == InSpecificGroups => onInSpecificGroups(),
            _ when this == NotInSpecificGroups => onNotInSpecificGroups(),
            _ => otherwise(Value)
        };

    public void Match(Action onEnabledForEveryone,
        Action onEnabledForNoOne,
        Action onInSpecificGroups,
        Action onNotInSpecificGroups,
        Action<string> otherwise)
    {
        if (this == EnabledForEveryone) onEnabledForEveryone();
        else if (this == EnabledForNoOne) onEnabledForNoOne();
        else if (this == InSpecificGroups) onInSpecificGroups();
        else if (this == NotInSpecificGroups) onNotInSpecificGroups();
        else otherwise(Value);
    }
}
