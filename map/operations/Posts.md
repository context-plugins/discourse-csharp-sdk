<!-- Generated file — do not edit; regenerated with the SDK. -->

# Posts — operations

Accessor: `client.Posts` · Source: `Api/Posts.cs` · 8 operations

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

### DeletePost

- **Signature**: `DeletePost(DeletePostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeletePostRequest` | `Requests/Posts/DeletePostRequest.cs` |
| `PostsJsonRequest2` | `Models/PostsJsonRequest2.cs` |

### GetPost

- **Signature**: `GetPost(GetPostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `PostsJsonResponse2`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetPostRequest` | `Requests/Posts/GetPostRequest.cs` |
| `PostsJsonResponse2` | `Models/PostsJsonResponse2.cs` |

### ListPosts

- **Signature**: `ListPosts(ListPostsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `before` ← `Before`
- **Returns**: `PostsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListPostsRequest` | `Requests/Posts/ListPostsRequest.cs` |
| `PostsJsonResponse` | `Models/PostsJsonResponse.cs` |

### LockPost

- **Signature**: `LockPost(LockPostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `PostsLockedJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LockPostRequest` | `Requests/Posts/LockPostRequest.cs` |
| `PostsLockedJsonRequest` | `Models/PostsLockedJsonRequest.cs` |
| `PostsLockedJsonResponse` | `Models/PostsLockedJsonResponse.cs` |

### PerformPostAction

- **Signature**: `PerformPostAction(PerformPostActionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ApiKey`, `ApiUsername`
- **Returns**: `PostActionsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PerformPostActionRequest` | `Requests/Posts/PerformPostActionRequest.cs` |
| `PostActionsJsonRequest` | `Models/PostActionsJsonRequest.cs` |
| `PostActionsJsonResponse` | `Models/PostActionsJsonResponse.cs` |

### PostReplies

- **Signature**: `PostReplies(PostRepliesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `IReadOnlyList<PostsRepliesJsonResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PostRepliesRequest` | `Requests/Posts/PostRepliesRequest.cs` |
| `PostsRepliesJsonResponse` | `Models/PostsRepliesJsonResponse.cs` |

### UpdatePost

- **Signature**: `UpdatePost(UpdatePostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `PostsJsonResponse3`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdatePostRequest` | `Requests/Posts/UpdatePostRequest.cs` |
| `PostsJsonRequest1` | `Models/PostsJsonRequest1.cs` |
| `PostsJsonResponse3` | `Models/PostsJsonResponse3.cs` |

