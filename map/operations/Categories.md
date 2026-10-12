<!-- Generated file — do not edit; regenerated with the SDK. -->

# Categories — operations

Accessor: `client.Categories` · Source: `src/Discourse/Api/Categories.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateCategory

- **Signature**: `CreateCategory(CreateCategoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CategoriesJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateCategoryRequest` | `src/Discourse/Requests/Categories/CreateCategoryRequest.cs` |
| `CategoriesJsonRequest` | `src/Discourse/Models/CategoriesJsonRequest.cs` |
| `CategoriesJsonResponse` | `src/Discourse/Models/CategoriesJsonResponse.cs` |

### GetCategory

- **Signature**: `GetCategory(GetCategoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `CShowJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetCategoryRequest` | `src/Discourse/Requests/Categories/GetCategoryRequest.cs` |
| `CShowJsonResponse` | `src/Discourse/Models/CShowJsonResponse.cs` |

### GetSite

- **Signature**: `GetSite(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SiteJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SiteJsonResponse` | `src/Discourse/Models/SiteJsonResponse.cs` |

### ListCategories

- **Signature**: `ListCategories(ListCategoriesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include_subcategories` ← `IncludeSubcategories`
- **Returns**: `CategoriesJsonResponse1`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCategoriesRequest` | `src/Discourse/Requests/Categories/ListCategoriesRequest.cs` |
| `CategoriesJsonResponse1` | `src/Discourse/Models/CategoriesJsonResponse1.cs` |

### ListCategoryTopics

- **Signature**: `ListCategoryTopics(ListCategoryTopicsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Slug`, `Id`
- **Returns**: `CJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCategoryTopicsRequest` | `src/Discourse/Requests/Categories/ListCategoryTopicsRequest.cs` |
| `CJsonResponse` | `src/Discourse/Models/CJsonResponse.cs` |

### UpdateCategory

- **Signature**: `UpdateCategory(UpdateCategoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `CategoriesJsonResponse2`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateCategoryRequest` | `src/Discourse/Requests/Categories/UpdateCategoryRequest.cs` |
| `CategoriesJsonRequest1` | `src/Discourse/Models/CategoriesJsonRequest1.cs` |
| `CategoriesJsonResponse2` | `src/Discourse/Models/CategoriesJsonResponse2.cs` |

