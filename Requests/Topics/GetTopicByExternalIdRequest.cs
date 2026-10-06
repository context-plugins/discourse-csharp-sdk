namespace Discourse.Requests.Topics;

/// <summary>
/// The inputs of the GetTopicByExternalId operation.
/// </summary>
public sealed record GetTopicByExternalIdRequest
{
    public required string ExternalId { get; init; }
}
