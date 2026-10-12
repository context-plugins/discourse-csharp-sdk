<!-- Generated file — do not edit; regenerated with the SDK. -->

# Topics — operations

Accessor: `client.Topics` · Source: `src/Discourse/Api/Topics.cs` · 15 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BookmarkTopic

- **Signature**: `BookmarkTopic(BookmarkTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BookmarkTopicRequest` | `src/Discourse/Requests/Topics/BookmarkTopicRequest.cs` |

### CreateTopicPostPm

- **Signature**: `CreateTopicPostPm(CreateTopicPostPmRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ApiKey`, `ApiUsername`
- **Returns**: `PostsJsonResponse1`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTopicPostPmRequest` | `src/Discourse/Requests/Posts/CreateTopicPostPmRequest.cs` |
| `PostsJsonRequest` | `src/Discourse/Models/PostsJsonRequest.cs` |
| `PostsJsonResponse1` | `src/Discourse/Models/PostsJsonResponse1.cs` |

### CreateTopicTimer

- **Signature**: `CreateTopicTimer(CreateTopicTimerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `TTimerJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTopicTimerRequest` | `src/Discourse/Requests/Topics/CreateTopicTimerRequest.cs` |
| `TTimerJsonRequest` | `src/Discourse/Models/TTimerJsonRequest.cs` |
| `TTimerJsonResponse` | `src/Discourse/Models/TTimerJsonResponse.cs` |

### GetSpecificPostsFromTopic

- **Signature**: `GetSpecificPostsFromTopic(GetSpecificPostsFromTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `TPostsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetSpecificPostsFromTopicRequest` | `src/Discourse/Requests/Topics/GetSpecificPostsFromTopicRequest.cs` |
| `TPostsJsonResponse` | `src/Discourse/Models/TPostsJsonResponse.cs` |

### GetTopic

- **Signature**: `GetTopic(GetTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `TJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetTopicRequest` | `src/Discourse/Requests/Topics/GetTopicRequest.cs` |
| `TJsonResponse` | `src/Discourse/Models/TJsonResponse.cs` |

### GetTopicByExternalId

- **Signature**: `GetTopicByExternalId(GetTopicByExternalIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ExternalId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetTopicByExternalIdRequest` | `src/Discourse/Requests/Topics/GetTopicByExternalIdRequest.cs` |

### InviteGroupToTopic

- **Signature**: `InviteGroupToTopic(InviteGroupToTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `TInviteGroupJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InviteGroupToTopicRequest` | `src/Discourse/Requests/Topics/InviteGroupToTopicRequest.cs` |
| `TInviteGroupJsonRequest` | `src/Discourse/Models/TInviteGroupJsonRequest.cs` |
| `TInviteGroupJsonResponse` | `src/Discourse/Models/TInviteGroupJsonResponse.cs` |

### InviteToTopic

- **Signature**: `InviteToTopic(InviteToTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `TInviteJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InviteToTopicRequest` | `src/Discourse/Requests/Topics/InviteToTopicRequest.cs` |
| `TInviteJsonRequest` | `src/Discourse/Models/TInviteJsonRequest.cs` |
| `TInviteJsonResponse` | `src/Discourse/Models/TInviteJsonResponse.cs` |

### ListLatestTopics

- **Signature**: `ListLatestTopics(ListLatestTopicsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ApiKey`, `ApiUsername`
- **Query params (wire ← C#)**: `order` ← `Order`, `ascending` ← `Ascending`, `per_page` ← `PerPage`
- **Returns**: `LatestJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListLatestTopicsRequest` | `src/Discourse/Requests/Topics/ListLatestTopicsRequest.cs` |
| `LatestJsonResponse` | `src/Discourse/Models/LatestJsonResponse.cs` |

### ListTopTopics

- **Signature**: `ListTopTopics(ListTopTopicsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ApiKey`, `ApiUsername`
- **Query params (wire ← C#)**: `period` ← `Period`, `per_page` ← `PerPage`
- **Returns**: `TopJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListTopTopicsRequest` | `src/Discourse/Requests/Topics/ListTopTopicsRequest.cs` |
| `TopJsonResponse` | `src/Discourse/Models/TopJsonResponse.cs` |

### RemoveTopic

- **Signature**: `RemoveTopic(RemoveTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RemoveTopicRequest` | `src/Discourse/Requests/Topics/RemoveTopicRequest.cs` |

### SetNotificationLevel

- **Signature**: `SetNotificationLevel(SetNotificationLevelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `TNotificationsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SetNotificationLevelRequest` | `src/Discourse/Requests/Topics/SetNotificationLevelRequest.cs` |
| `TNotificationsJsonRequest` | `src/Discourse/Models/TNotificationsJsonRequest.cs` |
| `TNotificationsJsonResponse` | `src/Discourse/Models/TNotificationsJsonResponse.cs` |

### UpdateTopic

- **Signature**: `UpdateTopic(UpdateTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `TJsonResponse1`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateTopicRequest` | `src/Discourse/Requests/Topics/UpdateTopicRequest.cs` |
| `TJsonRequest` | `src/Discourse/Models/TJsonRequest.cs` |
| `TJsonResponse1` | `src/Discourse/Models/TJsonResponse1.cs` |

### UpdateTopicStatus

- **Signature**: `UpdateTopicStatus(UpdateTopicStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `TStatusJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateTopicStatusRequest` | `src/Discourse/Requests/Topics/UpdateTopicStatusRequest.cs` |
| `TStatusJsonRequest` | `src/Discourse/Models/TStatusJsonRequest.cs` |
| `TStatusJsonResponse` | `src/Discourse/Models/TStatusJsonResponse.cs` |

### UpdateTopicTimestamp

- **Signature**: `UpdateTopicTimestamp(UpdateTopicTimestampRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `TChangeTimestampJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateTopicTimestampRequest` | `src/Discourse/Requests/Topics/UpdateTopicTimestampRequest.cs` |
| `TChangeTimestampJsonRequest` | `src/Discourse/Models/TChangeTimestampJsonRequest.cs` |
| `TChangeTimestampJsonResponse` | `src/Discourse/Models/TChangeTimestampJsonResponse.cs` |

