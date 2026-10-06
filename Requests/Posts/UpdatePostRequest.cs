using Discourse.Models;

namespace Discourse.Requests.Posts;

/// <summary>
/// The inputs of the UpdatePost operation.
/// </summary>
public sealed record UpdatePostRequest
{
    public required string Id { get; init; }

    public required string ApiKey { get; init; }

    public required string ApiUsername { get; init; }

    public PostsJsonRequest1? Body { get; init; }
}
