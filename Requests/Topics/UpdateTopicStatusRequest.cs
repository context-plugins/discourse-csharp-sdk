using Discourse.Models;

namespace Discourse.Requests.Topics;

/// <summary>
/// The inputs of the UpdateTopicStatus operation.
/// </summary>
public sealed record UpdateTopicStatusRequest
{
    public required string Id { get; init; }

    public required string ApiKey { get; init; }

    public required string ApiUsername { get; init; }

    public TStatusJsonRequest? Body { get; init; }
}
