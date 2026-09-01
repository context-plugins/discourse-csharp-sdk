<!-- Generated file — do not edit; regenerated with the SDK. -->

# Topics — operations

Accessor: `client.Topics` · Source: `Api/Topics.cs` · 15 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BookmarkTopic

- **Signature**: `BookmarkTopic(string id, string apiKey, string apiUsername, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### CreateTopicPostPm

- **Signature**: `CreateTopicPostPm(string apiKey, string apiUsername, PostsJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `PostsJsonResponse1`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PostsJsonRequest` | `Models/PostsJsonRequest.cs` |
| `PostsJsonResponse1` | `Models/PostsJsonResponse1.cs` |

### CreateTopicTimer

- **Signature**: `CreateTopicTimer(string id, string apiKey, string apiUsername, TTimerJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `TTimerJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TTimerJsonRequest` | `Models/TTimerJsonRequest.cs` |
| `TTimerJsonResponse` | `Models/TTimerJsonResponse.cs` |

### GetSpecificPostsFromTopic

- **Signature**: `GetSpecificPostsFromTopic(string id, string apiKey, string apiUsername, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TPostsJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TPostsJsonResponse` | `Models/TPostsJsonResponse.cs` |

### GetTopic

- **Signature**: `GetTopic(string id, string apiKey, string apiUsername, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TJsonResponse` | `Models/TJsonResponse.cs` |

### GetTopicByExternalId

- **Signature**: `GetTopicByExternalId(string externalId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### InviteGroupToTopic

- **Signature**: `InviteGroupToTopic(string id, string apiKey, string apiUsername, TInviteGroupJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `TInviteGroupJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TInviteGroupJsonRequest` | `Models/TInviteGroupJsonRequest.cs` |
| `TInviteGroupJsonResponse` | `Models/TInviteGroupJsonResponse.cs` |

### InviteToTopic

- **Signature**: `InviteToTopic(string id, string apiKey, string apiUsername, TInviteJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `TInviteJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TInviteJsonRequest` | `Models/TInviteJsonRequest.cs` |
| `TInviteJsonResponse` | `Models/TInviteJsonResponse.cs` |

### ListLatestTopics

- **Signature**: `ListLatestTopics(string? order, string? ascending, int? perPage, string apiKey, string apiUsername, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `order` — nullable, no default → **must pass explicitly**
  - `ascending` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `order` ← `order`, `ascending` ← `ascending`, `per_page` ← `perPage`
- **Returns**: `LatestJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LatestJsonResponse` | `Models/LatestJsonResponse.cs` |

### ListTopTopics

- **Signature**: `ListTopTopics(string? period, int? perPage, string apiKey, string apiUsername, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `period` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `period` ← `period`, `per_page` ← `perPage`
- **Returns**: `TopJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TopJsonResponse` | `Models/TopJsonResponse.cs` |

### RemoveTopic

- **Signature**: `RemoveTopic(string id, string apiKey, string apiUsername, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### SetNotificationLevel

- **Signature**: `SetNotificationLevel(string id, string apiKey, string apiUsername, TNotificationsJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `TNotificationsJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TNotificationsJsonRequest` | `Models/TNotificationsJsonRequest.cs` |
| `TNotificationsJsonResponse` | `Models/TNotificationsJsonResponse.cs` |

### UpdateTopic

- **Signature**: `UpdateTopic(string id, string apiKey, string apiUsername, TJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `TJsonResponse1`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TJsonRequest` | `Models/TJsonRequest.cs` |
| `TJsonResponse1` | `Models/TJsonResponse1.cs` |

### UpdateTopicStatus

- **Signature**: `UpdateTopicStatus(string id, string apiKey, string apiUsername, TStatusJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `TStatusJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TStatusJsonRequest` | `Models/TStatusJsonRequest.cs` |
| `TStatusJsonResponse` | `Models/TStatusJsonResponse.cs` |

### UpdateTopicTimestamp

- **Signature**: `UpdateTopicTimestamp(string id, string apiKey, string apiUsername, TChangeTimestampJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `TChangeTimestampJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TChangeTimestampJsonRequest` | `Models/TChangeTimestampJsonRequest.cs` |
| `TChangeTimestampJsonResponse` | `Models/TChangeTimestampJsonResponse.cs` |

