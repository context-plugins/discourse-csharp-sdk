using Discourse.Models;

namespace Discourse.Requests.Posts;

/// <summary>
/// The inputs of the PerformPostAction operation.
/// </summary>
public sealed record PerformPostActionRequest
{
    public required string ApiKey { get; init; }

    public required string ApiUsername { get; init; }

    public PostActionsJsonRequest? Body { get; init; }
}
