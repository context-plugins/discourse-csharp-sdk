namespace Discourse.Requests.Categories;

/// <summary>
/// The inputs of the GetCategory operation.
/// </summary>
public sealed record GetCategoryRequest
{
    public required int Id { get; init; }
}
