using Discourse.Models;

namespace Discourse.Requests.Users;

/// <summary>
/// The inputs of the SilenceUser operation.
/// </summary>
public sealed record SilenceUserRequest
{
    public required int Id { get; init; }

    public AdminUsersSilenceJsonRequest? Body { get; init; }
}
