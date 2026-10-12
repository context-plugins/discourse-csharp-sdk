<!-- Generated file — do not edit; regenerated with the SDK. -->

# Users — operations

Accessor: `client.Users` · Source: `src/Discourse/Api/Users.cs` · 25 operations

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

### ChangePassword

- **Signature**: `ChangePassword(ChangePasswordRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChangePasswordRequest` | `src/Discourse/Requests/Users/ChangePasswordRequest.cs` |
| `UsersPasswordResetJsonRequest` | `src/Discourse/Models/UsersPasswordResetJsonRequest.cs` |

### CreateUser

- **Signature**: `CreateUser(CreateUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ApiKey`, `ApiUsername`
- **Returns**: `UsersJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateUserRequest` | `src/Discourse/Requests/Users/CreateUserRequest.cs` |
| `UsersJsonRequest` | `src/Discourse/Models/UsersJsonRequest.cs` |
| `UsersJsonResponse` | `src/Discourse/Models/UsersJsonResponse.cs` |

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

### GetUser

- **Signature**: `GetUser(GetUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Username`, `ApiKey`, `ApiUsername`
- **Returns**: `UJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetUserRequest` | `src/Discourse/Requests/Users/GetUserRequest.cs` |
| `UJsonResponse` | `src/Discourse/Models/UJsonResponse.cs` |

### GetUserEmails

- **Signature**: `GetUserEmails(GetUserEmailsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Username`
- **Returns**: `UEmailsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetUserEmailsRequest` | `src/Discourse/Requests/Users/GetUserEmailsRequest.cs` |
| `UEmailsJsonResponse` | `src/Discourse/Models/UEmailsJsonResponse.cs` |

### GetUserExternalId

- **Signature**: `GetUserExternalId(GetUserExternalIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ExternalId`, `ApiKey`, `ApiUsername`
- **Returns**: `UByExternalJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetUserExternalIdRequest` | `src/Discourse/Requests/Users/GetUserExternalIdRequest.cs` |
| `UByExternalJsonResponse` | `src/Discourse/Models/UByExternalJsonResponse.cs` |

### GetUserIdentiyProviderExternalId

- **Signature**: `GetUserIdentiyProviderExternalId(GetUserIdentiyProviderExternalIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Provider`, `ExternalId`, `ApiKey`, `ApiUsername`
- **Returns**: `UByExternalJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetUserIdentiyProviderExternalIdRequest` | `src/Discourse/Requests/Users/GetUserIdentiyProviderExternalIdRequest.cs` |
| `UByExternalJsonResponse` | `src/Discourse/Models/UByExternalJsonResponse.cs` |

### ListUserActions

- **Signature**: `ListUserActions(ListUserActionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Offset`, `Username`, `Filter`
- **Query params (wire ← C#)**: `offset` ← `Offset`, `username` ← `Username`, `filter` ← `Filter`
- **Returns**: `UserActionsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListUserActionsRequest` | `src/Discourse/Requests/Users/ListUserActionsRequest.cs` |
| `UserActionsJsonResponse` | `src/Discourse/Models/UserActionsJsonResponse.cs` |

### ListUserBadges

- **Signature**: `ListUserBadges(ListUserBadgesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Username`
- **Returns**: `UserBadgesJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListUserBadgesRequest` | `src/Discourse/Requests/Badges/ListUserBadgesRequest.cs` |
| `UserBadgesJsonResponse` | `src/Discourse/Models/UserBadgesJsonResponse.cs` |

### ListUsersPublic

- **Signature**: `ListUsersPublic(ListUsersPublicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Period`, `Order`
- **Query params (wire ← C#)**: `period` ← `Period`, `order` ← `Order`, `asc` ← `Asc`, `page` ← `Page`
- **Returns**: `DirectoryItemsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListUsersPublicRequest` | `src/Discourse/Requests/Users/ListUsersPublicRequest.cs` |
| `Period1` | `src/Discourse/Models/Enums/Period1.cs` |
| `Order2` | `src/Discourse/Models/Enums/Order2.cs` |
| `Asc` | `src/Discourse/Models/Enums/Asc.cs` |
| `DirectoryItemsJsonResponse` | `src/Discourse/Models/DirectoryItemsJsonResponse.cs` |

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

### SendPasswordResetEmail

- **Signature**: `SendPasswordResetEmail(SendPasswordResetEmailRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SessionForgotPasswordJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SendPasswordResetEmailRequest` | `src/Discourse/Requests/Users/SendPasswordResetEmailRequest.cs` |
| `SessionForgotPasswordJsonRequest` | `src/Discourse/Models/SessionForgotPasswordJsonRequest.cs` |
| `SessionForgotPasswordJsonResponse` | `src/Discourse/Models/SessionForgotPasswordJsonResponse.cs` |

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

### UpdateAvatar

- **Signature**: `UpdateAvatar(UpdateAvatarRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Username`
- **Returns**: `UPreferencesAvatarPickJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateAvatarRequest` | `src/Discourse/Requests/Users/UpdateAvatarRequest.cs` |
| `UPreferencesAvatarPickJsonRequest` | `src/Discourse/Models/UPreferencesAvatarPickJsonRequest.cs` |
| `UPreferencesAvatarPickJsonResponse` | `src/Discourse/Models/UPreferencesAvatarPickJsonResponse.cs` |

### UpdateEmail

- **Signature**: `UpdateEmail(UpdateEmailRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Username`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateEmailRequest` | `src/Discourse/Requests/Users/UpdateEmailRequest.cs` |
| `UPreferencesEmailJsonRequest` | `src/Discourse/Models/UPreferencesEmailJsonRequest.cs` |

### UpdateUser

- **Signature**: `UpdateUser(UpdateUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Username`, `ApiKey`, `ApiUsername`
- **Returns**: `UJsonResponse1`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateUserRequest` | `src/Discourse/Requests/Users/UpdateUserRequest.cs` |
| `UJsonRequest` | `src/Discourse/Models/UJsonRequest.cs` |
| `UJsonResponse1` | `src/Discourse/Models/UJsonResponse1.cs` |

### UpdateUsername

- **Signature**: `UpdateUsername(UpdateUsernameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Username`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateUsernameRequest` | `src/Discourse/Requests/Users/UpdateUsernameRequest.cs` |
| `UPreferencesUsernameJsonRequest` | `src/Discourse/Models/UPreferencesUsernameJsonRequest.cs` |

