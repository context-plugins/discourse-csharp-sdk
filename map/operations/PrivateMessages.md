<!-- Generated file — do not edit; regenerated with the SDK. -->

# PrivateMessages — operations

Accessor: `client.PrivateMessages` · Source: `Api/PrivateMessages.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

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

### GetUserSentPrivateMessages

- **Signature**: `GetUserSentPrivateMessages(GetUserSentPrivateMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Username`
- **Returns**: `TopicsPrivateMessagesSentJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetUserSentPrivateMessagesRequest` | `Requests/PrivateMessages/GetUserSentPrivateMessagesRequest.cs` |
| `TopicsPrivateMessagesSentJsonResponse` | `Models/TopicsPrivateMessagesSentJsonResponse.cs` |

### ListUserPrivateMessages

- **Signature**: `ListUserPrivateMessages(ListUserPrivateMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Username`
- **Returns**: `TopicsPrivateMessagesJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListUserPrivateMessagesRequest` | `Requests/PrivateMessages/ListUserPrivateMessagesRequest.cs` |
| `TopicsPrivateMessagesJsonResponse` | `Models/TopicsPrivateMessagesJsonResponse.cs` |

