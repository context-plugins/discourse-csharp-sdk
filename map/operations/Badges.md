<!-- Generated file — do not edit; regenerated with the SDK. -->

# Badges — operations

Accessor: `client.Badges` · Source: `Api/Badges.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminListBadges

- **Signature**: `AdminListBadges(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AdminBadgesJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminBadgesJsonResponse` | `Models/AdminBadgesJsonResponse.cs` |

### CreateBadge

- **Signature**: `CreateBadge(AdminBadgesJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `AdminBadgesJsonResponse1`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminBadgesJsonRequest` | `Models/AdminBadgesJsonRequest.cs` |
| `AdminBadgesJsonResponse1` | `Models/AdminBadgesJsonResponse1.cs` |

### DeleteBadge

- **Signature**: `DeleteBadge(int id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### ListUserBadges

- **Signature**: `ListUserBadges(string username, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UserBadgesJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserBadgesJsonResponse` | `Models/UserBadgesJsonResponse.cs` |

### UpdateBadge

- **Signature**: `UpdateBadge(int id, AdminBadgesJsonRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `AdminBadgesJsonResponse2`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminBadgesJsonRequest1` | `Models/AdminBadgesJsonRequest1.cs` |
| `AdminBadgesJsonResponse2` | `Models/AdminBadgesJsonResponse2.cs` |

