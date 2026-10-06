namespace Discourse.Requests.Badges;

/// <summary>
/// The inputs of the DeleteBadge operation.
/// </summary>
public sealed record DeleteBadgeRequest
{
    public required int Id { get; init; }
}
