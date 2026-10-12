using Discourse.Models;

namespace Discourse.Requests.Topics;

/// <summary>
/// The inputs of the CreateTopicTimer operation.
/// </summary>
public sealed record CreateTopicTimerRequest
{
    public required string Id { get; init; }

    public required string ApiKey { get; init; }

    public required string ApiUsername { get; init; }

    public TTimerJsonRequest? Body { get; init; }
}
