namespace Discourse.Requests.Badges;

/// <summary>
/// The inputs of the ListUserBadges operation.
/// </summary>
public sealed record ListUserBadgesRequest
{
    public required string Username { get; init; }
}
