<!-- Generated file — do not edit; regenerated with the SDK. -->

# Invites — operations

Accessor: `client.Invites` · Source: `src/Discourse/Api/Invites.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateInvite

- **Signature**: `CreateInvite(CreateInviteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ApiKey`, `ApiUsername`
- **Returns**: `InvitesJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateInviteRequest` | `src/Discourse/Requests/Invites/CreateInviteRequest.cs` |
| `InvitesJsonRequest` | `src/Discourse/Models/InvitesJsonRequest.cs` |
| `InvitesJsonResponse` | `src/Discourse/Models/InvitesJsonResponse.cs` |

### CreateMultipleInvites

- **Signature**: `CreateMultipleInvites(CreateMultipleInvitesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ApiKey`, `ApiUsername`
- **Returns**: `InvitesCreateMultipleJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateMultipleInvitesRequest` | `src/Discourse/Requests/Invites/CreateMultipleInvitesRequest.cs` |
| `InvitesCreateMultipleJsonRequest` | `src/Discourse/Models/InvitesCreateMultipleJsonRequest.cs` |
| `InvitesCreateMultipleJsonResponse` | `src/Discourse/Models/InvitesCreateMultipleJsonResponse.cs` |

### InviteGroupToTopic

- **Signature**: `InviteGroupToTopic(InviteGroupToTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `TInviteGroupJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InviteGroupToTopicRequest` | `src/Discourse/Requests/Topics/InviteGroupToTopicRequest.cs` |
| `TInviteGroupJsonRequest` | `src/Discourse/Models/TInviteGroupJsonRequest.cs` |
| `TInviteGroupJsonResponse` | `src/Discourse/Models/TInviteGroupJsonResponse.cs` |

### InviteToTopic

- **Signature**: `InviteToTopic(InviteToTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ApiKey`, `ApiUsername`
- **Returns**: `TInviteJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InviteToTopicRequest` | `src/Discourse/Requests/Topics/InviteToTopicRequest.cs` |
| `TInviteJsonRequest` | `src/Discourse/Models/TInviteJsonRequest.cs` |
| `TInviteJsonResponse` | `src/Discourse/Models/TInviteJsonResponse.cs` |

