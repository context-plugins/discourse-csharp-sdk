using Discourse.Models;

namespace Discourse.Requests.Invites;

/// <summary>
/// The inputs of the CreateInvite operation.
/// </summary>
public sealed record CreateInviteRequest
{
    public required string ApiKey { get; init; }

    public required string ApiUsername { get; init; }

    public InvitesJsonRequest? Body { get; init; }
}
