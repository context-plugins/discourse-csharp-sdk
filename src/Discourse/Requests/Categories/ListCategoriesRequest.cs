namespace Discourse.Requests.Categories;

/// <summary>
/// The inputs of the ListCategories operation.
/// </summary>
public sealed record ListCategoriesRequest
{
    public bool? IncludeSubcategories { get; init; }
}
