namespace Discourse.Requests.Users;

/// <summary>
/// The inputs of the DeactivateUser operation.
/// </summary>
public sealed record DeactivateUserRequest
{
    public required int Id { get; init; }
}
