using Discourse.Models;

namespace Discourse.Requests.Users;

/// <summary>
/// The inputs of the CreateUser operation.
/// </summary>
public sealed record CreateUserRequest
{
    public required string ApiKey { get; init; }

    public required string ApiUsername { get; init; }

    public UsersJsonRequest? Body { get; init; }
}
