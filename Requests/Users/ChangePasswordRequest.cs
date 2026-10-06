using Discourse.Models;

namespace Discourse.Requests.Users;

/// <summary>
/// The inputs of the ChangePassword operation.
/// </summary>
public sealed record ChangePasswordRequest
{
    public required string Token { get; init; }

    public UsersPasswordResetJsonRequest? Body { get; init; }
}
