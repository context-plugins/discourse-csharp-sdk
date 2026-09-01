<!-- Generated file — do not edit; regenerated with the SDK. -->

# Notifications — operations

Accessor: `client.Notifications` · Source: `Api/Notifications.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetNotifications

- **Signature**: `GetNotifications(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `NotificationsJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `NotificationsJsonResponse` | `Models/NotificationsJsonResponse.cs` |

### MarkNotificationsAsRead

- **Signature**: `MarkNotificationsAsRead(NotificationsMarkReadJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `NotificationsMarkReadJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `NotificationsMarkReadJsonRequest` | `Models/NotificationsMarkReadJsonRequest.cs` |
| `NotificationsMarkReadJsonResponse` | `Models/NotificationsMarkReadJsonResponse.cs` |

