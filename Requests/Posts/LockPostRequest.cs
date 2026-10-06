using Discourse.Models;

namespace Discourse.Requests.Posts;

/// <summary>
/// The inputs of the LockPost operation.
/// </summary>
public sealed record LockPostRequest
{
    public required string Id { get; init; }

    public required string ApiKey { get; init; }

    public required string ApiUsername { get; init; }

    public PostsLockedJsonRequest? Body { get; init; }
}
