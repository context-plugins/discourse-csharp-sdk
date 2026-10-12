<!-- Generated file — do not edit; regenerated with the SDK. -->

# Groups — operations

Accessor: `client.Groups` · Source: `src/Discourse/Api/Groups.cs` · 9 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddGroupMembers

- **Signature**: `AddGroupMembers(AddGroupMembersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `GroupsMembersJsonResponse1`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AddGroupMembersRequest` | `src/Discourse/Requests/Groups/AddGroupMembersRequest.cs` |
| `GroupsMembersJsonRequest` | `src/Discourse/Models/GroupsMembersJsonRequest.cs` |
| `GroupsMembersJsonResponse1` | `src/Discourse/Models/GroupsMembersJsonResponse1.cs` |

### CreateGroup

- **Signature**: `CreateGroup(CreateGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `AdminGroupsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateGroupRequest` | `src/Discourse/Requests/Groups/CreateGroupRequest.cs` |
| `AdminGroupsJsonRequest` | `src/Discourse/Models/AdminGroupsJsonRequest.cs` |
| `AdminGroupsJsonResponse` | `src/Discourse/Models/AdminGroupsJsonResponse.cs` |

### DeleteGroup

- **Signature**: `DeleteGroup(DeleteGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AdminGroupsJsonResponse1`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteGroupRequest` | `src/Discourse/Requests/Groups/DeleteGroupRequest.cs` |
| `AdminGroupsJsonResponse1` | `src/Discourse/Models/AdminGroupsJsonResponse1.cs` |

### GetGroup

- **Signature**: `GetGroup(GetGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Name`
- **Returns**: `GroupsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetGroupRequest` | `src/Discourse/Requests/Groups/GetGroupRequest.cs` |
| `GroupsJsonResponse` | `src/Discourse/Models/GroupsJsonResponse.cs` |

### GetGroupById

- **Signature**: `GetGroupById(GetGroupByIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `GroupsByIdJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetGroupByIdRequest` | `src/Discourse/Requests/Groups/GetGroupByIdRequest.cs` |
| `GroupsByIdJsonResponse` | `src/Discourse/Models/GroupsByIdJsonResponse.cs` |

### ListGroupMembers

- **Signature**: `ListGroupMembers(ListGroupMembersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Name`
- **Returns**: `GroupsMembersJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListGroupMembersRequest` | `src/Discourse/Requests/Groups/ListGroupMembersRequest.cs` |
| `GroupsMembersJsonResponse` | `src/Discourse/Models/GroupsMembersJsonResponse.cs` |

### ListGroups

- **Signature**: `ListGroups(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GroupsJsonResponse2`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GroupsJsonResponse2` | `src/Discourse/Models/GroupsJsonResponse2.cs` |

### RemoveGroupMembers

- **Signature**: `RemoveGroupMembers(RemoveGroupMembersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `GroupsMembersJsonResponse2`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RemoveGroupMembersRequest` | `src/Discourse/Requests/Groups/RemoveGroupMembersRequest.cs` |
| `GroupsMembersJsonRequest` | `src/Discourse/Models/GroupsMembersJsonRequest.cs` |
| `GroupsMembersJsonResponse2` | `src/Discourse/Models/GroupsMembersJsonResponse2.cs` |

### UpdateGroup

- **Signature**: `UpdateGroup(UpdateGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `GroupsJsonResponse1`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateGroupRequest` | `src/Discourse/Requests/Groups/UpdateGroupRequest.cs` |
| `GroupsJsonRequest` | `src/Discourse/Models/GroupsJsonRequest.cs` |
| `GroupsJsonResponse1` | `src/Discourse/Models/GroupsJsonResponse1.cs` |

