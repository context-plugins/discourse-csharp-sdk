using Discourse.Models;

namespace Discourse.Requests.Uploads;

/// <summary>
/// The inputs of the AbortMultipart operation.
/// </summary>
public sealed record AbortMultipartRequest
{
    public UploadsAbortMultipartJsonRequest? Body { get; init; }
}
