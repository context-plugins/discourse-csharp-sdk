<!-- Generated file — do not edit; regenerated with the SDK. -->

# Tags — operations

Accessor: `client.Tags` · Source: `Api/Tags.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateTagGroup

- **Signature**: `CreateTagGroup(TagGroupsJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `TagGroupsJsonResponse1`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TagGroupsJsonRequest` | `Models/TagGroupsJsonRequest.cs` |
| `TagGroupsJsonResponse1` | `Models/TagGroupsJsonResponse1.cs` |

### GetTag

- **Signature**: `GetTag(string name, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TagJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TagJsonResponse` | `Models/TagJsonResponse.cs` |

### GetTagGroup

- **Signature**: `GetTagGroup(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TagGroupsJsonResponse2`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TagGroupsJsonResponse2` | `Models/TagGroupsJsonResponse2.cs` |

### ListTagGroups

- **Signature**: `ListTagGroups(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TagGroupsJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TagGroupsJsonResponse` | `Models/TagGroupsJsonResponse.cs` |

### ListTags

- **Signature**: `ListTags(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TagsJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TagsJsonResponse` | `Models/TagsJsonResponse.cs` |

### UpdateTagGroup

- **Signature**: `UpdateTagGroup(string id, TagGroupsJsonRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `TagGroupsJsonResponse3`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TagGroupsJsonRequest1` | `Models/TagGroupsJsonRequest1.cs` |
| `TagGroupsJsonResponse3` | `Models/TagGroupsJsonResponse3.cs` |

