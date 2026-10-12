using Discourse.Models;

namespace Discourse.Requests.Invites;

/// <summary>
/// The inputs of the CreateMultipleInvites operation.
/// </summary>
public sealed record CreateMultipleInvitesRequest
{
    public required string ApiKey { get; init; }

    public required string ApiUsername { get; init; }

    public InvitesCreateMultipleJsonRequest? Body { get; init; }
}
