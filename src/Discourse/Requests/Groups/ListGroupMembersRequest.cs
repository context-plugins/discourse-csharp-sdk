namespace Discourse.Requests.Groups;

/// <summary>
/// The inputs of the ListGroupMembers operation.
/// </summary>
public sealed record ListGroupMembersRequest
{
    /// <summary>
    /// Use group name instead of id
    /// </summary>
    public required string Name { get; init; }
}
