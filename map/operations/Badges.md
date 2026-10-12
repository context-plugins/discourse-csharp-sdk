<!-- Generated file — do not edit; regenerated with the SDK. -->

# Badges — operations

Accessor: `client.Badges` · Source: `src/Discourse/Api/Badges.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminListBadges

- **Signature**: `AdminListBadges(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `AdminBadgesJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminBadgesJsonResponse` | `src/Discourse/Models/AdminBadgesJsonResponse.cs` |

### CreateBadge

- **Signature**: `CreateBadge(CreateBadgeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `AdminBadgesJsonResponse1`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateBadgeRequest` | `src/Discourse/Requests/Badges/CreateBadgeRequest.cs` |
| `AdminBadgesJsonRequest` | `src/Discourse/Models/AdminBadgesJsonRequest.cs` |
| `AdminBadgesJsonResponse1` | `src/Discourse/Models/AdminBadgesJsonResponse1.cs` |

### DeleteBadge

- **Signature**: `DeleteBadge(DeleteBadgeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteBadgeRequest` | `src/Discourse/Requests/Badges/DeleteBadgeRequest.cs` |

### ListUserBadges

- **Signature**: `ListUserBadges(ListUserBadgesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Username`
- **Returns**: `UserBadgesJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListUserBadgesRequest` | `src/Discourse/Requests/Badges/ListUserBadgesRequest.cs` |
| `UserBadgesJsonResponse` | `src/Discourse/Models/UserBadgesJsonResponse.cs` |

### UpdateBadge

- **Signature**: `UpdateBadge(UpdateBadgeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AdminBadgesJsonResponse2`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateBadgeRequest` | `src/Discourse/Requests/Badges/UpdateBadgeRequest.cs` |
| `AdminBadgesJsonRequest1` | `src/Discourse/Models/AdminBadgesJsonRequest1.cs` |
| `AdminBadgesJsonResponse2` | `src/Discourse/Models/AdminBadgesJsonResponse2.cs` |

