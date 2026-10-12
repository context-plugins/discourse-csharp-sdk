# Reference

Every operation below is shown in its throwing form. On an error status it throws `ApiException<TError>` — the status code, headers, content type and the operation's error type, `RawError` (the raw body) when the spec declares none — and where an operation offers an `…AsResult` sibling, that sibling returns `ApiResult<TResponse, TError>` instead. A request that produces no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match the documented response type as `ResponseDeserializationException`, and a credential that cannot be applied as `AuthSchemeException`; all of them derive from `SdkException` and name the failed call. See [README → Error Handling](README.md#error-handling).

> Source: [DiscourseClient](src/Discourse/DiscourseClient.cs)

## Admin

> Source: [Admin](src/Discourse/Api/Admin.cs)

<details>
<summary><code>Task&lt;AdminUsersActivateJsonResponse&gt; ActivateUser(ActivateUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.ActivateUser(new ActivateUserRequest { Id = 1 });
    // TODO: Handle 'response' of type AdminUsersActivateJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ActivateUserRequest](src/Discourse/Requests/Users/ActivateUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersActivateJsonResponse](src/Discourse/Models/AdminUsersActivateJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersJsonResponse&gt; AdminGetUser(AdminGetUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminGetUser(new AdminGetUserRequest { Id = 1 });
    // TODO: Handle 'response' of type AdminUsersJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminGetUserRequest](src/Discourse/Requests/Users/AdminGetUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersJsonResponse](src/Discourse/Models/AdminUsersJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;AdminUsersJsonResponse2&gt;&gt; AdminListUsers(AdminListUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminListUsers(new AdminListUsersRequest());
    // TODO: Handle 'response' of type IReadOnlyList<AdminUsersJsonResponse2>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminListUsersRequest](src/Discourse/Requests/Users/AdminListUsersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[AdminUsersJsonResponse2](src/Discourse/Models/AdminUsersJsonResponse2.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;AdminUsersListJsonResponse&gt;&gt; AdminListUsersFlag(AdminListUsersFlagRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminListUsersFlag(new AdminListUsersFlagRequest { Flag = Flag.Active });
    // TODO: Handle 'response' of type IReadOnlyList<AdminUsersListJsonResponse>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminListUsersFlagRequest](src/Discourse/Requests/Users/AdminListUsersFlagRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[AdminUsersListJsonResponse](src/Discourse/Models/AdminUsersListJsonResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersAnonymizeJsonResponse&gt; AnonymizeUser(AnonymizeUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AnonymizeUser(new AnonymizeUserRequest { Id = 1 });
    // TODO: Handle 'response' of type AdminUsersAnonymizeJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AnonymizeUserRequest](src/Discourse/Requests/Users/AnonymizeUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersAnonymizeJsonResponse](src/Discourse/Models/AdminUsersAnonymizeJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersDeactivateJsonResponse&gt; DeactivateUser(DeactivateUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.DeactivateUser(new DeactivateUserRequest { Id = 1 });
    // TODO: Handle 'response' of type AdminUsersDeactivateJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeactivateUserRequest](src/Discourse/Requests/Users/DeactivateUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersDeactivateJsonResponse](src/Discourse/Models/AdminUsersDeactivateJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersJsonResponse1&gt; DeleteUser(DeleteUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.DeleteUser(new DeleteUserRequest { Id = 1 });
    // TODO: Handle 'response' of type AdminUsersJsonResponse1
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteUserRequest](src/Discourse/Requests/Users/DeleteUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersJsonResponse1](src/Discourse/Models/AdminUsersJsonResponse1.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersLogOutJsonResponse&gt; LogOutUser(LogOutUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.LogOutUser(new LogOutUserRequest { Id = 1 });
    // TODO: Handle 'response' of type AdminUsersLogOutJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[LogOutUserRequest](src/Discourse/Requests/Users/LogOutUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersLogOutJsonResponse](src/Discourse/Models/AdminUsersLogOutJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserAvatarRefreshGravatarJsonResponse&gt; RefreshGravatar(RefreshGravatarRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.RefreshGravatar(new RefreshGravatarRequest { Username = "some example string" });
    // TODO: Handle 'response' of type UserAvatarRefreshGravatarJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RefreshGravatarRequest](src/Discourse/Requests/Users/RefreshGravatarRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserAvatarRefreshGravatarJsonResponse](src/Discourse/Models/UserAvatarRefreshGravatarJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersSilenceJsonResponse&gt; SilenceUser(SilenceUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.SilenceUser(new SilenceUserRequest { Id = 1 });
    // TODO: Handle 'response' of type AdminUsersSilenceJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SilenceUserRequest](src/Discourse/Requests/Users/SilenceUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersSilenceJsonResponse](src/Discourse/Models/AdminUsersSilenceJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersSuspendJsonResponse&gt; SuspendUser(SuspendUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.SuspendUser(new SuspendUserRequest { Id = 1 });
    // TODO: Handle 'response' of type AdminUsersSuspendJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SuspendUserRequest](src/Discourse/Requests/Users/SuspendUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersSuspendJsonResponse](src/Discourse/Models/AdminUsersSuspendJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Backups

> Source: [Backups](src/Discourse/Api/Backups.cs)

<details>
<summary><code>Task&lt;AdminBackupsJsonResponse1&gt; CreateBackup(CreateBackupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Backups.CreateBackup(new CreateBackupRequest());
    // TODO: Handle 'response' of type AdminBackupsJsonResponse1
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateBackupRequest](src/Discourse/Requests/Backups/CreateBackupRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminBackupsJsonResponse1](src/Discourse/Models/AdminBackupsJsonResponse1.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DownloadBackup(DownloadBackupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Backups.DownloadBackup(new DownloadBackupRequest
    {
        Filename = "some example string",
        Token = "some example string",
    });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DownloadBackupRequest](src/Discourse/Requests/Backups/DownloadBackupRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;AdminBackupsJsonResponse&gt;&gt; GetBackups(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Backups.GetBackups();
    // TODO: Handle 'response' of type IReadOnlyList<AdminBackupsJsonResponse>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[AdminBackupsJsonResponse](src/Discourse/Models/AdminBackupsJsonResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task SendDownloadBackupEmail(SendDownloadBackupEmailRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Backups.SendDownloadBackupEmail(new SendDownloadBackupEmailRequest
    {
        Filename = "some example string",
    });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SendDownloadBackupEmailRequest](src/Discourse/Requests/Backups/SendDownloadBackupEmailRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Badges

> Source: [Badges](src/Discourse/Api/Badges.cs)

<details>
<summary><code>Task&lt;AdminBadgesJsonResponse&gt; AdminListBadges(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Badges.AdminListBadges();
    // TODO: Handle 'response' of type AdminBadgesJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminBadgesJsonResponse](src/Discourse/Models/AdminBadgesJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminBadgesJsonResponse1&gt; CreateBadge(CreateBadgeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Badges.CreateBadge(new CreateBadgeRequest());
    // TODO: Handle 'response' of type AdminBadgesJsonResponse1
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateBadgeRequest](src/Discourse/Requests/Badges/CreateBadgeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminBadgesJsonResponse1](src/Discourse/Models/AdminBadgesJsonResponse1.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteBadge(DeleteBadgeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Badges.DeleteBadge(new DeleteBadgeRequest { Id = 1 });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteBadgeRequest](src/Discourse/Requests/Badges/DeleteBadgeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserBadgesJsonResponse&gt; ListUserBadges(ListUserBadgesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Badges.ListUserBadges(new ListUserBadgesRequest { Username = "some example string" });
    // TODO: Handle 'response' of type UserBadgesJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListUserBadgesRequest](src/Discourse/Requests/Badges/ListUserBadgesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserBadgesJsonResponse](src/Discourse/Models/UserBadgesJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminBadgesJsonResponse2&gt; UpdateBadge(UpdateBadgeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Badges.UpdateBadge(new UpdateBadgeRequest { Id = 1 });
    // TODO: Handle 'response' of type AdminBadgesJsonResponse2
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateBadgeRequest](src/Discourse/Requests/Badges/UpdateBadgeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminBadgesJsonResponse2](src/Discourse/Models/AdminBadgesJsonResponse2.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Categories

> Source: [Categories](src/Discourse/Api/Categories.cs)

<details>
<summary><code>Task&lt;CategoriesJsonResponse&gt; CreateCategory(CreateCategoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Categories.CreateCategory(new CreateCategoryRequest());
    // TODO: Handle 'response' of type CategoriesJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateCategoryRequest](src/Discourse/Requests/Categories/CreateCategoryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CategoriesJsonResponse](src/Discourse/Models/CategoriesJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CShowJsonResponse&gt; GetCategory(GetCategoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Categories.GetCategory(new GetCategoryRequest { Id = 1 });
    // TODO: Handle 'response' of type CShowJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCategoryRequest](src/Discourse/Requests/Categories/GetCategoryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CShowJsonResponse](src/Discourse/Models/CShowJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SiteJsonResponse&gt; GetSite(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Can be used to fetch all categories and subcategories

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Categories.GetSite();
    // TODO: Handle 'response' of type SiteJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SiteJsonResponse](src/Discourse/Models/SiteJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CategoriesJsonResponse1&gt; ListCategories(ListCategoriesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Categories.ListCategories(new ListCategoriesRequest());
    // TODO: Handle 'response' of type CategoriesJsonResponse1
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCategoriesRequest](src/Discourse/Requests/Categories/ListCategoriesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CategoriesJsonResponse1](src/Discourse/Models/CategoriesJsonResponse1.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CJsonResponse&gt; ListCategoryTopics(ListCategoryTopicsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Categories.ListCategoryTopics(new ListCategoryTopicsRequest
    {
        Slug = "some example string",
        Id = 1,
    });
    // TODO: Handle 'response' of type CJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCategoryTopicsRequest](src/Discourse/Requests/Categories/ListCategoryTopicsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CJsonResponse](src/Discourse/Models/CJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CategoriesJsonResponse2&gt; UpdateCategory(UpdateCategoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Categories.UpdateCategory(new UpdateCategoryRequest { Id = 1 });
    // TODO: Handle 'response' of type CategoriesJsonResponse2
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateCategoryRequest](src/Discourse/Requests/Categories/UpdateCategoryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CategoriesJsonResponse2](src/Discourse/Models/CategoriesJsonResponse2.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DiscourseCalendarEvents

> Source: [DiscourseCalendarEvents](src/Discourse/Api/DiscourseCalendarEvents.cs)

<details>
<summary><code>Task ExportEventsIcs(ExportEventsIcsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.DiscourseCalendarEvents.ExportEventsIcs(new ExportEventsIcsRequest());
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ExportEventsIcsRequest](src/Discourse/Requests/DiscourseCalendarEvents/ExportEventsIcsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DiscoursePostEventEventsJsonResponse&gt; ListEvents(ListEventsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DiscourseCalendarEvents.ListEvents(new ListEventsRequest());
    // TODO: Handle 'response' of type DiscoursePostEventEventsJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListEventsRequest](src/Discourse/Requests/DiscourseCalendarEvents/ListEventsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DiscoursePostEventEventsJsonResponse](src/Discourse/Models/DiscoursePostEventEventsJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Groups

> Source: [Groups](src/Discourse/Api/Groups.cs)

<details>
<summary><code>Task&lt;GroupsMembersJsonResponse1&gt; AddGroupMembers(AddGroupMembersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Groups.AddGroupMembers(new AddGroupMembersRequest { Id = 1 });
    // TODO: Handle 'response' of type GroupsMembersJsonResponse1
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AddGroupMembersRequest](src/Discourse/Requests/Groups/AddGroupMembersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GroupsMembersJsonResponse1](src/Discourse/Models/GroupsMembersJsonResponse1.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminGroupsJsonResponse&gt; CreateGroup(CreateGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Groups.CreateGroup(new CreateGroupRequest());
    // TODO: Handle 'response' of type AdminGroupsJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateGroupRequest](src/Discourse/Requests/Groups/CreateGroupRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminGroupsJsonResponse](src/Discourse/Models/AdminGroupsJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminGroupsJsonResponse1&gt; DeleteGroup(DeleteGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Groups.DeleteGroup(new DeleteGroupRequest { Id = 1 });
    // TODO: Handle 'response' of type AdminGroupsJsonResponse1
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteGroupRequest](src/Discourse/Requests/Groups/DeleteGroupRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminGroupsJsonResponse1](src/Discourse/Models/AdminGroupsJsonResponse1.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GroupsJsonResponse&gt; GetGroup(GetGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Groups.GetGroup(new GetGroupRequest { Name = "name" });
    // TODO: Handle 'response' of type GroupsJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetGroupRequest](src/Discourse/Requests/Groups/GetGroupRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GroupsJsonResponse](src/Discourse/Models/GroupsJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GroupsByIdJsonResponse&gt; GetGroupById(GetGroupByIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Groups.GetGroupById(new GetGroupByIdRequest { Id = "name" });
    // TODO: Handle 'response' of type GroupsByIdJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetGroupByIdRequest](src/Discourse/Requests/Groups/GetGroupByIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GroupsByIdJsonResponse](src/Discourse/Models/GroupsByIdJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GroupsMembersJsonResponse&gt; ListGroupMembers(ListGroupMembersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Groups.ListGroupMembers(new ListGroupMembersRequest { Name = "name" });
    // TODO: Handle 'response' of type GroupsMembersJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListGroupMembersRequest](src/Discourse/Requests/Groups/ListGroupMembersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GroupsMembersJsonResponse](src/Discourse/Models/GroupsMembersJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GroupsJsonResponse2&gt; ListGroups(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Groups.ListGroups();
    // TODO: Handle 'response' of type GroupsJsonResponse2
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GroupsJsonResponse2](src/Discourse/Models/GroupsJsonResponse2.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GroupsMembersJsonResponse2&gt; RemoveGroupMembers(RemoveGroupMembersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Groups.RemoveGroupMembers(new RemoveGroupMembersRequest { Id = 1 });
    // TODO: Handle 'response' of type GroupsMembersJsonResponse2
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RemoveGroupMembersRequest](src/Discourse/Requests/Groups/RemoveGroupMembersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GroupsMembersJsonResponse2](src/Discourse/Models/GroupsMembersJsonResponse2.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GroupsJsonResponse1&gt; UpdateGroup(UpdateGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Groups.UpdateGroup(new UpdateGroupRequest { Id = 1 });
    // TODO: Handle 'response' of type GroupsJsonResponse1
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateGroupRequest](src/Discourse/Requests/Groups/UpdateGroupRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GroupsJsonResponse1](src/Discourse/Models/GroupsJsonResponse1.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Invites

> Source: [Invites](src/Discourse/Api/Invites.cs)

<details>
<summary><code>Task&lt;InvitesJsonResponse&gt; CreateInvite(CreateInviteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invites.CreateInvite(new CreateInviteRequest
    {
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type InvitesJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateInviteRequest](src/Discourse/Requests/Invites/CreateInviteRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvitesJsonResponse](src/Discourse/Models/InvitesJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvitesCreateMultipleJsonResponse&gt; CreateMultipleInvites(CreateMultipleInvitesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invites.CreateMultipleInvites(new CreateMultipleInvitesRequest
    {
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type InvitesCreateMultipleJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateMultipleInvitesRequest](src/Discourse/Requests/Invites/CreateMultipleInvitesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvitesCreateMultipleJsonResponse](src/Discourse/Models/InvitesCreateMultipleJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TInviteGroupJsonResponse&gt; InviteGroupToTopic(InviteGroupToTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invites.InviteGroupToTopic(new InviteGroupToTopicRequest
    {
        Id = "some example string",
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type TInviteGroupJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[InviteGroupToTopicRequest](src/Discourse/Requests/Topics/InviteGroupToTopicRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TInviteGroupJsonResponse](src/Discourse/Models/TInviteGroupJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TInviteJsonResponse&gt; InviteToTopic(InviteToTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invites.InviteToTopic(new InviteToTopicRequest
    {
        Id = "some example string",
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type TInviteJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[InviteToTopicRequest](src/Discourse/Requests/Topics/InviteToTopicRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TInviteJsonResponse](src/Discourse/Models/TInviteJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Notifications

> Source: [Notifications](src/Discourse/Api/Notifications.cs)

<details>
<summary><code>Task&lt;NotificationsJsonResponse&gt; GetNotifications(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Notifications.GetNotifications();
    // TODO: Handle 'response' of type NotificationsJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NotificationsJsonResponse](src/Discourse/Models/NotificationsJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;NotificationsMarkReadJsonResponse&gt; MarkNotificationsAsRead(MarkNotificationsAsReadRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Notifications.MarkNotificationsAsRead(new MarkNotificationsAsReadRequest());
    // TODO: Handle 'response' of type NotificationsMarkReadJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[MarkNotificationsAsReadRequest](src/Discourse/Requests/Notifications/MarkNotificationsAsReadRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NotificationsMarkReadJsonResponse](src/Discourse/Models/NotificationsMarkReadJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Posts

> Source: [Posts](src/Discourse/Api/Posts.cs)

<details>
<summary><code>Task&lt;PostsJsonResponse1&gt; CreateTopicPostPm(CreateTopicPostPmRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Posts.CreateTopicPostPm(new CreateTopicPostPmRequest
    {
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type PostsJsonResponse1
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateTopicPostPmRequest](src/Discourse/Requests/Posts/CreateTopicPostPmRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PostsJsonResponse1](src/Discourse/Models/PostsJsonResponse1.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeletePost(DeletePostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Posts.DeletePost(new DeletePostRequest
    {
        Id = 1,
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeletePostRequest](src/Discourse/Requests/Posts/DeletePostRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PostsJsonResponse2&gt; GetPost(GetPostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint can be used to get the number of likes on a post using the
`actions_summary` property in the response. `actions_summary` responses
with the id of `2` signify a `like`. If there are no `actions_summary`
items with the id of `2`, that means there are 0 likes. Other ids likely
refer to various different flag types.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Posts.GetPost(new GetPostRequest { Id = "some example string" });
    // TODO: Handle 'response' of type PostsJsonResponse2
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPostRequest](src/Discourse/Requests/Posts/GetPostRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PostsJsonResponse2](src/Discourse/Models/PostsJsonResponse2.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PostsJsonResponse&gt; ListPosts(ListPostsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Posts.ListPosts(new ListPostsRequest());
    // TODO: Handle 'response' of type PostsJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListPostsRequest](src/Discourse/Requests/Posts/ListPostsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PostsJsonResponse](src/Discourse/Models/PostsJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PostsLockedJsonResponse&gt; LockPost(LockPostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Posts.LockPost(new LockPostRequest
    {
        Id = "some example string",
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type PostsLockedJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[LockPostRequest](src/Discourse/Requests/Posts/LockPostRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PostsLockedJsonResponse](src/Discourse/Models/PostsLockedJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PostActionsJsonResponse&gt; PerformPostAction(PerformPostActionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Posts.PerformPostAction(new PerformPostActionRequest
    {
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type PostActionsJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PerformPostActionRequest](src/Discourse/Requests/Posts/PerformPostActionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PostActionsJsonResponse](src/Discourse/Models/PostActionsJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;PostsRepliesJsonResponse&gt;&gt; PostReplies(PostRepliesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Posts.PostReplies(new PostRepliesRequest { Id = "some example string" });
    // TODO: Handle 'response' of type IReadOnlyList<PostsRepliesJsonResponse>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostRepliesRequest](src/Discourse/Requests/Posts/PostRepliesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[PostsRepliesJsonResponse](src/Discourse/Models/PostsRepliesJsonResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PostsJsonResponse3&gt; UpdatePost(UpdatePostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Posts.UpdatePost(new UpdatePostRequest
    {
        Id = "some example string",
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type PostsJsonResponse3
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdatePostRequest](src/Discourse/Requests/Posts/UpdatePostRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PostsJsonResponse3](src/Discourse/Models/PostsJsonResponse3.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PrivateMessages

> Source: [PrivateMessages](src/Discourse/Api/PrivateMessages.cs)

<details>
<summary><code>Task&lt;PostsJsonResponse1&gt; CreateTopicPostPm(CreateTopicPostPmRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PrivateMessages.CreateTopicPostPm(new CreateTopicPostPmRequest
    {
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type PostsJsonResponse1
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateTopicPostPmRequest](src/Discourse/Requests/Posts/CreateTopicPostPmRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PostsJsonResponse1](src/Discourse/Models/PostsJsonResponse1.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TopicsPrivateMessagesSentJsonResponse&gt; GetUserSentPrivateMessages(GetUserSentPrivateMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PrivateMessages.GetUserSentPrivateMessages(new GetUserSentPrivateMessagesRequest
    {
        Username = "some example string",
    });
    // TODO: Handle 'response' of type TopicsPrivateMessagesSentJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetUserSentPrivateMessagesRequest](src/Discourse/Requests/PrivateMessages/GetUserSentPrivateMessagesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TopicsPrivateMessagesSentJsonResponse](src/Discourse/Models/TopicsPrivateMessagesSentJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TopicsPrivateMessagesJsonResponse&gt; ListUserPrivateMessages(ListUserPrivateMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PrivateMessages.ListUserPrivateMessages(new ListUserPrivateMessagesRequest
    {
        Username = "some example string",
    });
    // TODO: Handle 'response' of type TopicsPrivateMessagesJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListUserPrivateMessagesRequest](src/Discourse/Requests/PrivateMessages/ListUserPrivateMessagesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TopicsPrivateMessagesJsonResponse](src/Discourse/Models/TopicsPrivateMessagesJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Search

> Source: [Search](src/Discourse/Api/Search.cs)

<details>
<summary><code>Task&lt;SearchJsonResponse&gt; SearchInvoke(SearchRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Search.SearchInvoke(new SearchRequest
    {
        Q = "api @blake #support tags:api after:2021-06-04 in:unseen in:open\norder:latest_topic",
        Page = 1,
    });
    // TODO: Handle 'response' of type SearchJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchRequest](src/Discourse/Requests/Search/SearchRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchJsonResponse](src/Discourse/Models/SearchJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Site

> Source: [Site](src/Discourse/Api/Site.cs)

<details>
<summary><code>Task&lt;SiteJsonResponse&gt; GetSite(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Can be used to fetch all categories and subcategories

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Site.GetSite();
    // TODO: Handle 'response' of type SiteJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SiteJsonResponse](src/Discourse/Models/SiteJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SiteBasicInfoJsonResponse&gt; GetSiteBasicInfo(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Can be used to fetch basic info about a site

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Site.GetSiteBasicInfo();
    // TODO: Handle 'response' of type SiteBasicInfoJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SiteBasicInfoJsonResponse](src/Discourse/Models/SiteBasicInfoJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Tags

> Source: [Tags](src/Discourse/Api/Tags.cs)

<details>
<summary><code>Task&lt;TagGroupsJsonResponse1&gt; CreateTagGroup(CreateTagGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Tags.CreateTagGroup(new CreateTagGroupRequest());
    // TODO: Handle 'response' of type TagGroupsJsonResponse1
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateTagGroupRequest](src/Discourse/Requests/Tags/CreateTagGroupRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TagGroupsJsonResponse1](src/Discourse/Models/TagGroupsJsonResponse1.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TagJsonResponse&gt; GetTag(GetTagRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Tags.GetTag(new GetTagRequest { Name = "some example string" });
    // TODO: Handle 'response' of type TagJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTagRequest](src/Discourse/Requests/Tags/GetTagRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TagJsonResponse](src/Discourse/Models/TagJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TagGroupsJsonResponse2&gt; GetTagGroup(GetTagGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Tags.GetTagGroup(new GetTagGroupRequest { Id = "some example string" });
    // TODO: Handle 'response' of type TagGroupsJsonResponse2
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTagGroupRequest](src/Discourse/Requests/Tags/GetTagGroupRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TagGroupsJsonResponse2](src/Discourse/Models/TagGroupsJsonResponse2.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TagGroupsJsonResponse&gt; ListTagGroups(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Tags.ListTagGroups();
    // TODO: Handle 'response' of type TagGroupsJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TagGroupsJsonResponse](src/Discourse/Models/TagGroupsJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TagsJsonResponse&gt; ListTags(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Tags.ListTags();
    // TODO: Handle 'response' of type TagsJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TagsJsonResponse](src/Discourse/Models/TagsJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TagGroupsJsonResponse3&gt; UpdateTagGroup(UpdateTagGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Tags.UpdateTagGroup(new UpdateTagGroupRequest { Id = "some example string" });
    // TODO: Handle 'response' of type TagGroupsJsonResponse3
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateTagGroupRequest](src/Discourse/Requests/Tags/UpdateTagGroupRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TagGroupsJsonResponse3](src/Discourse/Models/TagGroupsJsonResponse3.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Topics

> Source: [Topics](src/Discourse/Api/Topics.cs)

<details>
<summary><code>Task BookmarkTopic(BookmarkTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Topics.BookmarkTopic(new BookmarkTopicRequest
    {
        Id = "some example string",
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BookmarkTopicRequest](src/Discourse/Requests/Topics/BookmarkTopicRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PostsJsonResponse1&gt; CreateTopicPostPm(CreateTopicPostPmRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Topics.CreateTopicPostPm(new CreateTopicPostPmRequest
    {
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type PostsJsonResponse1
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateTopicPostPmRequest](src/Discourse/Requests/Posts/CreateTopicPostPmRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PostsJsonResponse1](src/Discourse/Models/PostsJsonResponse1.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TTimerJsonResponse&gt; CreateTopicTimer(CreateTopicTimerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Topics.CreateTopicTimer(new CreateTopicTimerRequest
    {
        Id = "some example string",
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type TTimerJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateTopicTimerRequest](src/Discourse/Requests/Topics/CreateTopicTimerRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TTimerJsonResponse](src/Discourse/Models/TTimerJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TPostsJsonResponse&gt; GetSpecificPostsFromTopic(GetSpecificPostsFromTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Topics.GetSpecificPostsFromTopic(new GetSpecificPostsFromTopicRequest
    {
        Id = "some example string",
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type TPostsJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSpecificPostsFromTopicRequest](src/Discourse/Requests/Topics/GetSpecificPostsFromTopicRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TPostsJsonResponse](src/Discourse/Models/TPostsJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TJsonResponse&gt; GetTopic(GetTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Topics.GetTopic(new GetTopicRequest
    {
        Id = "some example string",
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type TJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTopicRequest](src/Discourse/Requests/Topics/GetTopicRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TJsonResponse](src/Discourse/Models/TJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetTopicByExternalId(GetTopicByExternalIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Topics.GetTopicByExternalId(new GetTopicByExternalIdRequest { ExternalId = "some example string" });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTopicByExternalIdRequest](src/Discourse/Requests/Topics/GetTopicByExternalIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TInviteGroupJsonResponse&gt; InviteGroupToTopic(InviteGroupToTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Topics.InviteGroupToTopic(new InviteGroupToTopicRequest
    {
        Id = "some example string",
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type TInviteGroupJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[InviteGroupToTopicRequest](src/Discourse/Requests/Topics/InviteGroupToTopicRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TInviteGroupJsonResponse](src/Discourse/Models/TInviteGroupJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TInviteJsonResponse&gt; InviteToTopic(InviteToTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Topics.InviteToTopic(new InviteToTopicRequest
    {
        Id = "some example string",
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type TInviteJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[InviteToTopicRequest](src/Discourse/Requests/Topics/InviteToTopicRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TInviteJsonResponse](src/Discourse/Models/TInviteJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LatestJsonResponse&gt; ListLatestTopics(ListLatestTopicsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Topics.ListLatestTopics(new ListLatestTopicsRequest
    {
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type LatestJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListLatestTopicsRequest](src/Discourse/Requests/Topics/ListLatestTopicsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LatestJsonResponse](src/Discourse/Models/LatestJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TopJsonResponse&gt; ListTopTopics(ListTopTopicsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Topics.ListTopTopics(new ListTopTopicsRequest
    {
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type TopJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListTopTopicsRequest](src/Discourse/Requests/Topics/ListTopTopicsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TopJsonResponse](src/Discourse/Models/TopJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task RemoveTopic(RemoveTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Topics.RemoveTopic(new RemoveTopicRequest
    {
        Id = "some example string",
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RemoveTopicRequest](src/Discourse/Requests/Topics/RemoveTopicRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TNotificationsJsonResponse&gt; SetNotificationLevel(SetNotificationLevelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Topics.SetNotificationLevel(new SetNotificationLevelRequest
    {
        Id = "some example string",
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type TNotificationsJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SetNotificationLevelRequest](src/Discourse/Requests/Topics/SetNotificationLevelRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TNotificationsJsonResponse](src/Discourse/Models/TNotificationsJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TJsonResponse1&gt; UpdateTopic(UpdateTopicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Topics.UpdateTopic(new UpdateTopicRequest
    {
        Id = "some example string",
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type TJsonResponse1
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateTopicRequest](src/Discourse/Requests/Topics/UpdateTopicRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TJsonResponse1](src/Discourse/Models/TJsonResponse1.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TStatusJsonResponse&gt; UpdateTopicStatus(UpdateTopicStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Topics.UpdateTopicStatus(new UpdateTopicStatusRequest
    {
        Id = "some example string",
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type TStatusJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateTopicStatusRequest](src/Discourse/Requests/Topics/UpdateTopicStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TStatusJsonResponse](src/Discourse/Models/TStatusJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TChangeTimestampJsonResponse&gt; UpdateTopicTimestamp(UpdateTopicTimestampRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Topics.UpdateTopicTimestamp(new UpdateTopicTimestampRequest
    {
        Id = "some example string",
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type TChangeTimestampJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateTopicTimestampRequest](src/Discourse/Requests/Topics/UpdateTopicTimestampRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TChangeTimestampJsonResponse](src/Discourse/Models/TChangeTimestampJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Uploads

> Source: [Uploads](src/Discourse/Api/Uploads.cs)

<details>
<summary><code>Task&lt;UploadsAbortMultipartJsonResponse&gt; AbortMultipart(AbortMultipartRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint aborts the multipart upload initiated with /create-multipart.
This should be used when cancelling the upload. It does not matter if parts
were already uploaded into the external storage provider.

You must have the correct permissions and CORS settings configured in your
external provider. We support AWS S3 as the default. See:

https://meta.discourse.org/t/-/210469#s3-multipart-direct-uploads-4.

An external file store must be set up and `enable_direct_s3_uploads` must
be set to true for this endpoint to function.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Uploads.AbortMultipart(new AbortMultipartRequest());
    // TODO: Handle 'response' of type UploadsAbortMultipartJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AbortMultipartRequest](src/Discourse/Requests/Uploads/AbortMultipartRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadsAbortMultipartJsonResponse](src/Discourse/Models/UploadsAbortMultipartJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UploadsBatchPresignMultipartPartsJsonResponse&gt; BatchPresignMultipartParts(BatchPresignMultipartPartsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Multipart uploads are uploaded in chunks or parts to individual presigned
URLs, similar to the one generated by /generate-presigned-put. The part
numbers provided must be between 1 and 10000. The total number of parts
will depend on the chunk size in bytes that you intend to use to upload
each chunk. For example a 12MB file may have 2 5MB chunks and a final
2MB chunk, for part numbers 1, 2, and 3.

This endpoint will return a presigned URL for each part number provided,
which you can then use to send PUT requests for the binary chunk corresponding
to that part. When the part is uploaded, the provider should return an
ETag for the part, and this should be stored along with the part number,
because this is needed to complete the multipart upload.

You must have the correct permissions and CORS settings configured in your
external provider. We support AWS S3 as the default. See:

https://meta.discourse.org/t/-/210469#s3-multipart-direct-uploads-4.

An external file store must be set up and `enable_direct_s3_uploads` must
be set to true for this endpoint to function.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Uploads.BatchPresignMultipartParts(new BatchPresignMultipartPartsRequest());
    // TODO: Handle 'response' of type UploadsBatchPresignMultipartPartsJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BatchPresignMultipartPartsRequest](src/Discourse/Requests/Uploads/BatchPresignMultipartPartsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadsBatchPresignMultipartPartsJsonResponse](src/Discourse/Models/UploadsBatchPresignMultipartPartsJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UploadsCompleteExternalUploadJsonResponse&gt; CompleteExternalUpload(CompleteExternalUploadRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Completes an external upload initialized with /get-presigned-put. The
file will be moved from its temporary location in external storage to
a final destination in the S3 bucket. An Upload record will also be
created in the database in most cases.

If a sha1-checksum was provided in the initial request it will also
be compared with the uploaded file in storage to make sure the same
file was uploaded. The file size will be compared for the same reason.

You must have the correct permissions and CORS settings configured in your
external provider. We support AWS S3 as the default. See:

https://meta.discourse.org/t/-/210469#s3-multipart-direct-uploads-4.

An external file store must be set up and `enable_direct_s3_uploads` must
be set to true for this endpoint to function.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Uploads.CompleteExternalUpload(new CompleteExternalUploadRequest());
    // TODO: Handle 'response' of type UploadsCompleteExternalUploadJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CompleteExternalUploadRequest](src/Discourse/Requests/Uploads/CompleteExternalUploadRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadsCompleteExternalUploadJsonResponse](src/Discourse/Models/UploadsCompleteExternalUploadJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UploadsCompleteMultipartJsonResponse&gt; CompleteMultipart(CompleteMultipartRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Completes the multipart upload in the external store, and copies the
file from its temporary location to its final location in the store.
All of the parts must have been uploaded to the external storage provider.
An Upload record will be completed in most cases once the file is copied
to its final location.

You must have the correct permissions and CORS settings configured in your
external provider. We support AWS S3 as the default. See:

https://meta.discourse.org/t/-/210469#s3-multipart-direct-uploads-4.

An external file store must be set up and `enable_direct_s3_uploads` must
be set to true for this endpoint to function.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Uploads.CompleteMultipart(new CompleteMultipartRequest());
    // TODO: Handle 'response' of type UploadsCompleteMultipartJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CompleteMultipartRequest](src/Discourse/Requests/Uploads/CompleteMultipartRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadsCompleteMultipartJsonResponse](src/Discourse/Models/UploadsCompleteMultipartJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UploadsCreateMultipartJsonResponse&gt; CreateMultipartUpload(CreateMultipartUploadRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a multipart upload in the external storage provider, storing
a temporary reference to the external upload similar to /get-presigned-put.

You must have the correct permissions and CORS settings configured in your
external provider. We support AWS S3 as the default. See:

https://meta.discourse.org/t/-/210469#s3-multipart-direct-uploads-4.

An external file store must be set up and `enable_direct_s3_uploads` must
be set to true for this endpoint to function.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Uploads.CreateMultipartUpload(new CreateMultipartUploadRequest());
    // TODO: Handle 'response' of type UploadsCreateMultipartJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateMultipartUploadRequest](src/Discourse/Requests/Uploads/CreateMultipartUploadRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadsCreateMultipartJsonResponse](src/Discourse/Models/UploadsCreateMultipartJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UploadsJsonResponse&gt; CreateUpload(CreateUploadRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Uploads.CreateUpload(new CreateUploadRequest { UploadType = UploadType.Avatar });
    // TODO: Handle 'response' of type UploadsJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateUploadRequest](src/Discourse/Requests/Uploads/CreateUploadRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadsJsonResponse](src/Discourse/Models/UploadsJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UploadsGeneratePresignedPutJsonResponse&gt; GeneratePresignedPut(GeneratePresignedPutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Direct external uploads bypass the usual method of creating uploads
via the POST /uploads route, and upload directly to an external provider,
which by default is S3. This route begins the process, and will return
a unique identifier for the external upload as well as a presigned URL
which is where the file binary blob should be uploaded to.

Once the upload is complete to the external service, you must call the
POST /complete-external-upload route using the unique identifier returned
by this route, which will create any required Upload record in the Discourse
database and also move file from its temporary location to the final
destination in the external storage service.

You must have the correct permissions and CORS settings configured in your
external provider. We support AWS S3 as the default. See:

https://meta.discourse.org/t/-/210469#s3-multipart-direct-uploads-4.

An external file store must be set up and `enable_direct_s3_uploads` must
be set to true for this endpoint to function.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Uploads.GeneratePresignedPut(new GeneratePresignedPutRequest());
    // TODO: Handle 'response' of type UploadsGeneratePresignedPutJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GeneratePresignedPutRequest](src/Discourse/Requests/Uploads/GeneratePresignedPutRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadsGeneratePresignedPutJsonResponse](src/Discourse/Models/UploadsGeneratePresignedPutJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Users

> Source: [Users](src/Discourse/Api/Users.cs)

<details>
<summary><code>Task&lt;AdminUsersActivateJsonResponse&gt; ActivateUser(ActivateUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.ActivateUser(new ActivateUserRequest { Id = 1 });
    // TODO: Handle 'response' of type AdminUsersActivateJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ActivateUserRequest](src/Discourse/Requests/Users/ActivateUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersActivateJsonResponse](src/Discourse/Models/AdminUsersActivateJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersJsonResponse&gt; AdminGetUser(AdminGetUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.AdminGetUser(new AdminGetUserRequest { Id = 1 });
    // TODO: Handle 'response' of type AdminUsersJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminGetUserRequest](src/Discourse/Requests/Users/AdminGetUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersJsonResponse](src/Discourse/Models/AdminUsersJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;AdminUsersJsonResponse2&gt;&gt; AdminListUsers(AdminListUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.AdminListUsers(new AdminListUsersRequest());
    // TODO: Handle 'response' of type IReadOnlyList<AdminUsersJsonResponse2>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminListUsersRequest](src/Discourse/Requests/Users/AdminListUsersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[AdminUsersJsonResponse2](src/Discourse/Models/AdminUsersJsonResponse2.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;AdminUsersListJsonResponse&gt;&gt; AdminListUsersFlag(AdminListUsersFlagRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.AdminListUsersFlag(new AdminListUsersFlagRequest { Flag = Flag.Active });
    // TODO: Handle 'response' of type IReadOnlyList<AdminUsersListJsonResponse>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminListUsersFlagRequest](src/Discourse/Requests/Users/AdminListUsersFlagRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[AdminUsersListJsonResponse](src/Discourse/Models/AdminUsersListJsonResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersAnonymizeJsonResponse&gt; AnonymizeUser(AnonymizeUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.AnonymizeUser(new AnonymizeUserRequest { Id = 1 });
    // TODO: Handle 'response' of type AdminUsersAnonymizeJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AnonymizeUserRequest](src/Discourse/Requests/Users/AnonymizeUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersAnonymizeJsonResponse](src/Discourse/Models/AdminUsersAnonymizeJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task ChangePassword(ChangePasswordRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Users.ChangePassword(new ChangePasswordRequest { Token = "some example string" });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ChangePasswordRequest](src/Discourse/Requests/Users/ChangePasswordRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersJsonResponse&gt; CreateUser(CreateUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.CreateUser(new CreateUserRequest
    {
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type UsersJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateUserRequest](src/Discourse/Requests/Users/CreateUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersJsonResponse](src/Discourse/Models/UsersJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersDeactivateJsonResponse&gt; DeactivateUser(DeactivateUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.DeactivateUser(new DeactivateUserRequest { Id = 1 });
    // TODO: Handle 'response' of type AdminUsersDeactivateJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeactivateUserRequest](src/Discourse/Requests/Users/DeactivateUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersDeactivateJsonResponse](src/Discourse/Models/AdminUsersDeactivateJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersJsonResponse1&gt; DeleteUser(DeleteUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.DeleteUser(new DeleteUserRequest { Id = 1 });
    // TODO: Handle 'response' of type AdminUsersJsonResponse1
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteUserRequest](src/Discourse/Requests/Users/DeleteUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersJsonResponse1](src/Discourse/Models/AdminUsersJsonResponse1.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UJsonResponse&gt; GetUser(GetUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.GetUser(new GetUserRequest
    {
        Username = "some example string",
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type UJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetUserRequest](src/Discourse/Requests/Users/GetUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UJsonResponse](src/Discourse/Models/UJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UEmailsJsonResponse&gt; GetUserEmails(GetUserEmailsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.GetUserEmails(new GetUserEmailsRequest { Username = "some example string" });
    // TODO: Handle 'response' of type UEmailsJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetUserEmailsRequest](src/Discourse/Requests/Users/GetUserEmailsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UEmailsJsonResponse](src/Discourse/Models/UEmailsJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UByExternalJsonResponse&gt; GetUserExternalId(GetUserExternalIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.GetUserExternalId(new GetUserExternalIdRequest
    {
        ExternalId = "some example string",
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type UByExternalJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetUserExternalIdRequest](src/Discourse/Requests/Users/GetUserExternalIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UByExternalJsonResponse](src/Discourse/Models/UByExternalJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UByExternalJsonResponse&gt; GetUserIdentiyProviderExternalId(GetUserIdentiyProviderExternalIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.GetUserIdentiyProviderExternalId(new GetUserIdentiyProviderExternalIdRequest
    {
        Provider = "some example string",
        ExternalId = "some example string",
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type UByExternalJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetUserIdentiyProviderExternalIdRequest](src/Discourse/Requests/Users/GetUserIdentiyProviderExternalIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UByExternalJsonResponse](src/Discourse/Models/UByExternalJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserActionsJsonResponse&gt; ListUserActions(ListUserActionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.ListUserActions(new ListUserActionsRequest
    {
        Offset = 1,
        Username = "some example string",
        Filter = "some example string",
    });
    // TODO: Handle 'response' of type UserActionsJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListUserActionsRequest](src/Discourse/Requests/Users/ListUserActionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserActionsJsonResponse](src/Discourse/Models/UserActionsJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserBadgesJsonResponse&gt; ListUserBadges(ListUserBadgesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.ListUserBadges(new ListUserBadgesRequest { Username = "some example string" });
    // TODO: Handle 'response' of type UserBadgesJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListUserBadgesRequest](src/Discourse/Requests/Badges/ListUserBadgesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserBadgesJsonResponse](src/Discourse/Models/UserBadgesJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DirectoryItemsJsonResponse&gt; ListUsersPublic(ListUsersPublicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.ListUsersPublic(new ListUsersPublicRequest
    {
        Period = Period1.Daily,
        Order = Order2.LikesReceived,
    });
    // TODO: Handle 'response' of type DirectoryItemsJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListUsersPublicRequest](src/Discourse/Requests/Users/ListUsersPublicRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DirectoryItemsJsonResponse](src/Discourse/Models/DirectoryItemsJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersLogOutJsonResponse&gt; LogOutUser(LogOutUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.LogOutUser(new LogOutUserRequest { Id = 1 });
    // TODO: Handle 'response' of type AdminUsersLogOutJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[LogOutUserRequest](src/Discourse/Requests/Users/LogOutUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersLogOutJsonResponse](src/Discourse/Models/AdminUsersLogOutJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserAvatarRefreshGravatarJsonResponse&gt; RefreshGravatar(RefreshGravatarRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.RefreshGravatar(new RefreshGravatarRequest { Username = "some example string" });
    // TODO: Handle 'response' of type UserAvatarRefreshGravatarJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RefreshGravatarRequest](src/Discourse/Requests/Users/RefreshGravatarRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserAvatarRefreshGravatarJsonResponse](src/Discourse/Models/UserAvatarRefreshGravatarJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SessionForgotPasswordJsonResponse&gt; SendPasswordResetEmail(SendPasswordResetEmailRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.SendPasswordResetEmail(new SendPasswordResetEmailRequest());
    // TODO: Handle 'response' of type SessionForgotPasswordJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SendPasswordResetEmailRequest](src/Discourse/Requests/Users/SendPasswordResetEmailRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SessionForgotPasswordJsonResponse](src/Discourse/Models/SessionForgotPasswordJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersSilenceJsonResponse&gt; SilenceUser(SilenceUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.SilenceUser(new SilenceUserRequest { Id = 1 });
    // TODO: Handle 'response' of type AdminUsersSilenceJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SilenceUserRequest](src/Discourse/Requests/Users/SilenceUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersSilenceJsonResponse](src/Discourse/Models/AdminUsersSilenceJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersSuspendJsonResponse&gt; SuspendUser(SuspendUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.SuspendUser(new SuspendUserRequest { Id = 1 });
    // TODO: Handle 'response' of type AdminUsersSuspendJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SuspendUserRequest](src/Discourse/Requests/Users/SuspendUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersSuspendJsonResponse](src/Discourse/Models/AdminUsersSuspendJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UPreferencesAvatarPickJsonResponse&gt; UpdateAvatar(UpdateAvatarRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UpdateAvatar(new UpdateAvatarRequest { Username = "some example string" });
    // TODO: Handle 'response' of type UPreferencesAvatarPickJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateAvatarRequest](src/Discourse/Requests/Users/UpdateAvatarRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UPreferencesAvatarPickJsonResponse](src/Discourse/Models/UPreferencesAvatarPickJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task UpdateEmail(UpdateEmailRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Users.UpdateEmail(new UpdateEmailRequest { Username = "some example string" });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateEmailRequest](src/Discourse/Requests/Users/UpdateEmailRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UJsonResponse1&gt; UpdateUser(UpdateUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UpdateUser(new UpdateUserRequest
    {
        Username = "some example string",
        ApiKey = "some example string",
        ApiUsername = "some example string",
    });
    // TODO: Handle 'response' of type UJsonResponse1
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateUserRequest](src/Discourse/Requests/Users/UpdateUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UJsonResponse1](src/Discourse/Models/UJsonResponse1.cs)</code>

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task UpdateUsername(UpdateUsernameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Users.UpdateUsername(new UpdateUsernameRequest { Username = "some example string" });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateUsernameRequest](src/Discourse/Requests/Users/UpdateUsernameRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Discourse/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Discourse/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

