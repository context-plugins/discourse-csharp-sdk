using Discourse.Models;

namespace Discourse.Requests.Categories;

/// <summary>
/// The inputs of the CreateCategory operation.
/// </summary>
public sealed record CreateCategoryRequest
{
    public CategoriesJsonRequest? Body { get; init; }
}
