namespace Discourse.Requests.Users;

/// <summary>
/// The inputs of the GetUser operation.
/// </summary>
public sealed record GetUserRequest
{
    public required string Username { get; init; }

    public required string ApiKey { get; init; }

    public required string ApiUsername { get; init; }
}
