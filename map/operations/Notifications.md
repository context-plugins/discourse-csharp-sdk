<!-- Generated file — do not edit; regenerated with the SDK. -->

# Notifications — operations

Accessor: `client.Notifications` · Source: `src/Discourse/Api/Notifications.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetNotifications

- **Signature**: `GetNotifications(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `NotificationsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `NotificationsJsonResponse` | `src/Discourse/Models/NotificationsJsonResponse.cs` |

### MarkNotificationsAsRead

- **Signature**: `MarkNotificationsAsRead(MarkNotificationsAsReadRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `NotificationsMarkReadJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `MarkNotificationsAsReadRequest` | `src/Discourse/Requests/Notifications/MarkNotificationsAsReadRequest.cs` |
| `NotificationsMarkReadJsonRequest` | `src/Discourse/Models/NotificationsMarkReadJsonRequest.cs` |
| `NotificationsMarkReadJsonResponse` | `src/Discourse/Models/NotificationsMarkReadJsonResponse.cs` |

