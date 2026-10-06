using Discourse.Models;

namespace Discourse.Requests.Uploads;

/// <summary>
/// The inputs of the CreateMultipartUpload operation.
/// </summary>
public sealed record CreateMultipartUploadRequest
{
    public UploadsCreateMultipartJsonRequest? Body { get; init; }
}
