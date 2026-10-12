<!-- Generated file — do not edit; regenerated with the SDK. -->

# Admin — operations

Accessor: `client.Admin` · Source: `src/Discourse/Api/Admin.cs` · 11 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ActivateUser

- **Signature**: `ActivateUser(ActivateUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AdminUsersActivateJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ActivateUserRequest` | `src/Discourse/Requests/Users/ActivateUserRequest.cs` |
| `AdminUsersActivateJsonResponse` | `src/Discourse/Models/AdminUsersActivateJsonResponse.cs` |

### AdminGetUser

- **Signature**: `AdminGetUser(AdminGetUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AdminUsersJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminGetUserRequest` | `src/Discourse/Requests/Users/AdminGetUserRequest.cs` |
| `AdminUsersJsonResponse` | `src/Discourse/Models/AdminUsersJsonResponse.cs` |

### AdminListUsers

- **Signature**: `AdminListUsers(AdminListUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `order` ← `Order`, `asc` ← `Asc`, `page` ← `Page`, `show_emails` ← `ShowEmails`, `stats` ← `Stats`, `email` ← `Email`, `ip` ← `Ip`
- **Returns**: `IReadOnlyList<AdminUsersJsonResponse2>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminListUsersRequest` | `src/Discourse/Requests/Users/AdminListUsersRequest.cs` |
| `Order3` | `src/Discourse/Models/Enums/Order3.cs` |
| `Asc` | `src/Discourse/Models/Enums/Asc.cs` |
| `AdminUsersJsonResponse2` | `src/Discourse/Models/AdminUsersJsonResponse2.cs` |

### AdminListUsersFlag

- **Signature**: `AdminListUsersFlag(AdminListUsersFlagRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Flag`
- **Query params (wire ← C#)**: `order` ← `Order`, `asc` ← `Asc`, `page` ← `Page`, `show_emails` ← `ShowEmails`, `stats` ← `Stats`, `email` ← `Email`, `ip` ← `Ip`
- **Returns**: `IReadOnlyList<AdminUsersListJsonResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminListUsersFlagRequest` | `src/Discourse/Requests/Users/AdminListUsersFlagRequest.cs` |
| `Flag` | `src/Discourse/Models/Enums/Flag.cs` |
| `Order3` | `src/Discourse/Models/Enums/Order3.cs` |
| `Asc` | `src/Discourse/Models/Enums/Asc.cs` |
| `AdminUsersListJsonResponse` | `src/Discourse/Models/AdminUsersListJsonResponse.cs` |

### AnonymizeUser

- **Signature**: `AnonymizeUser(AnonymizeUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AdminUsersAnonymizeJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AnonymizeUserRequest` | `src/Discourse/Requests/Users/AnonymizeUserRequest.cs` |
| `AdminUsersAnonymizeJsonResponse` | `src/Discourse/Models/AdminUsersAnonymizeJsonResponse.cs` |

### DeactivateUser

- **Signature**: `DeactivateUser(DeactivateUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AdminUsersDeactivateJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeactivateUserRequest` | `src/Discourse/Requests/Users/DeactivateUserRequest.cs` |
| `AdminUsersDeactivateJsonResponse` | `src/Discourse/Models/AdminUsersDeactivateJsonResponse.cs` |

### DeleteUser

- **Signature**: `DeleteUser(DeleteUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AdminUsersJsonResponse1`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteUserRequest` | `src/Discourse/Requests/Users/DeleteUserRequest.cs` |
| `AdminUsersJsonRequest` | `src/Discourse/Models/AdminUsersJsonRequest.cs` |
| `AdminUsersJsonResponse1` | `src/Discourse/Models/AdminUsersJsonResponse1.cs` |

### LogOutUser

- **Signature**: `LogOutUser(LogOutUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AdminUsersLogOutJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LogOutUserRequest` | `src/Discourse/Requests/Users/LogOutUserRequest.cs` |
| `AdminUsersLogOutJsonResponse` | `src/Discourse/Models/AdminUsersLogOutJsonResponse.cs` |

### RefreshGravatar

- **Signature**: `RefreshGravatar(RefreshGravatarRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Username`
- **Returns**: `UserAvatarRefreshGravatarJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RefreshGravatarRequest` | `src/Discourse/Requests/Users/RefreshGravatarRequest.cs` |
| `UserAvatarRefreshGravatarJsonResponse` | `src/Discourse/Models/UserAvatarRefreshGravatarJsonResponse.cs` |

### SilenceUser

- **Signature**: `SilenceUser(SilenceUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AdminUsersSilenceJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SilenceUserRequest` | `src/Discourse/Requests/Users/SilenceUserRequest.cs` |
| `AdminUsersSilenceJsonRequest` | `src/Discourse/Models/AdminUsersSilenceJsonRequest.cs` |
| `AdminUsersSilenceJsonResponse` | `src/Discourse/Models/AdminUsersSilenceJsonResponse.cs` |

### SuspendUser

- **Signature**: `SuspendUser(SuspendUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AdminUsersSuspendJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SuspendUserRequest` | `src/Discourse/Requests/Users/SuspendUserRequest.cs` |
| `AdminUsersSuspendJsonRequest` | `src/Discourse/Models/AdminUsersSuspendJsonRequest.cs` |
| `AdminUsersSuspendJsonResponse` | `src/Discourse/Models/AdminUsersSuspendJsonResponse.cs` |

