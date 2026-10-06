using Discourse.Models;

namespace Discourse.Requests.Users;

/// <summary>
/// The inputs of the DeleteUser operation.
/// </summary>
public sealed record DeleteUserRequest
{
    public required int Id { get; init; }

    public AdminUsersJsonRequest? Body { get; init; }
}
