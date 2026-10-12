using Discourse.Models;

namespace Discourse.Requests.Groups;

/// <summary>
/// The inputs of the AddGroupMembers operation.
/// </summary>
public sealed record AddGroupMembersRequest
{
    public required int Id { get; init; }

    public GroupsMembersJsonRequest? Body { get; init; }
}
