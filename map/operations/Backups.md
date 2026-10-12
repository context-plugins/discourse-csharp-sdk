<!-- Generated file — do not edit; regenerated with the SDK. -->

# Backups — operations

Accessor: `client.Backups` · Source: `src/Discourse/Api/Backups.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateBackup

- **Signature**: `CreateBackup(CreateBackupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `AdminBackupsJsonResponse1`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateBackupRequest` | `src/Discourse/Requests/Backups/CreateBackupRequest.cs` |
| `AdminBackupsJsonRequest` | `src/Discourse/Models/AdminBackupsJsonRequest.cs` |
| `AdminBackupsJsonResponse1` | `src/Discourse/Models/AdminBackupsJsonResponse1.cs` |

### DownloadBackup

- **Signature**: `DownloadBackup(DownloadBackupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Filename`, `Token`
- **Query params (wire ← C#)**: `token` ← `Token`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DownloadBackupRequest` | `src/Discourse/Requests/Backups/DownloadBackupRequest.cs` |

### GetBackups

- **Signature**: `GetBackups(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<AdminBackupsJsonResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminBackupsJsonResponse` | `src/Discourse/Models/AdminBackupsJsonResponse.cs` |

### SendDownloadBackupEmail

- **Signature**: `SendDownloadBackupEmail(SendDownloadBackupEmailRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Filename`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SendDownloadBackupEmailRequest` | `src/Discourse/Requests/Backups/SendDownloadBackupEmailRequest.cs` |

