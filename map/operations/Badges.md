<!-- Generated file — do not edit; regenerated with the SDK. -->

# Badges — operations

Accessor: `client.Badges` · Source: `Api/Badges.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminListBadges

- **Signature**: `AdminListBadges(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `AdminBadgesJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminBadgesJsonResponse` | `Models/AdminBadgesJsonResponse.cs` |

### CreateBadge

- **Signature**: `CreateBadge(CreateBadgeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `AdminBadgesJsonResponse1`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateBadgeRequest` | `Requests/Badges/CreateBadgeRequest.cs` |
| `AdminBadgesJsonRequest` | `Models/AdminBadgesJsonRequest.cs` |
| `AdminBadgesJsonResponse1` | `Models/AdminBadgesJsonResponse1.cs` |

### DeleteBadge

- **Signature**: `DeleteBadge(DeleteBadgeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteBadgeRequest` | `Requests/Badges/DeleteBadgeRequest.cs` |

### ListUserBadges

- **Signature**: `ListUserBadges(ListUserBadgesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Username`
- **Returns**: `UserBadgesJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListUserBadgesRequest` | `Requests/Badges/ListUserBadgesRequest.cs` |
| `UserBadgesJsonResponse` | `Models/UserBadgesJsonResponse.cs` |

### UpdateBadge

- **Signature**: `UpdateBadge(UpdateBadgeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AdminBadgesJsonResponse2`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateBadgeRequest` | `Requests/Badges/UpdateBadgeRequest.cs` |
| `AdminBadgesJsonRequest1` | `Models/AdminBadgesJsonRequest1.cs` |
| `AdminBadgesJsonResponse2` | `Models/AdminBadgesJsonResponse2.cs` |

