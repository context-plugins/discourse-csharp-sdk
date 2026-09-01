<!-- Generated file — do not edit; regenerated with the SDK. -->

# PrivateMessages — operations

Accessor: `client.PrivateMessages` · Source: `Api/PrivateMessages.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateTopicPostPm

- **Signature**: `CreateTopicPostPm(string apiKey, string apiUsername, PostsJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `PostsJsonResponse1`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PostsJsonRequest` | `Models/PostsJsonRequest.cs` |
| `PostsJsonResponse1` | `Models/PostsJsonResponse1.cs` |

### GetUserSentPrivateMessages

- **Signature**: `GetUserSentPrivateMessages(string username, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TopicsPrivateMessagesSentJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TopicsPrivateMessagesSentJsonResponse` | `Models/TopicsPrivateMessagesSentJsonResponse.cs` |

### ListUserPrivateMessages

- **Signature**: `ListUserPrivateMessages(string username, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TopicsPrivateMessagesJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TopicsPrivateMessagesJsonResponse` | `Models/TopicsPrivateMessagesJsonResponse.cs` |

