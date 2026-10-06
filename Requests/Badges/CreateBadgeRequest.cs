using Discourse.Models;

namespace Discourse.Requests.Badges;

/// <summary>
/// The inputs of the CreateBadge operation.
/// </summary>
public sealed record CreateBadgeRequest
{
    public AdminBadgesJsonRequest? Body { get; init; }
}
