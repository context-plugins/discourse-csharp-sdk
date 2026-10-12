namespace Discourse.Requests.Tags;

/// <summary>
/// The inputs of the GetTag operation.
/// </summary>
public sealed record GetTagRequest
{
    public required string Name { get; init; }
}
