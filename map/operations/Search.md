<!-- Generated file — do not edit; regenerated with the SDK. -->

# Search — operations

Accessor: `client.Search` · Source: `Api/Search.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SearchInvoke

- **Signature**: `SearchInvoke(string? q, int? page, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `q` — nullable, no default → **must pass explicitly**
  - `page` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `q` ← `q`, `page` ← `page`
- **Returns**: `SearchJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchJsonResponse` | `Models/SearchJsonResponse.cs` |

