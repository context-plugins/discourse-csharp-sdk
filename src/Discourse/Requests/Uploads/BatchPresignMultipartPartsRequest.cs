using Discourse.Models;

namespace Discourse.Requests.Uploads;

/// <summary>
/// The inputs of the BatchPresignMultipartParts operation.
/// </summary>
public sealed record BatchPresignMultipartPartsRequest
{
    public UploadsBatchPresignMultipartPartsJsonRequest? Body { get; init; }
}
