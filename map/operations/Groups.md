<!-- Generated file — do not edit; regenerated with the SDK. -->

# Groups — operations

Accessor: `client.Groups` · Source: `Api/Groups.cs` · 9 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddGroupMembers

- **Signature**: `AddGroupMembers(int id, GroupsMembersJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `GroupsMembersJsonResponse1`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GroupsMembersJsonRequest` | `Models/GroupsMembersJsonRequest.cs` |
| `GroupsMembersJsonResponse1` | `Models/GroupsMembersJsonResponse1.cs` |

### CreateGroup

- **Signature**: `CreateGroup(AdminGroupsJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `AdminGroupsJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminGroupsJsonRequest` | `Models/AdminGroupsJsonRequest.cs` |
| `AdminGroupsJsonResponse` | `Models/AdminGroupsJsonResponse.cs` |

### DeleteGroup

- **Signature**: `DeleteGroup(int id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AdminGroupsJsonResponse1`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminGroupsJsonResponse1` | `Models/AdminGroupsJsonResponse1.cs` |

### GetGroup

- **Signature**: `GetGroup(string name, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GroupsJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GroupsJsonResponse` | `Models/GroupsJsonResponse.cs` |

### GetGroupById

- **Signature**: `GetGroupById(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GroupsByIdJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GroupsByIdJsonResponse` | `Models/GroupsByIdJsonResponse.cs` |

### ListGroupMembers

- **Signature**: `ListGroupMembers(string name, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GroupsMembersJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GroupsMembersJsonResponse` | `Models/GroupsMembersJsonResponse.cs` |

### ListGroups

- **Signature**: `ListGroups(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GroupsJsonResponse2`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GroupsJsonResponse2` | `Models/GroupsJsonResponse2.cs` |

### RemoveGroupMembers

- **Signature**: `RemoveGroupMembers(int id, GroupsMembersJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `GroupsMembersJsonResponse2`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GroupsMembersJsonRequest` | `Models/GroupsMembersJsonRequest.cs` |
| `GroupsMembersJsonResponse2` | `Models/GroupsMembersJsonResponse2.cs` |

### UpdateGroup

- **Signature**: `UpdateGroup(int id, GroupsJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `GroupsJsonResponse1`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GroupsJsonRequest` | `Models/GroupsJsonRequest.cs` |
| `GroupsJsonResponse1` | `Models/GroupsJsonResponse1.cs` |

