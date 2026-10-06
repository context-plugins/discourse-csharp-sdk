using Discourse.Models;

namespace Discourse.Requests.Groups;

/// <summary>
/// The inputs of the RemoveGroupMembers operation.
/// </summary>
public sealed record RemoveGroupMembersRequest
{
    public required int Id { get; init; }

    public GroupsMembersJsonRequest? Body { get; init; }
}
