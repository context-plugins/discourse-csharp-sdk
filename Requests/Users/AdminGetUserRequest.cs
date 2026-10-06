namespace Discourse.Requests.Users;

/// <summary>
/// The inputs of the AdminGetUser operation.
/// </summary>
public sealed record AdminGetUserRequest
{
    public required int Id { get; init; }
}
