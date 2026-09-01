<!-- Generated file — do not edit; regenerated with the SDK. -->

# Categories — operations

Accessor: `client.Categories` · Source: `Api/Categories.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateCategory

- **Signature**: `CreateCategory(CategoriesJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `CategoriesJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CategoriesJsonRequest` | `Models/CategoriesJsonRequest.cs` |
| `CategoriesJsonResponse` | `Models/CategoriesJsonResponse.cs` |

### GetCategory

- **Signature**: `GetCategory(int id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CShowJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CShowJsonResponse` | `Models/CShowJsonResponse.cs` |

### GetSite

- **Signature**: `GetSite(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SiteJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SiteJsonResponse` | `Models/SiteJsonResponse.cs` |

### ListCategories

- **Signature**: `ListCategories(bool? includeSubcategories, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `includeSubcategories` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `include_subcategories` ← `includeSubcategories`
- **Returns**: `CategoriesJsonResponse1`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CategoriesJsonResponse1` | `Models/CategoriesJsonResponse1.cs` |

### ListCategoryTopics

- **Signature**: `ListCategoryTopics(string slug, int id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CJsonResponse` | `Models/CJsonResponse.cs` |

### UpdateCategory

- **Signature**: `UpdateCategory(int id, CategoriesJsonRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `CategoriesJsonResponse2`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CategoriesJsonRequest1` | `Models/CategoriesJsonRequest1.cs` |
| `CategoriesJsonResponse2` | `Models/CategoriesJsonResponse2.cs` |

