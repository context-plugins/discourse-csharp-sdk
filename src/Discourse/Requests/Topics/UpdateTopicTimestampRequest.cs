using Discourse.Models;

namespace Discourse.Requests.Topics;

/// <summary>
/// The inputs of the UpdateTopicTimestamp operation.
/// </summary>
public sealed record UpdateTopicTimestampRequest
{
    public required string Id { get; init; }

    public required string ApiKey { get; init; }

    public required string ApiUsername { get; init; }

    public TChangeTimestampJsonRequest? Body { get; init; }
}
