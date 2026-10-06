namespace Discourse.Requests.Topics;

/// <summary>
/// The inputs of the GetSpecificPostsFromTopic operation.
/// </summary>
public sealed record GetSpecificPostsFromTopicRequest
{
    public required string Id { get; init; }

    public required string ApiKey { get; init; }

    public required string ApiUsername { get; init; }
}
