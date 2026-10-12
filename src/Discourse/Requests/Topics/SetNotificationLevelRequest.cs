using Discourse.Models;

namespace Discourse.Requests.Topics;

/// <summary>
/// The inputs of the SetNotificationLevel operation.
/// </summary>
public sealed record SetNotificationLevelRequest
{
    public required string Id { get; init; }

    public required string ApiKey { get; init; }

    public required string ApiUsername { get; init; }

    public TNotificationsJsonRequest? Body { get; init; }
}
