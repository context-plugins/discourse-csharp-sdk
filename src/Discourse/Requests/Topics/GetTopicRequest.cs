namespace Discourse.Requests.Topics;

/// <summary>
/// The inputs of the GetTopic operation.
/// </summary>
public sealed record GetTopicRequest
{
    public required string Id { get; init; }

    public required string ApiKey { get; init; }

    public required string ApiUsername { get; init; }
}
