namespace Discourse.Requests.Backups;

/// <summary>
/// The inputs of the SendDownloadBackupEmail operation.
/// </summary>
public sealed record SendDownloadBackupEmailRequest
{
    public required string Filename { get; init; }
}
