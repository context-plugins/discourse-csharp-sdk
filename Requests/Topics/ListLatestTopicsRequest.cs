namespace Discourse.Requests.Topics;

/// <summary>
/// The inputs of the ListLatestTopics operation.
/// </summary>
public sealed record ListLatestTopicsRequest
{
    /// <summary>
    /// Enum: <c>default</c>, <c>created</c>, <c>activity</c>, <c>views</c>, <c>posts</c>, <c>category</c>,
    /// <c>likes</c>, <c>op_likes</c>, <c>posters</c>
    /// </summary>
    public string? Order { get; init; }

    /// <summary>
    /// Defaults to <c>desc</c>, add <c>ascending=true</c> to sort asc
    /// </summary>
    public string? Ascending { get; init; }

    /// <summary>
    /// Maximum number of topics returned, between 1-100
    /// </summary>
    public int? PerPage { get; init; }

    public required string ApiKey { get; init; }

    public required string ApiUsername { get; init; }
}
