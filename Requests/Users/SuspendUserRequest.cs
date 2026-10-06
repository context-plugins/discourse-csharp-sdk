using Discourse.Models;

namespace Discourse.Requests.Users;

/// <summary>
/// The inputs of the SuspendUser operation.
/// </summary>
public sealed record SuspendUserRequest
{
    public required int Id { get; init; }

    public AdminUsersSuspendJsonRequest? Body { get; init; }
}
