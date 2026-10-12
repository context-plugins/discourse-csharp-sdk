namespace Discourse.Requests.Users;

/// <summary>
/// The inputs of the LogOutUser operation.
/// </summary>
public sealed record LogOutUserRequest
{
    public required int Id { get; init; }
}
