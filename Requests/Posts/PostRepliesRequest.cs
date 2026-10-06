namespace Discourse.Requests.Posts;

/// <summary>
/// The inputs of the PostReplies operation.
/// </summary>
public sealed record PostRepliesRequest
{
    public required string Id { get; init; }
}
