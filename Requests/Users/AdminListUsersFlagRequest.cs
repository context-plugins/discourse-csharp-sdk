using Discourse.Models.Enums;

namespace Discourse.Requests.Users;

/// <summary>
/// The inputs of the AdminListUsersFlag operation.
/// </summary>
public sealed record AdminListUsersFlagRequest
{
    public required Flag Flag { get; init; }

    public Order3? Order { get; init; }

    public Asc? Asc { get; init; }

    public int? Page { get; init; }

    /// <summary>
    /// Include user email addresses in response. These requests will
    /// be logged in the staff action logs.
    /// </summary>
    public bool? ShowEmails { get; init; }

    /// <summary>
    /// Include user stats information
    /// </summary>
    public bool? Stats { get; init; }

    /// <summary>
    /// Filter to the user with this email address
    /// </summary>
    public string? Email { get; init; }

    /// <summary>
    /// Filter to users with this IP address
    /// </summary>
    public string? Ip { get; init; }
}
