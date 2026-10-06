<!-- Generated file — do not edit; regenerated with the SDK. -->

# Notifications — operations

Accessor: `client.Notifications` · Source: `Api/Notifications.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetNotifications

- **Signature**: `GetNotifications(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `NotificationsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `NotificationsJsonResponse` | `Models/NotificationsJsonResponse.cs` |

### MarkNotificationsAsRead

- **Signature**: `MarkNotificationsAsRead(MarkNotificationsAsReadRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `NotificationsMarkReadJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `MarkNotificationsAsReadRequest` | `Requests/Notifications/MarkNotificationsAsReadRequest.cs` |
| `NotificationsMarkReadJsonRequest` | `Models/NotificationsMarkReadJsonRequest.cs` |
| `NotificationsMarkReadJsonResponse` | `Models/NotificationsMarkReadJsonResponse.cs` |

