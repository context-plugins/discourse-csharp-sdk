namespace Discourse.Requests.Users;

/// <summary>
/// The inputs of the RefreshGravatar operation.
/// </summary>
public sealed record RefreshGravatarRequest
{
    public required string Username { get; init; }
}
