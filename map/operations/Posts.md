<!-- Generated file — do not edit; regenerated with the SDK. -->

# Posts — operations

Accessor: `client.Posts` · Source: `src/Discourse/Api/Posts.cs` · 8 operations

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

### DeletePost

- **Signature**: `DeletePost(DeletePostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeletePostRequest` | `src/Discourse/Requests/Posts/DeletePostRequest.cs` |
| `PostsJsonRequest2` | `src/Discourse/Models/PostsJsonRequest2.cs` |

### GetPost

- **Signature**: `GetPost(GetPostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `PostsJsonResponse2`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetPostRequest` | `src/Discourse/Requests/Posts/GetPostRequest.cs` |
| `PostsJsonResponse2` | `src/Discourse/Models/PostsJsonResponse2.cs` |

### ListPosts

- **Signature**: `ListPosts(ListPostsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `before` ← `Before`
- **Returns**: `PostsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListPostsRequest` | `src/Discourse/Requests/Posts/ListPostsRequest.cs` |
| `PostsJsonResponse` | `src/Discourse/Models/PostsJsonResponse.cs` |

### LockPost

- **Signature**: `LockPost(LockPostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `PostsLockedJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LockPostRequest` | `src/Discourse/Requests/Posts/LockPostRequest.cs` |
| `PostsLockedJsonRequest` | `src/Discourse/Models/PostsLockedJsonRequest.cs` |
| `PostsLockedJsonResponse` | `src/Discourse/Models/PostsLockedJsonResponse.cs` |

### PerformPostAction

- **Signature**: `PerformPostAction(PerformPostActionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ApiKey`, `ApiUsername`
- **Returns**: `PostActionsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PerformPostActionRequest` | `src/Discourse/Requests/Posts/PerformPostActionRequest.cs` |
| `PostActionsJsonRequest` | `src/Discourse/Models/PostActionsJsonRequest.cs` |
| `PostActionsJsonResponse` | `src/Discourse/Models/PostActionsJsonResponse.cs` |

### PostReplies

- **Signature**: `PostReplies(PostRepliesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `IReadOnlyList<PostsRepliesJsonResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PostRepliesRequest` | `src/Discourse/Requests/Posts/PostRepliesRequest.cs` |
| `PostsRepliesJsonResponse` | `src/Discourse/Models/PostsRepliesJsonResponse.cs` |

### UpdatePost

- **Signature**: `UpdatePost(UpdatePostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `PostsJsonResponse3`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdatePostRequest` | `src/Discourse/Requests/Posts/UpdatePostRequest.cs` |
| `PostsJsonRequest1` | `src/Discourse/Models/PostsJsonRequest1.cs` |
| `PostsJsonResponse3` | `src/Discourse/Models/PostsJsonResponse3.cs` |

