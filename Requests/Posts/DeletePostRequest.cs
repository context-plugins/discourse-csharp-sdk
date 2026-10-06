using Discourse.Models;

namespace Discourse.Requests.Posts;

/// <summary>
/// The inputs of the DeletePost operation.
/// </summary>
public sealed record DeletePostRequest
{
    public required int Id { get; init; }

    public required string ApiKey { get; init; }

    public required string ApiUsername { get; init; }

    public PostsJsonRequest2? Body { get; init; }
}
