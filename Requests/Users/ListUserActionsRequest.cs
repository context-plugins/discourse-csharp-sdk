namespace Discourse.Requests.Users;

/// <summary>
/// The inputs of the ListUserActions operation.
/// </summary>
public sealed record ListUserActionsRequest
{
    public required int Offset { get; init; }

    public required string Username { get; init; }

    public required string Filter { get; init; }
}
