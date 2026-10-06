using Discourse.Models;

namespace Discourse.Requests.Topics;

/// <summary>
/// The inputs of the InviteGroupToTopic operation.
/// </summary>
public sealed record InviteGroupToTopicRequest
{
    public required string Id { get; init; }

    public required string ApiKey { get; init; }

    public required string ApiUsername { get; init; }

    public TInviteGroupJsonRequest? Body { get; init; }
}
