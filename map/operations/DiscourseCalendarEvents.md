<!-- Generated file — do not edit; regenerated with the SDK. -->

# DiscourseCalendarEvents — operations

Accessor: `client.DiscourseCalendarEvents` · Source: `src/Discourse/Api/DiscourseCalendarEvents.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ExportEventsIcs

- **Signature**: `ExportEventsIcs(ExportEventsIcsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `category_id` ← `CategoryId`, `include_subcategories` ← `IncludeSubcategories`, `attending_user` ← `AttendingUser`, `before` ← `Before`, `after` ← `After`, `order` ← `Order`, `limit` ← `Limit`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ExportEventsIcsRequest` | `src/Discourse/Requests/DiscourseCalendarEvents/ExportEventsIcsRequest.cs` |
| `IncludeSubcategories` | `src/Discourse/Models/Enums/IncludeSubcategories.cs` |
| `Order` | `src/Discourse/Models/Enums/Order.cs` |

### ListEvents

- **Signature**: `ListEvents(ListEventsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include_details` ← `IncludeDetails`, `category_id` ← `CategoryId`, `include_subcategories` ← `IncludeSubcategories`, `post_id` ← `PostId`, `attending_user` ← `AttendingUser`, `before` ← `Before`, `after` ← `After`, `order` ← `Order`, `limit` ← `Limit`
- **Returns**: `DiscoursePostEventEventsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListEventsRequest` | `src/Discourse/Requests/DiscourseCalendarEvents/ListEventsRequest.cs` |
| `IncludeDetails` | `src/Discourse/Models/Enums/IncludeDetails.cs` |
| `IncludeSubcategories` | `src/Discourse/Models/Enums/IncludeSubcategories.cs` |
| `Order` | `src/Discourse/Models/Enums/Order.cs` |
| `DiscoursePostEventEventsJsonResponse` | `src/Discourse/Models/DiscoursePostEventEventsJsonResponse.cs` |

