using Discourse.Models;

namespace Discourse.Requests.Users;

/// <summary>
/// The inputs of the UpdateUser operation.
/// </summary>
public sealed record UpdateUserRequest
{
    public required string Username { get; init; }

    public required string ApiKey { get; init; }

    public required string ApiUsername { get; init; }

    public UJsonRequest? Body { get; init; }
}
