<!-- Generated file — do not edit; regenerated with the SDK. -->

# Backups — operations

Accessor: `client.Backups` · Source: `Api/Backups.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateBackup

- **Signature**: `CreateBackup(CreateBackupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `AdminBackupsJsonResponse1`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateBackupRequest` | `Requests/Backups/CreateBackupRequest.cs` |
| `AdminBackupsJsonRequest` | `Models/AdminBackupsJsonRequest.cs` |
| `AdminBackupsJsonResponse1` | `Models/AdminBackupsJsonResponse1.cs` |

### DownloadBackup

- **Signature**: `DownloadBackup(DownloadBackupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Filename`, `Token`
- **Query params (wire ← C#)**: `token` ← `Token`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DownloadBackupRequest` | `Requests/Backups/DownloadBackupRequest.cs` |

### GetBackups

- **Signature**: `GetBackups(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<AdminBackupsJsonResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminBackupsJsonResponse` | `Models/AdminBackupsJsonResponse.cs` |

### SendDownloadBackupEmail

- **Signature**: `SendDownloadBackupEmail(SendDownloadBackupEmailRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Filename`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SendDownloadBackupEmailRequest` | `Requests/Backups/SendDownloadBackupEmailRequest.cs` |

