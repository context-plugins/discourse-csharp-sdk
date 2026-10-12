using Discourse.Models;

namespace Discourse.Requests.Topics;

/// <summary>
/// The inputs of the InviteToTopic operation.
/// </summary>
public sealed record InviteToTopicRequest
{
    public required string Id { get; init; }

    public required string ApiKey { get; init; }

    public required string ApiUsername { get; init; }

    public TInviteJsonRequest? Body { get; init; }
}
