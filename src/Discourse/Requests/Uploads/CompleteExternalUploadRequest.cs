using Discourse.Models;

namespace Discourse.Requests.Uploads;

/// <summary>
/// The inputs of the CompleteExternalUpload operation.
/// </summary>
public sealed record CompleteExternalUploadRequest
{
    public UploadsCompleteExternalUploadJsonRequest? Body { get; init; }
}
