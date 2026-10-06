<!-- Generated file — do not edit; regenerated with the SDK. -->

# Invites — operations

Accessor: `client.Invites` · Source: `Api/Invites.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateInvite

- **Signature**: `CreateInvite(CreateInviteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ApiKey`, `ApiUsername`
- **Returns**: `InvitesJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateInviteRequest` | `Requests/Invites/CreateInviteRequest.cs` |
| `InvitesJsonRequest` | `Models/InvitesJsonRequest.cs` |
| `InvitesJsonResponse` | `Models/InvitesJsonResponse.cs` |

### CreateMultipleInvites

- **Signature**: `CreateMultipleInvites(CreateMultipleInvitesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ApiKey`, `ApiUsername`
- **Returns**: `InvitesCreateMultipleJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateMultipleInvitesRequest` | `Requests/Invites/CreateMultipleInvitesRequest.cs` |
| `InvitesCreateMultipleJsonRequest` | `Models/InvitesCreateMultipleJsonRequest.cs` |
| `InvitesCreateMultipleJsonResponse` | `Models/InvitesCreateMultipleJsonResponse.cs` |

### InviteGroupToTopic

- **Signature**: `InviteGroupToTopic(InviteGroupToTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `TInviteGroupJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InviteGroupToTopicRequest` | `Requests/Topics/InviteGroupToTopicRequest.cs` |
| `TInviteGroupJsonRequest` | `Models/TInviteGroupJsonRequest.cs` |
| `TInviteGroupJsonResponse` | `Models/TInviteGroupJsonResponse.cs` |

### InviteToTopic

- **Signature**: `InviteToTopic(InviteToTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `TInviteJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InviteToTopicRequest` | `Requests/Topics/InviteToTopicRequest.cs` |
| `TInviteJsonRequest` | `Models/TInviteJsonRequest.cs` |
| `TInviteJsonResponse` | `Models/TInviteJsonResponse.cs` |

