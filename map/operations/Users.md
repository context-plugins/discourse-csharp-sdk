<!-- Generated file — do not edit; regenerated with the SDK. -->

# Users — operations

Accessor: `client.Users` · Source: `Api/Users.cs` · 25 operations

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

### ChangePassword

- **Signature**: `ChangePassword(ChangePasswordRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChangePasswordRequest` | `Requests/Users/ChangePasswordRequest.cs` |
| `UsersPasswordResetJsonRequest` | `Models/UsersPasswordResetJsonRequest.cs` |

### CreateUser

- **Signature**: `CreateUser(CreateUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ApiKey`, `ApiUsername`
- **Returns**: `UsersJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateUserRequest` | `Requests/Users/CreateUserRequest.cs` |
| `UsersJsonRequest` | `Models/UsersJsonRequest.cs` |
| `UsersJsonResponse` | `Models/UsersJsonResponse.cs` |

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

### GetUser

- **Signature**: `GetUser(GetUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Username`, `ApiKey`, `ApiUsername`
- **Returns**: `UJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetUserRequest` | `Requests/Users/GetUserRequest.cs` |
| `UJsonResponse` | `Models/UJsonResponse.cs` |

### GetUserEmails

- **Signature**: `GetUserEmails(GetUserEmailsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Username`
- **Returns**: `UEmailsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetUserEmailsRequest` | `Requests/Users/GetUserEmailsRequest.cs` |
| `UEmailsJsonResponse` | `Models/UEmailsJsonResponse.cs` |

### GetUserExternalId

- **Signature**: `GetUserExternalId(GetUserExternalIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ExternalId`, `ApiKey`, `ApiUsername`
- **Returns**: `UByExternalJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetUserExternalIdRequest` | `Requests/Users/GetUserExternalIdRequest.cs` |
| `UByExternalJsonResponse` | `Models/UByExternalJsonResponse.cs` |

### GetUserIdentiyProviderExternalId

- **Signature**: `GetUserIdentiyProviderExternalId(GetUserIdentiyProviderExternalIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Provider`, `ExternalId`, `ApiKey`, `ApiUsername`
- **Returns**: `UByExternalJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetUserIdentiyProviderExternalIdRequest` | `Requests/Users/GetUserIdentiyProviderExternalIdRequest.cs` |
| `UByExternalJsonResponse` | `Models/UByExternalJsonResponse.cs` |

### ListUserActions

- **Signature**: `ListUserActions(ListUserActionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Offset`, `Username`, `Filter`
- **Query params (wire ← C#)**: `offset` ← `Offset`, `username` ← `Username`, `filter` ← `Filter`
- **Returns**: `UserActionsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListUserActionsRequest` | `Requests/Users/ListUserActionsRequest.cs` |
| `UserActionsJsonResponse` | `Models/UserActionsJsonResponse.cs` |

### ListUserBadges

- **Signature**: `ListUserBadges(ListUserBadgesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Username`
- **Returns**: `UserBadgesJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListUserBadgesRequest` | `Requests/Badges/ListUserBadgesRequest.cs` |
| `UserBadgesJsonResponse` | `Models/UserBadgesJsonResponse.cs` |

### ListUsersPublic

- **Signature**: `ListUsersPublic(ListUsersPublicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Period`, `Order`
- **Query params (wire ← C#)**: `period` ← `Period`, `order` ← `Order`, `asc` ← `Asc`, `page` ← `Page`
- **Returns**: `DirectoryItemsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListUsersPublicRequest` | `Requests/Users/ListUsersPublicRequest.cs` |
| `Period1` | `Models/Enums/Period1.cs` |
| `Order2` | `Models/Enums/Order2.cs` |
| `Asc` | `Models/Enums/Asc.cs` |
| `DirectoryItemsJsonResponse` | `Models/DirectoryItemsJsonResponse.cs` |

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

### SendPasswordResetEmail

- **Signature**: `SendPasswordResetEmail(SendPasswordResetEmailRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SessionForgotPasswordJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SendPasswordResetEmailRequest` | `Requests/Users/SendPasswordResetEmailRequest.cs` |
| `SessionForgotPasswordJsonRequest` | `Models/SessionForgotPasswordJsonRequest.cs` |
| `SessionForgotPasswordJsonResponse` | `Models/SessionForgotPasswordJsonResponse.cs` |

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

### UpdateAvatar

- **Signature**: `UpdateAvatar(UpdateAvatarRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Username`
- **Returns**: `UPreferencesAvatarPickJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateAvatarRequest` | `Requests/Users/UpdateAvatarRequest.cs` |
| `UPreferencesAvatarPickJsonRequest` | `Models/UPreferencesAvatarPickJsonRequest.cs` |
| `UPreferencesAvatarPickJsonResponse` | `Models/UPreferencesAvatarPickJsonResponse.cs` |

### UpdateEmail

- **Signature**: `UpdateEmail(UpdateEmailRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Username`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateEmailRequest` | `Requests/Users/UpdateEmailRequest.cs` |
| `UPreferencesEmailJsonRequest` | `Models/UPreferencesEmailJsonRequest.cs` |

### UpdateUser

- **Signature**: `UpdateUser(UpdateUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Username`, `ApiKey`, `ApiUsername`
- **Returns**: `UJsonResponse1`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateUserRequest` | `Requests/Users/UpdateUserRequest.cs` |
| `UJsonRequest` | `Models/UJsonRequest.cs` |
| `UJsonResponse1` | `Models/UJsonResponse1.cs` |

### UpdateUsername

- **Signature**: `UpdateUsername(UpdateUsernameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Username`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateUsernameRequest` | `Requests/Users/UpdateUsernameRequest.cs` |
| `UPreferencesUsernameJsonRequest` | `Models/UPreferencesUsernameJsonRequest.cs` |

