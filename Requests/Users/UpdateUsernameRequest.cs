using Discourse.Models;

namespace Discourse.Requests.Users;

/// <summary>
/// The inputs of the UpdateUsername operation.
/// </summary>
public sealed record UpdateUsernameRequest
{
    public required string Username { get; init; }

    public UPreferencesUsernameJsonRequest? Body { get; init; }
}
