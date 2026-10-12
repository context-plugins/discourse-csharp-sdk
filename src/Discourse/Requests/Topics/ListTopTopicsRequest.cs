namespace Discourse.Requests.Topics;

/// <summary>
/// The inputs of the ListTopTopics operation.
/// </summary>
public sealed record ListTopTopicsRequest
{
    /// <summary>
    /// Enum: <c>all</c>, <c>yearly</c>, <c>quarterly</c>, <c>monthly</c>, <c>weekly</c>, <c>daily</c>
    /// </summary>
    public string? Period { get; init; }

    /// <summary>
    /// Maximum number of topics returned, between 1-100
    /// </summary>
    public int? PerPage { get; init; }

    public required string ApiKey { get; init; }

    public required string ApiUsername { get; init; }
}
