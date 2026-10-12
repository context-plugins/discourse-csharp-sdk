using Discourse.Models;

namespace Discourse.Requests.Badges;

/// <summary>
/// The inputs of the UpdateBadge operation.
/// </summary>
public sealed record UpdateBadgeRequest
{
    public required int Id { get; init; }

    public AdminBadgesJsonRequest1? Body { get; init; }
}
