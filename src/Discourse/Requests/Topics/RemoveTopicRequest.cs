namespace Discourse.Requests.Topics;

/// <summary>
/// The inputs of the RemoveTopic operation.
/// </summary>
public sealed record RemoveTopicRequest
{
    public required string Id { get; init; }

    public required string ApiKey { get; init; }

    public required string ApiUsername { get; init; }
}
