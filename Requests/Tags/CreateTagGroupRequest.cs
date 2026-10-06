using Discourse.Models;

namespace Discourse.Requests.Tags;

/// <summary>
/// The inputs of the CreateTagGroup operation.
/// </summary>
public sealed record CreateTagGroupRequest
{
    public TagGroupsJsonRequest? Body { get; init; }
}
