<!-- Generated file — do not edit; regenerated with the SDK. -->

# Posts — operations

Accessor: `client.Posts` · Source: `Api/Posts.cs` · 8 operations

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

### DeletePost

- **Signature**: `DeletePost(int id, string apiKey, string apiUsername, PostsJsonRequest2? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PostsJsonRequest2` | `Models/PostsJsonRequest2.cs` |

### GetPost

- **Signature**: `GetPost(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PostsJsonResponse2`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PostsJsonResponse2` | `Models/PostsJsonResponse2.cs` |

### ListPosts

- **Signature**: `ListPosts(int? before, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `before` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `before` ← `before`
- **Returns**: `PostsJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PostsJsonResponse` | `Models/PostsJsonResponse.cs` |

### LockPost

- **Signature**: `LockPost(string id, string apiKey, string apiUsername, PostsLockedJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `PostsLockedJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PostsLockedJsonRequest` | `Models/PostsLockedJsonRequest.cs` |
| `PostsLockedJsonResponse` | `Models/PostsLockedJsonResponse.cs` |

### PerformPostAction

- **Signature**: `PerformPostAction(string apiKey, string apiUsername, PostActionsJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `PostActionsJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PostActionsJsonRequest` | `Models/PostActionsJsonRequest.cs` |
| `PostActionsJsonResponse` | `Models/PostActionsJsonResponse.cs` |

### PostReplies

- **Signature**: `PostReplies(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<PostsRepliesJsonResponse>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PostsRepliesJsonResponse` | `Models/PostsRepliesJsonResponse.cs` |

### UpdatePost

- **Signature**: `UpdatePost(string id, string apiKey, string apiUsername, PostsJsonRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `PostsJsonResponse3`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PostsJsonRequest1` | `Models/PostsJsonRequest1.cs` |
| `PostsJsonResponse3` | `Models/PostsJsonResponse3.cs` |

