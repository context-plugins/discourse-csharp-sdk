<!-- Generated file — do not edit; regenerated with the SDK. -->

# Admin — operations

Accessor: `client.Admin` · Source: `Api/Admin.cs` · 11 operations

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

