<!-- Generated file — do not edit; regenerated with the SDK. -->

# Topics — operations

Accessor: `client.Topics` · Source: `Api/Topics.cs` · 15 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BookmarkTopic

- **Signature**: `BookmarkTopic(BookmarkTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BookmarkTopicRequest` | `Requests/Topics/BookmarkTopicRequest.cs` |

### CreateTopicPostPm

- **Signature**: `CreateTopicPostPm(CreateTopicPostPmRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ApiKey`, `ApiUsername`
- **Returns**: `PostsJsonResponse1`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTopicPostPmRequest` | `Requests/Posts/CreateTopicPostPmRequest.cs` |
| `PostsJsonRequest` | `Models/PostsJsonRequest.cs` |
| `PostsJsonResponse1` | `Models/PostsJsonResponse1.cs` |

### CreateTopicTimer

- **Signature**: `CreateTopicTimer(CreateTopicTimerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `TTimerJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTopicTimerRequest` | `Requests/Topics/CreateTopicTimerRequest.cs` |
| `TTimerJsonRequest` | `Models/TTimerJsonRequest.cs` |
| `TTimerJsonResponse` | `Models/TTimerJsonResponse.cs` |

### GetSpecificPostsFromTopic

- **Signature**: `GetSpecificPostsFromTopic(GetSpecificPostsFromTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `TPostsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetSpecificPostsFromTopicRequest` | `Requests/Topics/GetSpecificPostsFromTopicRequest.cs` |
| `TPostsJsonResponse` | `Models/TPostsJsonResponse.cs` |

### GetTopic

- **Signature**: `GetTopic(GetTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `TJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetTopicRequest` | `Requests/Topics/GetTopicRequest.cs` |
| `TJsonResponse` | `Models/TJsonResponse.cs` |

### GetTopicByExternalId

- **Signature**: `GetTopicByExternalId(GetTopicByExternalIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ExternalId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetTopicByExternalIdRequest` | `Requests/Topics/GetTopicByExternalIdRequest.cs` |

### InviteGroupToTopic

- **Signature**: `InviteGroupToTopic(InviteGroupToTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `TInviteGroupJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InviteGroupToTopicRequest` | `Requests/Topics/InviteGroupToTopicRequest.cs` |
| `TInviteGroupJsonRequest` | `Models/TInviteGroupJsonRequest.cs` |
| `TInviteGroupJsonResponse` | `Models/TInviteGroupJsonResponse.cs` |

### InviteToTopic

- **Signature**: `InviteToTopic(InviteToTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `TInviteJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InviteToTopicRequest` | `Requests/Topics/InviteToTopicRequest.cs` |
| `TInviteJsonRequest` | `Models/TInviteJsonRequest.cs` |
| `TInviteJsonResponse` | `Models/TInviteJsonResponse.cs` |

### ListLatestTopics

- **Signature**: `ListLatestTopics(ListLatestTopicsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ApiKey`, `ApiUsername`
- **Query params (wire ← C#)**: `order` ← `Order`, `ascending` ← `Ascending`, `per_page` ← `PerPage`
- **Returns**: `LatestJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListLatestTopicsRequest` | `Requests/Topics/ListLatestTopicsRequest.cs` |
| `LatestJsonResponse` | `Models/LatestJsonResponse.cs` |

### ListTopTopics

- **Signature**: `ListTopTopics(ListTopTopicsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ApiKey`, `ApiUsername`
- **Query params (wire ← C#)**: `period` ← `Period`, `per_page` ← `PerPage`
- **Returns**: `TopJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListTopTopicsRequest` | `Requests/Topics/ListTopTopicsRequest.cs` |
| `TopJsonResponse` | `Models/TopJsonResponse.cs` |

### RemoveTopic

- **Signature**: `RemoveTopic(RemoveTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RemoveTopicRequest` | `Requests/Topics/RemoveTopicRequest.cs` |

### SetNotificationLevel

- **Signature**: `SetNotificationLevel(SetNotificationLevelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `TNotificationsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SetNotificationLevelRequest` | `Requests/Topics/SetNotificationLevelRequest.cs` |
| `TNotificationsJsonRequest` | `Models/TNotificationsJsonRequest.cs` |
| `TNotificationsJsonResponse` | `Models/TNotificationsJsonResponse.cs` |

### UpdateTopic

- **Signature**: `UpdateTopic(UpdateTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `TJsonResponse1`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateTopicRequest` | `Requests/Topics/UpdateTopicRequest.cs` |
| `TJsonRequest` | `Models/TJsonRequest.cs` |
| `TJsonResponse1` | `Models/TJsonResponse1.cs` |

### UpdateTopicStatus

- **Signature**: `UpdateTopicStatus(UpdateTopicStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `TStatusJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateTopicStatusRequest` | `Requests/Topics/UpdateTopicStatusRequest.cs` |
| `TStatusJsonRequest` | `Models/TStatusJsonRequest.cs` |
| `TStatusJsonResponse` | `Models/TStatusJsonResponse.cs` |

### UpdateTopicTimestamp

- **Signature**: `UpdateTopicTimestamp(UpdateTopicTimestampRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `TChangeTimestampJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateTopicTimestampRequest` | `Requests/Topics/UpdateTopicTimestampRequest.cs` |
| `TChangeTimestampJsonRequest` | `Models/TChangeTimestampJsonRequest.cs` |
| `TChangeTimestampJsonResponse` | `Models/TChangeTimestampJsonResponse.cs` |

