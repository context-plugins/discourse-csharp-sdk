<!-- Generated file — do not edit; regenerated with the SDK. -->

# Groups — operations

Accessor: `client.Groups` · Source: `Api/Groups.cs` · 9 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddGroupMembers

- **Signature**: `AddGroupMembers(AddGroupMembersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `GroupsMembersJsonResponse1`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AddGroupMembersRequest` | `Requests/Groups/AddGroupMembersRequest.cs` |
| `GroupsMembersJsonRequest` | `Models/GroupsMembersJsonRequest.cs` |
| `GroupsMembersJsonResponse1` | `Models/GroupsMembersJsonResponse1.cs` |

### CreateGroup

- **Signature**: `CreateGroup(CreateGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `AdminGroupsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateGroupRequest` | `Requests/Groups/CreateGroupRequest.cs` |
| `AdminGroupsJsonRequest` | `Models/AdminGroupsJsonRequest.cs` |
| `AdminGroupsJsonResponse` | `Models/AdminGroupsJsonResponse.cs` |

### DeleteGroup

- **Signature**: `DeleteGroup(DeleteGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AdminGroupsJsonResponse1`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteGroupRequest` | `Requests/Groups/DeleteGroupRequest.cs` |
| `AdminGroupsJsonResponse1` | `Models/AdminGroupsJsonResponse1.cs` |

### GetGroup

- **Signature**: `GetGroup(GetGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Name`
- **Returns**: `GroupsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetGroupRequest` | `Requests/Groups/GetGroupRequest.cs` |
| `GroupsJsonResponse` | `Models/GroupsJsonResponse.cs` |

### GetGroupById

- **Signature**: `GetGroupById(GetGroupByIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `GroupsByIdJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetGroupByIdRequest` | `Requests/Groups/GetGroupByIdRequest.cs` |
| `GroupsByIdJsonResponse` | `Models/GroupsByIdJsonResponse.cs` |

### ListGroupMembers

- **Signature**: `ListGroupMembers(ListGroupMembersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Name`
- **Returns**: `GroupsMembersJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListGroupMembersRequest` | `Requests/Groups/ListGroupMembersRequest.cs` |
| `GroupsMembersJsonResponse` | `Models/GroupsMembersJsonResponse.cs` |

### ListGroups

- **Signature**: `ListGroups(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GroupsJsonResponse2`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GroupsJsonResponse2` | `Models/GroupsJsonResponse2.cs` |

### RemoveGroupMembers

- **Signature**: `RemoveGroupMembers(RemoveGroupMembersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `GroupsMembersJsonResponse2`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RemoveGroupMembersRequest` | `Requests/Groups/RemoveGroupMembersRequest.cs` |
| `GroupsMembersJsonRequest` | `Models/GroupsMembersJsonRequest.cs` |
| `GroupsMembersJsonResponse2` | `Models/GroupsMembersJsonResponse2.cs` |

### UpdateGroup

- **Signature**: `UpdateGroup(UpdateGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `GroupsJsonResponse1`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateGroupRequest` | `Requests/Groups/UpdateGroupRequest.cs` |
| `GroupsJsonRequest` | `Models/GroupsJsonRequest.cs` |
| `GroupsJsonResponse1` | `Models/GroupsJsonResponse1.cs` |

