using Discourse.Models;

namespace Discourse.Requests.Groups;

/// <summary>
/// The inputs of the UpdateGroup operation.
/// </summary>
public sealed record UpdateGroupRequest
{
    public required int Id { get; init; }

    public GroupsJsonRequest? Body { get; init; }
}
