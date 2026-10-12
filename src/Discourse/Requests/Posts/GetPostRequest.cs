namespace Discourse.Requests.Posts;

/// <summary>
/// The inputs of the GetPost operation.
/// </summary>
public sealed record GetPostRequest
{
    public required string Id { get; init; }
}
