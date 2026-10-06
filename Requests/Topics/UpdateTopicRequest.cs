using Discourse.Models;

namespace Discourse.Requests.Topics;

/// <summary>
/// The inputs of the UpdateTopic operation.
/// </summary>
public sealed record UpdateTopicRequest
{
    public required string Id { get; init; }

    public required string ApiKey { get; init; }

    public required string ApiUsername { get; init; }

    public TJsonRequest? Body { get; init; }
}
