namespace Discourse.Requests.Backups;

/// <summary>
/// The inputs of the DownloadBackup operation.
/// </summary>
public sealed record DownloadBackupRequest
{
    public required string Filename { get; init; }

    public required string Token { get; init; }
}
