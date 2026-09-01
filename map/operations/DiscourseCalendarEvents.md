<!-- Generated file — do not edit; regenerated with the SDK. -->

# DiscourseCalendarEvents — operations

Accessor: `client.DiscourseCalendarEvents` · Source: `Api/DiscourseCalendarEvents.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ExportEventsIcs

- **Signature**: `ExportEventsIcs(int? categoryId, IncludeSubcategories? includeSubcategories, string? attendingUser, DateTimeOffset? before, DateTimeOffset? after, Order? order, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`categoryId` … `limit`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `category_id` ← `categoryId`, `include_subcategories` ← `includeSubcategories`, `attending_user` ← `attendingUser`, `before` ← `before`, `after` ← `after`, `order` ← `order`, `limit` ← `limit`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IncludeSubcategories` | `Models/Enums/IncludeSubcategories.cs` |
| `Order` | `Models/Enums/Order.cs` |

### ListEvents

- **Signature**: `ListEvents(IncludeDetails? includeDetails, int? categoryId, IncludeSubcategories? includeSubcategories, int? postId, string? attendingUser, DateTimeOffset? before, DateTimeOffset? after, Order? order, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 9 params (`includeDetails` … `limit`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `include_details` ← `includeDetails`, `category_id` ← `categoryId`, `include_subcategories` ← `includeSubcategories`, `post_id` ← `postId`, `attending_user` ← `attendingUser`, `before` ← `before`, `after` ← `after`, `order` ← `order`, `limit` ← `limit`
- **Returns**: `DiscoursePostEventEventsJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IncludeDetails` | `Models/Enums/IncludeDetails.cs` |
| `IncludeSubcategories` | `Models/Enums/IncludeSubcategories.cs` |
| `Order` | `Models/Enums/Order.cs` |
| `DiscoursePostEventEventsJsonResponse` | `Models/DiscoursePostEventEventsJsonResponse.cs` |

