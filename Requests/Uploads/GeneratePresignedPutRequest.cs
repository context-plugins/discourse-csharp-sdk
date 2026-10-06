using Discourse.Models;

namespace Discourse.Requests.Uploads;

/// <summary>
/// The inputs of the GeneratePresignedPut operation.
/// </summary>
public sealed record GeneratePresignedPutRequest
{
    public UploadsGeneratePresignedPutJsonRequest? Body { get; init; }
}
