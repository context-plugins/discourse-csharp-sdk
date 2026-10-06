<!-- Generated file — do not edit; regenerated with the SDK. -->

# Admin — operations

Accessor: `client.Admin` · Source: `Api/Admin.cs` · 11 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ActivateUser

- **Signature**: `ActivateUser(ActivateUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AdminUsersActivateJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ActivateUserRequest` | `Requests/Users/ActivateUserRequest.cs` |
| `AdminUsersActivateJsonResponse` | `Models/AdminUsersActivateJsonResponse.cs` |

### AdminGetUser

- **Signature**: `AdminGetUser(AdminGetUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AdminUsersJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminGetUserRequest` | `Requests/Users/AdminGetUserRequest.cs` |
| `AdminUsersJsonResponse` | `Models/AdminUsersJsonResponse.cs` |

### AdminListUsers

- **Signature**: `AdminListUsers(AdminListUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `order` ← `Order`, `asc` ← `Asc`, `page` ← `Page`, `show_emails` ← `ShowEmails`, `stats` ← `Stats`, `email` ← `Email`, `ip` ← `Ip`
- **Returns**: `IReadOnlyList<AdminUsersJsonResponse2>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminListUsersRequest` | `Requests/Users/AdminListUsersRequest.cs` |
| `Order3` | `Models/Enums/Order3.cs` |
| `Asc` | `Models/Enums/Asc.cs` |
| `AdminUsersJsonResponse2` | `Models/AdminUsersJsonResponse2.cs` |

### AdminListUsersFlag

- **Signature**: `AdminListUsersFlag(AdminListUsersFlagRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Flag`
- **Query params (wire ← C#)**: `order` ← `Order`, `asc` ← `Asc`, `page` ← `Page`, `show_emails` ← `ShowEmails`, `stats` ← `Stats`, `email` ← `Email`, `ip` ← `Ip`
- **Returns**: `IReadOnlyList<AdminUsersListJsonResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminListUsersFlagRequest` | `Requests/Users/AdminListUsersFlagRequest.cs` |
| `Flag` | `Models/Enums/Flag.cs` |
| `Order3` | `Models/Enums/Order3.cs` |
| `Asc` | `Models/Enums/Asc.cs` |
| `AdminUsersListJsonResponse` | `Models/AdminUsersListJsonResponse.cs` |

### AnonymizeUser

- **Signature**: `AnonymizeUser(AnonymizeUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AdminUsersAnonymizeJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AnonymizeUserRequest` | `Requests/Users/AnonymizeUserRequest.cs` |
| `AdminUsersAnonymizeJsonResponse` | `Models/AdminUsersAnonymizeJsonResponse.cs` |

### DeactivateUser

- **Signature**: `DeactivateUser(DeactivateUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AdminUsersDeactivateJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeactivateUserRequest` | `Requests/Users/DeactivateUserRequest.cs` |
| `AdminUsersDeactivateJsonResponse` | `Models/AdminUsersDeactivateJsonResponse.cs` |

### DeleteUser

- **Signature**: `DeleteUser(DeleteUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AdminUsersJsonResponse1`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteUserRequest` | `Requests/Users/DeleteUserRequest.cs` |
| `AdminUsersJsonRequest` | `Models/AdminUsersJsonRequest.cs` |
| `AdminUsersJsonResponse1` | `Models/AdminUsersJsonResponse1.cs` |

### LogOutUser

- **Signature**: `LogOutUser(LogOutUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AdminUsersLogOutJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LogOutUserRequest` | `Requests/Users/LogOutUserRequest.cs` |
| `AdminUsersLogOutJsonResponse` | `Models/AdminUsersLogOutJsonResponse.cs` |

### RefreshGravatar

- **Signature**: `RefreshGravatar(RefreshGravatarRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Username`
- **Returns**: `UserAvatarRefreshGravatarJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RefreshGravatarRequest` | `Requests/Users/RefreshGravatarRequest.cs` |
| `UserAvatarRefreshGravatarJsonResponse` | `Models/UserAvatarRefreshGravatarJsonResponse.cs` |

### SilenceUser

- **Signature**: `SilenceUser(SilenceUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AdminUsersSilenceJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SilenceUserRequest` | `Requests/Users/SilenceUserRequest.cs` |
| `AdminUsersSilenceJsonRequest` | `Models/AdminUsersSilenceJsonRequest.cs` |
| `AdminUsersSilenceJsonResponse` | `Models/AdminUsersSilenceJsonResponse.cs` |

### SuspendUser

- **Signature**: `SuspendUser(SuspendUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AdminUsersSuspendJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SuspendUserRequest` | `Requests/Users/SuspendUserRequest.cs` |
| `AdminUsersSuspendJsonRequest` | `Models/AdminUsersSuspendJsonRequest.cs` |
| `AdminUsersSuspendJsonResponse` | `Models/AdminUsersSuspendJsonResponse.cs` |

