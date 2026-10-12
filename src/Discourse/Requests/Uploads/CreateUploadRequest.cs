using Discourse.Core.Models;
using Discourse.Models.Enums;

namespace Discourse.Requests.Uploads;

/// <summary>
/// The inputs of the CreateUpload operation.
/// </summary>
public sealed record CreateUploadRequest
{
    public required UploadType UploadType { get; init; }

    /// <summary>
    /// required if uploading an avatar
    /// </summary>
    public int? UserId { get; init; }

    /// <summary>
    /// Use this flag to return an id and url
    /// </summary>
    public bool? Synchronous { get; init; }

    public BinaryContent? File { get; init; }
}
