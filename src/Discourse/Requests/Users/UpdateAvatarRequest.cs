using Discourse.Models;

namespace Discourse.Requests.Users;

/// <summary>
/// The inputs of the UpdateAvatar operation.
/// </summary>
public sealed record UpdateAvatarRequest
{
    public required string Username { get; init; }

    public UPreferencesAvatarPickJsonRequest? Body { get; init; }
}
