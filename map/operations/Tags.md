<!-- Generated file — do not edit; regenerated with the SDK. -->

# Tags — operations

Accessor: `client.Tags` · Source: `Api/Tags.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateTagGroup

- **Signature**: `CreateTagGroup(CreateTagGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `TagGroupsJsonResponse1`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTagGroupRequest` | `Requests/Tags/CreateTagGroupRequest.cs` |
| `TagGroupsJsonRequest` | `Models/TagGroupsJsonRequest.cs` |
| `TagGroupsJsonResponse1` | `Models/TagGroupsJsonResponse1.cs` |

### GetTag

- **Signature**: `GetTag(GetTagRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Name`
- **Returns**: `TagJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetTagRequest` | `Requests/Tags/GetTagRequest.cs` |
| `TagJsonResponse` | `Models/TagJsonResponse.cs` |

### GetTagGroup

- **Signature**: `GetTagGroup(GetTagGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `TagGroupsJsonResponse2`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetTagGroupRequest` | `Requests/Tags/GetTagGroupRequest.cs` |
| `TagGroupsJsonResponse2` | `Models/TagGroupsJsonResponse2.cs` |

### ListTagGroups

- **Signature**: `ListTagGroups(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `TagGroupsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TagGroupsJsonResponse` | `Models/TagGroupsJsonResponse.cs` |

### ListTags

- **Signature**: `ListTags(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `TagsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TagsJsonResponse` | `Models/TagsJsonResponse.cs` |

### UpdateTagGroup

- **Signature**: `UpdateTagGroup(UpdateTagGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `TagGroupsJsonResponse3`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateTagGroupRequest` | `Requests/Tags/UpdateTagGroupRequest.cs` |
| `TagGroupsJsonRequest1` | `Models/TagGroupsJsonRequest1.cs` |
| `TagGroupsJsonResponse3` | `Models/TagGroupsJsonResponse3.cs` |

