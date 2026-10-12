namespace Discourse.Requests.Groups;

/// <summary>
/// The inputs of the GetGroupById operation.
/// </summary>
public sealed record GetGroupByIdRequest
{
    /// <summary>
    /// Use group name instead of id
    /// </summary>
    public required string Id { get; init; }
}
