<!-- Generated file — do not edit; regenerated with the SDK. -->

# Invites — operations

Accessor: `client.Invites` · Source: `Api/Invites.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateInvite

- **Signature**: `CreateInvite(string apiKey, string apiUsername, InvitesJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `InvitesJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InvitesJsonRequest` | `Models/InvitesJsonRequest.cs` |
| `InvitesJsonResponse` | `Models/InvitesJsonResponse.cs` |

### CreateMultipleInvites

- **Signature**: `CreateMultipleInvites(string apiKey, string apiUsername, InvitesCreateMultipleJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `InvitesCreateMultipleJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InvitesCreateMultipleJsonRequest` | `Models/InvitesCreateMultipleJsonRequest.cs` |
| `InvitesCreateMultipleJsonResponse` | `Models/InvitesCreateMultipleJsonResponse.cs` |

### InviteGroupToTopic

- **Signature**: `InviteGroupToTopic(string id, string apiKey, string apiUsername, TInviteGroupJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `TInviteGroupJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TInviteGroupJsonRequest` | `Models/TInviteGroupJsonRequest.cs` |
| `TInviteGroupJsonResponse` | `Models/TInviteGroupJsonResponse.cs` |

### InviteToTopic

- **Signature**: `InviteToTopic(string id, string apiKey, string apiUsername, TInviteJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `TInviteJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TInviteJsonRequest` | `Models/TInviteJsonRequest.cs` |
| `TInviteJsonResponse` | `Models/TInviteJsonResponse.cs` |

