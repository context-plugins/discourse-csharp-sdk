namespace Discourse.Requests.Posts;

/// <summary>
/// The inputs of the ListPosts operation.
/// </summary>
public sealed record ListPostsRequest
{
    /// <summary>
    /// Load posts with an id lower than this value. Useful for pagination.
    /// </summary>
    public int? Before { get; init; }
}
