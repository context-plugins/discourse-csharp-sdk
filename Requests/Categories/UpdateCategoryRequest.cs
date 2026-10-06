using Discourse.Models;

namespace Discourse.Requests.Categories;

/// <summary>
/// The inputs of the UpdateCategory operation.
/// </summary>
public sealed record UpdateCategoryRequest
{
    public required int Id { get; init; }

    public CategoriesJsonRequest1? Body { get; init; }
}
