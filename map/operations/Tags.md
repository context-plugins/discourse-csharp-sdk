<!-- Generated file — do not edit; regenerated with the SDK. -->

# Tags — operations

Accessor: `client.Tags` · Source: `src/Discourse/Api/Tags.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateTagGroup

- **Signature**: `CreateTagGroup(CreateTagGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `TagGroupsJsonResponse1`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTagGroupRequest` | `src/Discourse/Requests/Tags/CreateTagGroupRequest.cs` |
| `TagGroupsJsonRequest` | `src/Discourse/Models/TagGroupsJsonRequest.cs` |
| `TagGroupsJsonResponse1` | `src/Discourse/Models/TagGroupsJsonResponse1.cs` |

### GetTag

- **Signature**: `GetTag(GetTagRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Name`
- **Returns**: `TagJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetTagRequest` | `src/Discourse/Requests/Tags/GetTagRequest.cs` |
| `TagJsonResponse` | `src/Discourse/Models/TagJsonResponse.cs` |

### GetTagGroup

- **Signature**: `GetTagGroup(GetTagGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `TagGroupsJsonResponse2`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetTagGroupRequest` | `src/Discourse/Requests/Tags/GetTagGroupRequest.cs` |
| `TagGroupsJsonResponse2` | `src/Discourse/Models/TagGroupsJsonResponse2.cs` |

### ListTagGroups

- **Signature**: `ListTagGroups(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `TagGroupsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TagGroupsJsonResponse` | `src/Discourse/Models/TagGroupsJsonResponse.cs` |

### ListTags

- **Signature**: `ListTags(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `TagsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TagsJsonResponse` | `src/Discourse/Models/TagsJsonResponse.cs` |

### UpdateTagGroup

- **Signature**: `UpdateTagGroup(UpdateTagGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `TagGroupsJsonResponse3`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateTagGroupRequest` | `src/Discourse/Requests/Tags/UpdateTagGroupRequest.cs` |
| `TagGroupsJsonRequest1` | `src/Discourse/Models/TagGroupsJsonRequest1.cs` |
| `TagGroupsJsonResponse3` | `src/Discourse/Models/TagGroupsJsonResponse3.cs` |

