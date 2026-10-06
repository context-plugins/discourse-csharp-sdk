<!-- Generated file — do not edit; regenerated with the SDK. -->

# Categories — operations

Accessor: `client.Categories` · Source: `Api/Categories.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateCategory

- **Signature**: `CreateCategory(CreateCategoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CategoriesJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateCategoryRequest` | `Requests/Categories/CreateCategoryRequest.cs` |
| `CategoriesJsonRequest` | `Models/CategoriesJsonRequest.cs` |
| `CategoriesJsonResponse` | `Models/CategoriesJsonResponse.cs` |

### GetCategory

- **Signature**: `GetCategory(GetCategoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `CShowJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetCategoryRequest` | `Requests/Categories/GetCategoryRequest.cs` |
| `CShowJsonResponse` | `Models/CShowJsonResponse.cs` |

### GetSite

- **Signature**: `GetSite(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SiteJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SiteJsonResponse` | `Models/SiteJsonResponse.cs` |

### ListCategories

- **Signature**: `ListCategories(ListCategoriesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include_subcategories` ← `IncludeSubcategories`
- **Returns**: `CategoriesJsonResponse1`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCategoriesRequest` | `Requests/Categories/ListCategoriesRequest.cs` |
| `CategoriesJsonResponse1` | `Models/CategoriesJsonResponse1.cs` |

### ListCategoryTopics

- **Signature**: `ListCategoryTopics(ListCategoryTopicsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Slug`, `Id`
- **Returns**: `CJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCategoryTopicsRequest` | `Requests/Categories/ListCategoryTopicsRequest.cs` |
| `CJsonResponse` | `Models/CJsonResponse.cs` |

### UpdateCategory

- **Signature**: `UpdateCategory(UpdateCategoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `CategoriesJsonResponse2`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateCategoryRequest` | `Requests/Categories/UpdateCategoryRequest.cs` |
| `CategoriesJsonRequest1` | `Models/CategoriesJsonRequest1.cs` |
| `CategoriesJsonResponse2` | `Models/CategoriesJsonResponse2.cs` |

