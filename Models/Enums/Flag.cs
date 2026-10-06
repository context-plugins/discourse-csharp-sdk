using System;
using System.Text.Json.Serialization;
using Discourse.Core.Enum;

namespace Discourse.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Flag>))]
public sealed record Flag : OpenStringEnum<Flag>
{
    private Flag(string value) : base(value)
    {
    }

    public static readonly Flag Active = new("active");

    public static readonly Flag New = new("new");

    public static readonly Flag Staff = new("staff");

    public static readonly Flag Suspended = new("suspended");

    public static readonly Flag Blocked = new("blocked");

    public static readonly Flag Suspect = new("suspect");

    public TResult Match<TResult>(Func<TResult> onActive,
        Func<TResult> onNew,
        Func<TResult> onStaff,
        Func<TResult> onSuspended,
        Func<TResult> onBlocked,
        Func<TResult> onSuspect,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Active => onActive(),
            _ when this == New => onNew(),
            _ when this == Staff => onStaff(),
            _ when this == Suspended => onSuspended(),
            _ when this == Blocked => onBlocked(),
            _ when this == Suspect => onSuspect(),
            _ => otherwise(Value)
        };

    public void Match(Action onActive,
        Action onNew,
        Action onStaff,
        Action onSuspended,
        Action onBlocked,
        Action onSuspect,
        Action<string> otherwise)
    {
        if (this == Active) onActive();
        else if (this == New) onNew();
        else if (this == Staff) onStaff();
        else if (this == Suspended) onSuspended();
        else if (this == Blocked) onBlocked();
        else if (this == Suspect) onSuspect();
        else otherwise(Value);
    }
}
