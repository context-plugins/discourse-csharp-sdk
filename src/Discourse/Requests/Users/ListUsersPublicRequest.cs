using Discourse.Models.Enums;

namespace Discourse.Requests.Users;

/// <summary>
/// The inputs of the ListUsersPublic operation.
/// </summary>
public sealed record ListUsersPublicRequest
{
    public required Period1 Period { get; init; }

    public required Order2 Order { get; init; }

    public Asc? Asc { get; init; }

    public int? Page { get; init; }
}
