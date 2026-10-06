namespace Discourse.Requests.Categories;

/// <summary>
/// The inputs of the ListCategoryTopics operation.
/// </summary>
public sealed record ListCategoryTopicsRequest
{
    public required string Slug { get; init; }

    public required int Id { get; init; }
}
