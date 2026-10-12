<!-- Generated file — do not edit; regenerated with the SDK. -->

# PrivateMessages — operations

Accessor: `client.PrivateMessages` · Source: `src/Discourse/Api/PrivateMessages.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

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

### GetUserSentPrivateMessages

- **Signature**: `GetUserSentPrivateMessages(GetUserSentPrivateMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Username`
- **Returns**: `TopicsPrivateMessagesSentJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetUserSentPrivateMessagesRequest` | `src/Discourse/Requests/PrivateMessages/GetUserSentPrivateMessagesRequest.cs` |
| `TopicsPrivateMessagesSentJsonResponse` | `src/Discourse/Models/TopicsPrivateMessagesSentJsonResponse.cs` |

### ListUserPrivateMessages

- **Signature**: `ListUserPrivateMessages(ListUserPrivateMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Username`
- **Returns**: `TopicsPrivateMessagesJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListUserPrivateMessagesRequest` | `src/Discourse/Requests/PrivateMessages/ListUserPrivateMessagesRequest.cs` |
| `TopicsPrivateMessagesJsonResponse` | `src/Discourse/Models/TopicsPrivateMessagesJsonResponse.cs` |

