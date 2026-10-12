using Discourse.Models;

namespace Discourse.Requests.Notifications;

/// <summary>
/// The inputs of the MarkNotificationsAsRead operation.
/// </summary>
public sealed record MarkNotificationsAsReadRequest
{
    public NotificationsMarkReadJsonRequest? Body { get; init; }
}
