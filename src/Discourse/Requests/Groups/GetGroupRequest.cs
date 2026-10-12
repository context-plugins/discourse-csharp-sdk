namespace Discourse.Requests.Groups;

/// <summary>
/// The inputs of the GetGroup operation.
/// </summary>
public sealed record GetGroupRequest
{
    /// <summary>
    /// Use group name instead of id
    /// </summary>
    public required string Name { get; init; }
}
