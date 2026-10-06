namespace Discourse.Requests.Users;

/// <summary>
/// The inputs of the AnonymizeUser operation.
/// </summary>
public sealed record AnonymizeUserRequest
{
    public required int Id { get; init; }
}
