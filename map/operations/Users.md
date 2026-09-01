<!-- Generated file — do not edit; regenerated with the SDK. -->

# Users — operations

Accessor: `client.Users` · Source: `Api/Users.cs` · 25 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ActivateUser

- **Signature**: `ActivateUser(int id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AdminUsersActivateJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersActivateJsonResponse` | `Models/AdminUsersActivateJsonResponse.cs` |

### AdminGetUser

- **Signature**: `AdminGetUser(int id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AdminUsersJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersJsonResponse` | `Models/AdminUsersJsonResponse.cs` |

### AdminListUsers

- **Signature**: `AdminListUsers(Order3? order, Asc? asc, int? page, bool? showEmails, bool? stats, string? email, string? ip, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`order` … `ip`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `order` ← `order`, `asc` ← `asc`, `page` ← `page`, `show_emails` ← `showEmails`, `stats` ← `stats`, `email` ← `email`, `ip` ← `ip`
- **Returns**: `IReadOnlyList<AdminUsersJsonResponse2>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Order3` | `Models/Enums/Order3.cs` |
| `Asc` | `Models/Enums/Asc.cs` |
| `AdminUsersJsonResponse2` | `Models/AdminUsersJsonResponse2.cs` |

### AdminListUsersFlag

- **Signature**: `AdminListUsersFlag(Flag flag, Order3? order, Asc? asc, int? page, bool? showEmails, bool? stats, string? email, string? ip, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`order` … `ip`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `order` ← `order`, `asc` ← `asc`, `page` ← `page`, `show_emails` ← `showEmails`, `stats` ← `stats`, `email` ← `email`, `ip` ← `ip`
- **Returns**: `IReadOnlyList<AdminUsersListJsonResponse>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Flag` | `Models/Enums/Flag.cs` |
| `Order3` | `Models/Enums/Order3.cs` |
| `Asc` | `Models/Enums/Asc.cs` |
| `AdminUsersListJsonResponse` | `Models/AdminUsersListJsonResponse.cs` |

### AnonymizeUser

- **Signature**: `AnonymizeUser(int id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AdminUsersAnonymizeJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersAnonymizeJsonResponse` | `Models/AdminUsersAnonymizeJsonResponse.cs` |

### ChangePassword

- **Signature**: `ChangePassword(string token, UsersPasswordResetJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UsersPasswordResetJsonRequest` | `Models/UsersPasswordResetJsonRequest.cs` |

### CreateUser

- **Signature**: `CreateUser(string apiKey, string apiUsername, UsersJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `UsersJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UsersJsonRequest` | `Models/UsersJsonRequest.cs` |
| `UsersJsonResponse` | `Models/UsersJsonResponse.cs` |

### DeactivateUser

- **Signature**: `DeactivateUser(int id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AdminUsersDeactivateJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersDeactivateJsonResponse` | `Models/AdminUsersDeactivateJsonResponse.cs` |

### DeleteUser

- **Signature**: `DeleteUser(int id, AdminUsersJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `AdminUsersJsonResponse1`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersJsonRequest` | `Models/AdminUsersJsonRequest.cs` |
| `AdminUsersJsonResponse1` | `Models/AdminUsersJsonResponse1.cs` |

### GetUser

- **Signature**: `GetUser(string username, string apiKey, string apiUsername, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UJsonResponse` | `Models/UJsonResponse.cs` |

### GetUserEmails

- **Signature**: `GetUserEmails(string username, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UEmailsJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UEmailsJsonResponse` | `Models/UEmailsJsonResponse.cs` |

### GetUserExternalId

- **Signature**: `GetUserExternalId(string externalId, string apiKey, string apiUsername, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UByExternalJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UByExternalJsonResponse` | `Models/UByExternalJsonResponse.cs` |

### GetUserIdentiyProviderExternalId

- **Signature**: `GetUserIdentiyProviderExternalId(string provider, string externalId, string apiKey, string apiUsername, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UByExternalJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UByExternalJsonResponse` | `Models/UByExternalJsonResponse.cs` |

### ListUserActions

- **Signature**: `ListUserActions(int offset, string username, string filter, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `offset` ← `offset`, `username` ← `username`, `filter` ← `filter`
- **Returns**: `UserActionsJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserActionsJsonResponse` | `Models/UserActionsJsonResponse.cs` |

### ListUserBadges

- **Signature**: `ListUserBadges(string username, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UserBadgesJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserBadgesJsonResponse` | `Models/UserBadgesJsonResponse.cs` |

### ListUsersPublic

- **Signature**: `ListUsersPublic(Period1 period, Order2 order, Asc? asc, int? page, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `asc` — nullable, no default → **must pass explicitly**
  - `page` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `period` ← `period`, `order` ← `order`, `asc` ← `asc`, `page` ← `page`
- **Returns**: `DirectoryItemsJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Period1` | `Models/Enums/Period1.cs` |
| `Order2` | `Models/Enums/Order2.cs` |
| `Asc` | `Models/Enums/Asc.cs` |
| `DirectoryItemsJsonResponse` | `Models/DirectoryItemsJsonResponse.cs` |

### LogOutUser

- **Signature**: `LogOutUser(int id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AdminUsersLogOutJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersLogOutJsonResponse` | `Models/AdminUsersLogOutJsonResponse.cs` |

### RefreshGravatar

- **Signature**: `RefreshGravatar(string username, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UserAvatarRefreshGravatarJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserAvatarRefreshGravatarJsonResponse` | `Models/UserAvatarRefreshGravatarJsonResponse.cs` |

### SendPasswordResetEmail

- **Signature**: `SendPasswordResetEmail(SessionForgotPasswordJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `SessionForgotPasswordJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SessionForgotPasswordJsonRequest` | `Models/SessionForgotPasswordJsonRequest.cs` |
| `SessionForgotPasswordJsonResponse` | `Models/SessionForgotPasswordJsonResponse.cs` |

### SilenceUser

- **Signature**: `SilenceUser(int id, AdminUsersSilenceJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `AdminUsersSilenceJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersSilenceJsonRequest` | `Models/AdminUsersSilenceJsonRequest.cs` |
| `AdminUsersSilenceJsonResponse` | `Models/AdminUsersSilenceJsonResponse.cs` |

### SuspendUser

- **Signature**: `SuspendUser(int id, AdminUsersSuspendJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `AdminUsersSuspendJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersSuspendJsonRequest` | `Models/AdminUsersSuspendJsonRequest.cs` |
| `AdminUsersSuspendJsonResponse` | `Models/AdminUsersSuspendJsonResponse.cs` |

### UpdateAvatar

- **Signature**: `UpdateAvatar(string username, UPreferencesAvatarPickJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `UPreferencesAvatarPickJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UPreferencesAvatarPickJsonRequest` | `Models/UPreferencesAvatarPickJsonRequest.cs` |
| `UPreferencesAvatarPickJsonResponse` | `Models/UPreferencesAvatarPickJsonResponse.cs` |

### UpdateEmail

- **Signature**: `UpdateEmail(string username, UPreferencesEmailJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UPreferencesEmailJsonRequest` | `Models/UPreferencesEmailJsonRequest.cs` |

### UpdateUser

- **Signature**: `UpdateUser(string username, string apiKey, string apiUsername, UJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `UJsonResponse1`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UJsonRequest` | `Models/UJsonRequest.cs` |
| `UJsonResponse1` | `Models/UJsonResponse1.cs` |

### UpdateUsername

- **Signature**: `UpdateUsername(string username, UPreferencesUsernameJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UPreferencesUsernameJsonRequest` | `Models/UPreferencesUsernameJsonRequest.cs` |

