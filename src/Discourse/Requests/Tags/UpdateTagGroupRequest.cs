using Discourse.Models;

namespace Discourse.Requests.Tags;

/// <summary>
/// The inputs of the UpdateTagGroup operation.
/// </summary>
public sealed record UpdateTagGroupRequest
{
    public required string Id { get; init; }

    public TagGroupsJsonRequest1? Body { get; init; }
}
