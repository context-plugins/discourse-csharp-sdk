using Discourse.Models;

namespace Discourse.Requests.Uploads;

/// <summary>
/// The inputs of the CompleteMultipart operation.
/// </summary>
public sealed record CompleteMultipartRequest
{
    public UploadsCompleteMultipartJsonRequest? Body { get; init; }
}
