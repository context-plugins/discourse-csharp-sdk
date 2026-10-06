using Discourse.Models;

namespace Discourse.Requests.Posts;

/// <summary>
/// The inputs of the CreateTopicPostPm operation.
/// </summary>
public sealed record CreateTopicPostPmRequest
{
    public required string ApiKey { get; init; }

    public required string ApiUsername { get; init; }

    public PostsJsonRequest? Body { get; init; }
}
