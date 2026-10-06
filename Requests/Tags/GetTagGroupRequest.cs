namespace Discourse.Requests.Tags;

/// <summary>
/// The inputs of the GetTagGroup operation.
/// </summary>
public sealed record GetTagGroupRequest
{
    public required string Id { get; init; }
}
