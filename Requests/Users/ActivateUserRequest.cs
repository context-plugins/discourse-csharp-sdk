namespace Discourse.Requests.Users;

/// <summary>
/// The inputs of the ActivateUser operation.
/// </summary>
public sealed record ActivateUserRequest
{
    public required int Id { get; init; }
}
