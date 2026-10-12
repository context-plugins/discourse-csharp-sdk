using Discourse.Models;

namespace Discourse.Requests.Users;

/// <summary>
/// The inputs of the UpdateEmail operation.
/// </summary>
public sealed record UpdateEmailRequest
{
    public required string Username { get; init; }

    public UPreferencesEmailJsonRequest? Body { get; init; }
}
