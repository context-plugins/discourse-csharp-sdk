using Discourse.Models;

namespace Discourse.Requests.Groups;

/// <summary>
/// The inputs of the CreateGroup operation.
/// </summary>
public sealed record CreateGroupRequest
{
    public AdminGroupsJsonRequest? Body { get; init; }
}
