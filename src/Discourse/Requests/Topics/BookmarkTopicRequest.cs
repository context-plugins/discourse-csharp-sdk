namespace Discourse.Requests.Topics;

/// <summary>
/// The inputs of the BookmarkTopic operation.
/// </summary>
public sealed record BookmarkTopicRequest
{
    public required string Id { get; init; }

    public required string ApiKey { get; init; }

    public required string ApiUsername { get; init; }
}
