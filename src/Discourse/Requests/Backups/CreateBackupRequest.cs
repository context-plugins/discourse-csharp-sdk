using Discourse.Models;

namespace Discourse.Requests.Backups;

/// <summary>
/// The inputs of the CreateBackup operation.
/// </summary>
public sealed record CreateBackupRequest
{
    public AdminBackupsJsonRequest? Body { get; init; }
}
