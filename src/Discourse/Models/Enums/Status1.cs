using System;
using System.Text.Json.Serialization;
using Discourse.Core.Enum;

namespace Discourse.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Status1>))]
public sealed record Status1 : OpenStringEnum<Status1>
{
    private Status1(string value) : base(value)
    {
    }

    public static readonly Status1 Closed = new("closed");

    public static readonly Status1 Pinned = new("pinned");

    public static readonly Status1 PinnedGlobally = new("pinned_globally");

    public static readonly Status1 Archived = new("archived");

    public static readonly Status1 Visible = new("visible");

    public TResult Match<TResult>(Func<TResult> onClosed,
        Func<TResult> onPinned,
        Func<TResult> onPinnedGlobally,
        Func<TResult> onArchived,
        Func<TResult> onVisible,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Closed => onClosed(),
            _ when this == Pinned => onPinned(),
            _ when this == PinnedGlobally => onPinnedGlobally(),
            _ when this == Archived => onArchived(),
            _ when this == Visible => onVisible(),
            _ => otherwise(Value)
        };

    public void Match(Action onClosed,
        Action onPinned,
        Action onPinnedGlobally,
        Action onArchived,
        Action onVisible,
        Action<string> otherwise)
    {
        if (this == Closed) onClosed();
        else if (this == Pinned) onPinned();
        else if (this == PinnedGlobally) onPinnedGlobally();
        else if (this == Archived) onArchived();
        else if (this == Visible) onVisible();
        else otherwise(Value);
    }
}
