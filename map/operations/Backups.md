<!-- Generated file — do not edit; regenerated with the SDK. -->

# Backups — operations

Accessor: `client.Backups` · Source: `Api/Backups.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateBackup

- **Signature**: `CreateBackup(AdminBackupsJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `AdminBackupsJsonResponse1`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminBackupsJsonRequest` | `Models/AdminBackupsJsonRequest.cs` |
| `AdminBackupsJsonResponse1` | `Models/AdminBackupsJsonResponse1.cs` |

### DownloadBackup

- **Signature**: `DownloadBackup(string filename, string token, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `token` ← `token`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### GetBackups

- **Signature**: `GetBackups(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<AdminBackupsJsonResponse>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminBackupsJsonResponse` | `Models/AdminBackupsJsonResponse.cs` |

### SendDownloadBackupEmail

- **Signature**: `SendDownloadBackupEmail(string filename, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

