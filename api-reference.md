# Reference

> Source: [DiscourseApiDocumentationClient](DiscourseApiDocumentationClient.cs)

## Admin

> Source: [Admin](Api/Admin.cs)

<details>
<summary><code>Task&lt;AdminUsersActivateJsonResponse&gt; ActivateUser(int id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.ActivateUser(id);
    // TODO: Handle 'response' of type AdminUsersActivateJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersActivateJsonResponse](Models/AdminUsersActivateJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersJsonResponse&gt; AdminGetUser(int id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminGetUser(id);
    // TODO: Handle 'response' of type AdminUsersJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersJsonResponse](Models/AdminUsersJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;AdminUsersJsonResponse2&gt;&gt; AdminListUsers(Order3? order, Asc? asc, int? page, bool? showEmails, bool? stats, string? email, string? ip, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminListUsers(order, asc, page, showEmails, stats, email, ip);
    // TODO: Handle 'response' of type IReadOnlyList<AdminUsersJsonResponse2>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>order</code> | <code>[Order3?](Models/Enums/Order3.cs)</code> | - |
| <code>asc</code> | <code>[Asc?](Models/Enums/Asc.cs)</code> | - |
| <code>page</code> | <code>int?</code> | - |
| <code>showEmails</code> | <code>bool?</code> | Include user email addresses in response. These requests will<br>be logged in the staff action logs. |
| <code>stats</code> | <code>bool?</code> | Include user stats information |
| <code>email</code> | <code>string?</code> | Filter to the user with this email address |
| <code>ip</code> | <code>string?</code> | Filter to users with this IP address |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[AdminUsersJsonResponse2](Models/AdminUsersJsonResponse2.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;AdminUsersListJsonResponse&gt;&gt; AdminListUsersFlag(Flag flag, Order3? order, Asc? asc, int? page, bool? showEmails, bool? stats, string? email, string? ip, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AdminListUsersFlag(flag, order, asc, page, showEmails, stats, email, ip);
    // TODO: Handle 'response' of type IReadOnlyList<AdminUsersListJsonResponse>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>flag</code> | <code>[Flag](Models/Enums/Flag.cs)</code> | - |
| <code>order</code> | <code>[Order3?](Models/Enums/Order3.cs)</code> | - |
| <code>asc</code> | <code>[Asc?](Models/Enums/Asc.cs)</code> | - |
| <code>page</code> | <code>int?</code> | - |
| <code>showEmails</code> | <code>bool?</code> | Include user email addresses in response. These requests will<br>be logged in the staff action logs. |
| <code>stats</code> | <code>bool?</code> | Include user stats information |
| <code>email</code> | <code>string?</code> | Filter to the user with this email address |
| <code>ip</code> | <code>string?</code> | Filter to users with this IP address |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[AdminUsersListJsonResponse](Models/AdminUsersListJsonResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersAnonymizeJsonResponse&gt; AnonymizeUser(int id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.AnonymizeUser(id);
    // TODO: Handle 'response' of type AdminUsersAnonymizeJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersAnonymizeJsonResponse](Models/AdminUsersAnonymizeJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersDeactivateJsonResponse&gt; DeactivateUser(int id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.DeactivateUser(id);
    // TODO: Handle 'response' of type AdminUsersDeactivateJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersDeactivateJsonResponse](Models/AdminUsersDeactivateJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersJsonResponse1&gt; DeleteUser(int id, AdminUsersJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.DeleteUser(id, body);
    // TODO: Handle 'response' of type AdminUsersJsonResponse1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | - |
| <code>body</code> | <code>[AdminUsersJsonRequest?](Models/AdminUsersJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersJsonResponse1](Models/AdminUsersJsonResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersLogOutJsonResponse&gt; LogOutUser(int id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.LogOutUser(id);
    // TODO: Handle 'response' of type AdminUsersLogOutJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersLogOutJsonResponse](Models/AdminUsersLogOutJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserAvatarRefreshGravatarJsonResponse&gt; RefreshGravatar(string username, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.RefreshGravatar(username);
    // TODO: Handle 'response' of type UserAvatarRefreshGravatarJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>username</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserAvatarRefreshGravatarJsonResponse](Models/UserAvatarRefreshGravatarJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersSilenceJsonResponse&gt; SilenceUser(int id, AdminUsersSilenceJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.SilenceUser(id, body);
    // TODO: Handle 'response' of type AdminUsersSilenceJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | - |
| <code>body</code> | <code>[AdminUsersSilenceJsonRequest?](Models/AdminUsersSilenceJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersSilenceJsonResponse](Models/AdminUsersSilenceJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersSuspendJsonResponse&gt; SuspendUser(int id, AdminUsersSuspendJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Admin.SuspendUser(id, body);
    // TODO: Handle 'response' of type AdminUsersSuspendJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | - |
| <code>body</code> | <code>[AdminUsersSuspendJsonRequest?](Models/AdminUsersSuspendJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersSuspendJsonResponse](Models/AdminUsersSuspendJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Backups

> Source: [Backups](Api/Backups.cs)

<details>
<summary><code>Task&lt;AdminBackupsJsonResponse1&gt; CreateBackup(AdminBackupsJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Backups.CreateBackup(body);
    // TODO: Handle 'response' of type AdminBackupsJsonResponse1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[AdminBackupsJsonRequest?](Models/AdminBackupsJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminBackupsJsonResponse1](Models/AdminBackupsJsonResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DownloadBackup(string filename, string token, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Backups.DownloadBackup(filename, token);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>filename</code> | <code>string</code> | - |
| <code>token</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;AdminBackupsJsonResponse&gt;&gt; GetBackups(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[AdminBackupsJsonResponse](Models/AdminBackupsJsonResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task SendDownloadBackupEmail(string filename, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Backups.SendDownloadBackupEmail(filename);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>filename</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Badges

> Source: [Badges](Api/Badges.cs)

<details>
<summary><code>Task&lt;AdminBadgesJsonResponse&gt; AdminListBadges(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminBadgesJsonResponse](Models/AdminBadgesJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminBadgesJsonResponse1&gt; CreateBadge(AdminBadgesJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Badges.CreateBadge(body);
    // TODO: Handle 'response' of type AdminBadgesJsonResponse1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[AdminBadgesJsonRequest?](Models/AdminBadgesJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminBadgesJsonResponse1](Models/AdminBadgesJsonResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteBadge(int id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Badges.DeleteBadge(id);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserBadgesJsonResponse&gt; ListUserBadges(string username, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Badges.ListUserBadges(username);
    // TODO: Handle 'response' of type UserBadgesJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>username</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserBadgesJsonResponse](Models/UserBadgesJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminBadgesJsonResponse2&gt; UpdateBadge(int id, AdminBadgesJsonRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Badges.UpdateBadge(id, body);
    // TODO: Handle 'response' of type AdminBadgesJsonResponse2
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | - |
| <code>body</code> | <code>[AdminBadgesJsonRequest1?](Models/AdminBadgesJsonRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminBadgesJsonResponse2](Models/AdminBadgesJsonResponse2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Categories

> Source: [Categories](Api/Categories.cs)

<details>
<summary><code>Task&lt;CategoriesJsonResponse&gt; CreateCategory(CategoriesJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Categories.CreateCategory(body);
    // TODO: Handle 'response' of type CategoriesJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CategoriesJsonRequest?](Models/CategoriesJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CategoriesJsonResponse](Models/CategoriesJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CShowJsonResponse&gt; GetCategory(int id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Categories.GetCategory(id);
    // TODO: Handle 'response' of type CShowJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CShowJsonResponse](Models/CShowJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SiteJsonResponse&gt; GetSite(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SiteJsonResponse](Models/SiteJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CategoriesJsonResponse1&gt; ListCategories(bool? includeSubcategories, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Categories.ListCategories(includeSubcategories);
    // TODO: Handle 'response' of type CategoriesJsonResponse1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>includeSubcategories</code> | <code>bool?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CategoriesJsonResponse1](Models/CategoriesJsonResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CJsonResponse&gt; ListCategoryTopics(string slug, int id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Categories.ListCategoryTopics(slug, id);
    // TODO: Handle 'response' of type CJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>slug</code> | <code>string</code> | - |
| <code>id</code> | <code>int</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CJsonResponse](Models/CJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CategoriesJsonResponse2&gt; UpdateCategory(int id, CategoriesJsonRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Categories.UpdateCategory(id, body);
    // TODO: Handle 'response' of type CategoriesJsonResponse2
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | - |
| <code>body</code> | <code>[CategoriesJsonRequest1?](Models/CategoriesJsonRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CategoriesJsonResponse2](Models/CategoriesJsonResponse2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DiscourseCalendarEvents

> Source: [DiscourseCalendarEvents](Api/DiscourseCalendarEvents.cs)

<details>
<summary><code>Task ExportEventsIcs(int? categoryId, IncludeSubcategories? includeSubcategories, string? attendingUser, DateTimeOffset? before, DateTimeOffset? after, Order? order, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.DiscourseCalendarEvents.ExportEventsIcs(categoryId,
        includeSubcategories,
        attendingUser,
        before,
        after,
        order,
        limit);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>categoryId</code> | <code>int?</code> | Filter events by category ID |
| <code>includeSubcategories</code> | <code>[IncludeSubcategories?](Models/Enums/IncludeSubcategories.cs)</code> | Include events from subcategories when filtering by category |
| <code>attendingUser</code> | <code>string?</code> | Filter to events where the specified user (username) has RSVP'd<br>as going |
| <code>before</code> | <code>DateTimeOffset?</code> | Return events starting before this date/time (ISO 8601 format) |
| <code>after</code> | <code>DateTimeOffset?</code> | Return events starting after this date/time (ISO 8601 format) |
| <code>order</code> | <code>[Order?](Models/Enums/Order.cs)</code> | Sort order for events by start date (default: asc) |
| <code>limit</code> | <code>int?</code> | Maximum number of events to return (default: 200) |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DiscoursePostEventEventsJsonResponse&gt; ListEvents(IncludeDetails? includeDetails, int? categoryId, IncludeSubcategories? includeSubcategories, int? postId, string? attendingUser, DateTimeOffset? before, DateTimeOffset? after, Order? order, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DiscourseCalendarEvents.ListEvents(includeDetails,
        categoryId,
        includeSubcategories,
        postId,
        attendingUser,
        before,
        after,
        order,
        limit);
    // TODO: Handle 'response' of type DiscoursePostEventEventsJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>includeDetails</code> | <code>[IncludeDetails?](Models/Enums/IncludeDetails.cs)</code> | Include detailed event information (creator, invitees, stats,<br>etc.) |
| <code>categoryId</code> | <code>int?</code> | Filter events by category ID |
| <code>includeSubcategories</code> | <code>[IncludeSubcategories?](Models/Enums/IncludeSubcategories.cs)</code> | Include events from subcategories when filtering by category |
| <code>postId</code> | <code>int?</code> | Filter to events associated with a specific post ID |
| <code>attendingUser</code> | <code>string?</code> | Filter to events where the specified user (username) has RSVP'd<br>as going |
| <code>before</code> | <code>DateTimeOffset?</code> | Return events starting before this date/time (ISO 8601 format) |
| <code>after</code> | <code>DateTimeOffset?</code> | Return events starting after this date/time (ISO 8601 format) |
| <code>order</code> | <code>[Order?](Models/Enums/Order.cs)</code> | Sort order for events by start date (default: asc) |
| <code>limit</code> | <code>int?</code> | Maximum number of events to return (default: 200) |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DiscoursePostEventEventsJsonResponse](Models/DiscoursePostEventEventsJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Groups

> Source: [Groups](Api/Groups.cs)

<details>
<summary><code>Task&lt;GroupsMembersJsonResponse1&gt; AddGroupMembers(int id, GroupsMembersJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Groups.AddGroupMembers(id, body);
    // TODO: Handle 'response' of type GroupsMembersJsonResponse1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | - |
| <code>body</code> | <code>[GroupsMembersJsonRequest?](Models/GroupsMembersJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GroupsMembersJsonResponse1](Models/GroupsMembersJsonResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminGroupsJsonResponse&gt; CreateGroup(AdminGroupsJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Groups.CreateGroup(body);
    // TODO: Handle 'response' of type AdminGroupsJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[AdminGroupsJsonRequest?](Models/AdminGroupsJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminGroupsJsonResponse](Models/AdminGroupsJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminGroupsJsonResponse1&gt; DeleteGroup(int id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Groups.DeleteGroup(id);
    // TODO: Handle 'response' of type AdminGroupsJsonResponse1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminGroupsJsonResponse1](Models/AdminGroupsJsonResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GroupsJsonResponse&gt; GetGroup(string name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Groups.GetGroup(name);
    // TODO: Handle 'response' of type GroupsJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>name</code> | <code>string</code> | Use group name instead of id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GroupsJsonResponse](Models/GroupsJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GroupsByIdJsonResponse&gt; GetGroupById(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Groups.GetGroupById(id);
    // TODO: Handle 'response' of type GroupsByIdJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | Use group name instead of id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GroupsByIdJsonResponse](Models/GroupsByIdJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GroupsMembersJsonResponse&gt; ListGroupMembers(string name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Groups.ListGroupMembers(name);
    // TODO: Handle 'response' of type GroupsMembersJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>name</code> | <code>string</code> | Use group name instead of id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GroupsMembersJsonResponse](Models/GroupsMembersJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GroupsJsonResponse2&gt; ListGroups(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GroupsJsonResponse2](Models/GroupsJsonResponse2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GroupsMembersJsonResponse2&gt; RemoveGroupMembers(int id, GroupsMembersJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Groups.RemoveGroupMembers(id, body);
    // TODO: Handle 'response' of type GroupsMembersJsonResponse2
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | - |
| <code>body</code> | <code>[GroupsMembersJsonRequest?](Models/GroupsMembersJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GroupsMembersJsonResponse2](Models/GroupsMembersJsonResponse2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GroupsJsonResponse1&gt; UpdateGroup(int id, GroupsJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Groups.UpdateGroup(id, body);
    // TODO: Handle 'response' of type GroupsJsonResponse1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | - |
| <code>body</code> | <code>[GroupsJsonRequest?](Models/GroupsJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GroupsJsonResponse1](Models/GroupsJsonResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Invites

> Source: [Invites](Api/Invites.cs)

<details>
<summary><code>Task&lt;InvitesJsonResponse&gt; CreateInvite(string apiKey, string apiUsername, InvitesJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invites.CreateInvite(apiKey, apiUsername, body);
    // TODO: Handle 'response' of type InvitesJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |
| <code>body</code> | <code>[InvitesJsonRequest?](Models/InvitesJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvitesJsonResponse](Models/InvitesJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvitesCreateMultipleJsonResponse&gt; CreateMultipleInvites(string apiKey, string apiUsername, InvitesCreateMultipleJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invites.CreateMultipleInvites(apiKey, apiUsername, body);
    // TODO: Handle 'response' of type InvitesCreateMultipleJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |
| <code>body</code> | <code>[InvitesCreateMultipleJsonRequest?](Models/InvitesCreateMultipleJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvitesCreateMultipleJsonResponse](Models/InvitesCreateMultipleJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TInviteGroupJsonResponse&gt; InviteGroupToTopic(string id, string apiKey, string apiUsername, TInviteGroupJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invites.InviteGroupToTopic(id, apiKey, apiUsername, body);
    // TODO: Handle 'response' of type TInviteGroupJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | - |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |
| <code>body</code> | <code>[TInviteGroupJsonRequest?](Models/TInviteGroupJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TInviteGroupJsonResponse](Models/TInviteGroupJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TInviteJsonResponse&gt; InviteToTopic(string id, string apiKey, string apiUsername, TInviteJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invites.InviteToTopic(id, apiKey, apiUsername, body);
    // TODO: Handle 'response' of type TInviteJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | - |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |
| <code>body</code> | <code>[TInviteJsonRequest?](Models/TInviteJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TInviteJsonResponse](Models/TInviteJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Notifications

> Source: [Notifications](Api/Notifications.cs)

<details>
<summary><code>Task&lt;NotificationsJsonResponse&gt; GetNotifications(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NotificationsJsonResponse](Models/NotificationsJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;NotificationsMarkReadJsonResponse&gt; MarkNotificationsAsRead(NotificationsMarkReadJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Notifications.MarkNotificationsAsRead(body);
    // TODO: Handle 'response' of type NotificationsMarkReadJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[NotificationsMarkReadJsonRequest?](Models/NotificationsMarkReadJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NotificationsMarkReadJsonResponse](Models/NotificationsMarkReadJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Posts

> Source: [Posts](Api/Posts.cs)

<details>
<summary><code>Task&lt;PostsJsonResponse1&gt; CreateTopicPostPm(string apiKey, string apiUsername, PostsJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Posts.CreateTopicPostPm(apiKey, apiUsername, body);
    // TODO: Handle 'response' of type PostsJsonResponse1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |
| <code>body</code> | <code>[PostsJsonRequest?](Models/PostsJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PostsJsonResponse1](Models/PostsJsonResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeletePost(int id, string apiKey, string apiUsername, PostsJsonRequest2? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Posts.DeletePost(id, apiKey, apiUsername, body);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | - |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |
| <code>body</code> | <code>[PostsJsonRequest2?](Models/PostsJsonRequest2.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PostsJsonResponse2&gt; GetPost(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.Posts.GetPost(id);
    // TODO: Handle 'response' of type PostsJsonResponse2
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PostsJsonResponse2](Models/PostsJsonResponse2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PostsJsonResponse&gt; ListPosts(int? before, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Posts.ListPosts(before);
    // TODO: Handle 'response' of type PostsJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>before</code> | <code>int?</code> | Load posts with an id lower than this value. Useful for pagination. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PostsJsonResponse](Models/PostsJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PostsLockedJsonResponse&gt; LockPost(string id, string apiKey, string apiUsername, PostsLockedJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Posts.LockPost(id, apiKey, apiUsername, body);
    // TODO: Handle 'response' of type PostsLockedJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | - |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |
| <code>body</code> | <code>[PostsLockedJsonRequest?](Models/PostsLockedJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PostsLockedJsonResponse](Models/PostsLockedJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PostActionsJsonResponse&gt; PerformPostAction(string apiKey, string apiUsername, PostActionsJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Posts.PerformPostAction(apiKey, apiUsername, body);
    // TODO: Handle 'response' of type PostActionsJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |
| <code>body</code> | <code>[PostActionsJsonRequest?](Models/PostActionsJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PostActionsJsonResponse](Models/PostActionsJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;PostsRepliesJsonResponse&gt;&gt; PostReplies(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Posts.PostReplies(id);
    // TODO: Handle 'response' of type IReadOnlyList<PostsRepliesJsonResponse>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[PostsRepliesJsonResponse](Models/PostsRepliesJsonResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PostsJsonResponse3&gt; UpdatePost(string id, string apiKey, string apiUsername, PostsJsonRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Posts.UpdatePost(id, apiKey, apiUsername, body);
    // TODO: Handle 'response' of type PostsJsonResponse3
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | - |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |
| <code>body</code> | <code>[PostsJsonRequest1?](Models/PostsJsonRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PostsJsonResponse3](Models/PostsJsonResponse3.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PrivateMessages

> Source: [PrivateMessages](Api/PrivateMessages.cs)

<details>
<summary><code>Task&lt;PostsJsonResponse1&gt; CreateTopicPostPm(string apiKey, string apiUsername, PostsJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PrivateMessages.CreateTopicPostPm(apiKey, apiUsername, body);
    // TODO: Handle 'response' of type PostsJsonResponse1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |
| <code>body</code> | <code>[PostsJsonRequest?](Models/PostsJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PostsJsonResponse1](Models/PostsJsonResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TopicsPrivateMessagesSentJsonResponse&gt; GetUserSentPrivateMessages(string username, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PrivateMessages.GetUserSentPrivateMessages(username);
    // TODO: Handle 'response' of type TopicsPrivateMessagesSentJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>username</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TopicsPrivateMessagesSentJsonResponse](Models/TopicsPrivateMessagesSentJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TopicsPrivateMessagesJsonResponse&gt; ListUserPrivateMessages(string username, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PrivateMessages.ListUserPrivateMessages(username);
    // TODO: Handle 'response' of type TopicsPrivateMessagesJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>username</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TopicsPrivateMessagesJsonResponse](Models/TopicsPrivateMessagesJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Search

> Source: [Search](Api/Search.cs)

<details>
<summary><code>Task&lt;SearchJsonResponse&gt; SearchInvoke(string? q, int? page, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Search.SearchInvoke(q, page);
    // TODO: Handle 'response' of type SearchJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>q</code> | <code>string?</code> | The query string needs to be url encoded and is made up of the following options:<br>- Search term. This is just a string. Usually it would be the first item in the query.<br>- `@<username>`: Use the `@` followed by the username to specify posts by this user.<br>- `#<category>`: Use the `#` followed by the category slug to search within this category.<br>- `tags:`: `api,solved` or for posts that have all the specified tags `api+solved`.<br>- `before:`: `yyyy-mm-dd`<br>- `after:`: `yyyy-mm-dd`<br>- `order:`: `latest`, `likes`, `views`, `latest_topic`<br>- `assigned:`: username (without `@`)<br>- `in:`: `title`, `likes`, `personal`, `messages`, `seen`, `unseen`, `posted`, `created`, `watching`, `tracking`, `bookmarks`, `assigned`, `unassigned`, `first`, `pinned`, `wiki`<br>- `with:`: `images`<br>- `status:`: `open`, `closed`, `public`, `archived`, `noreplies`, `single_user`, `solved`, `unsolved`<br>- `group:`: group_name or group_id<br>- `group_messages:`: group_name or group_id<br>- `min_posts:`: 1<br>- `max_posts:`: 10<br>- `min_views:`: 1<br>- `max_views:`: 10<br><br>If you are using cURL you can use the `-G` and the `--data-urlencode` flags to encode the query:<br><br>```<br>curl -i -sS -X GET -G "http://localhost:3000/search.json" \<br>--data-urlencode 'q=wordpress @scossar #fun after:2020-01-01'<br>``` |
| <code>page</code> | <code>int?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchJsonResponse](Models/SearchJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Site

> Source: [Site](Api/Site.cs)

<details>
<summary><code>Task&lt;SiteJsonResponse&gt; GetSite(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SiteJsonResponse](Models/SiteJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SiteBasicInfoJsonResponse&gt; GetSiteBasicInfo(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SiteBasicInfoJsonResponse](Models/SiteBasicInfoJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Tags

> Source: [Tags](Api/Tags.cs)

<details>
<summary><code>Task&lt;TagGroupsJsonResponse1&gt; CreateTagGroup(TagGroupsJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Tags.CreateTagGroup(body);
    // TODO: Handle 'response' of type TagGroupsJsonResponse1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[TagGroupsJsonRequest?](Models/TagGroupsJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TagGroupsJsonResponse1](Models/TagGroupsJsonResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TagJsonResponse&gt; GetTag(string name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Tags.GetTag(name);
    // TODO: Handle 'response' of type TagJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>name</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TagJsonResponse](Models/TagJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TagGroupsJsonResponse2&gt; GetTagGroup(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Tags.GetTagGroup(id);
    // TODO: Handle 'response' of type TagGroupsJsonResponse2
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TagGroupsJsonResponse2](Models/TagGroupsJsonResponse2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TagGroupsJsonResponse&gt; ListTagGroups(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TagGroupsJsonResponse](Models/TagGroupsJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TagsJsonResponse&gt; ListTags(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TagsJsonResponse](Models/TagsJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TagGroupsJsonResponse3&gt; UpdateTagGroup(string id, TagGroupsJsonRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Tags.UpdateTagGroup(id, body);
    // TODO: Handle 'response' of type TagGroupsJsonResponse3
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | - |
| <code>body</code> | <code>[TagGroupsJsonRequest1?](Models/TagGroupsJsonRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TagGroupsJsonResponse3](Models/TagGroupsJsonResponse3.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Topics

> Source: [Topics](Api/Topics.cs)

<details>
<summary><code>Task BookmarkTopic(string id, string apiKey, string apiUsername, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Topics.BookmarkTopic(id, apiKey, apiUsername);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | - |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PostsJsonResponse1&gt; CreateTopicPostPm(string apiKey, string apiUsername, PostsJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Topics.CreateTopicPostPm(apiKey, apiUsername, body);
    // TODO: Handle 'response' of type PostsJsonResponse1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |
| <code>body</code> | <code>[PostsJsonRequest?](Models/PostsJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PostsJsonResponse1](Models/PostsJsonResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TTimerJsonResponse&gt; CreateTopicTimer(string id, string apiKey, string apiUsername, TTimerJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Topics.CreateTopicTimer(id, apiKey, apiUsername, body);
    // TODO: Handle 'response' of type TTimerJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | - |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |
| <code>body</code> | <code>[TTimerJsonRequest?](Models/TTimerJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TTimerJsonResponse](Models/TTimerJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TPostsJsonResponse&gt; GetSpecificPostsFromTopic(string id, string apiKey, string apiUsername, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Topics.GetSpecificPostsFromTopic(id, apiKey, apiUsername);
    // TODO: Handle 'response' of type TPostsJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | - |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TPostsJsonResponse](Models/TPostsJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TJsonResponse&gt; GetTopic(string id, string apiKey, string apiUsername, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Topics.GetTopic(id, apiKey, apiUsername);
    // TODO: Handle 'response' of type TJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | - |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TJsonResponse](Models/TJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetTopicByExternalId(string externalId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Topics.GetTopicByExternalId(externalId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>externalId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TInviteGroupJsonResponse&gt; InviteGroupToTopic(string id, string apiKey, string apiUsername, TInviteGroupJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Topics.InviteGroupToTopic(id, apiKey, apiUsername, body);
    // TODO: Handle 'response' of type TInviteGroupJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | - |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |
| <code>body</code> | <code>[TInviteGroupJsonRequest?](Models/TInviteGroupJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TInviteGroupJsonResponse](Models/TInviteGroupJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TInviteJsonResponse&gt; InviteToTopic(string id, string apiKey, string apiUsername, TInviteJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Topics.InviteToTopic(id, apiKey, apiUsername, body);
    // TODO: Handle 'response' of type TInviteJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | - |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |
| <code>body</code> | <code>[TInviteJsonRequest?](Models/TInviteJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TInviteJsonResponse](Models/TInviteJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LatestJsonResponse&gt; ListLatestTopics(string? order, string? ascending, int? perPage, string apiKey, string apiUsername, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Topics.ListLatestTopics(order, ascending, perPage, apiKey, apiUsername);
    // TODO: Handle 'response' of type LatestJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>order</code> | <code>string?</code> | Enum: `default`, `created`, `activity`, `views`, `posts`, `category`,<br>`likes`, `op_likes`, `posters` |
| <code>ascending</code> | <code>string?</code> | Defaults to `desc`, add `ascending=true` to sort asc |
| <code>perPage</code> | <code>int?</code> | Maximum number of topics returned, between 1-100 |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LatestJsonResponse](Models/LatestJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TopJsonResponse&gt; ListTopTopics(string? period, int? perPage, string apiKey, string apiUsername, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Topics.ListTopTopics(period, perPage, apiKey, apiUsername);
    // TODO: Handle 'response' of type TopJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>period</code> | <code>string?</code> | Enum: `all`, `yearly`, `quarterly`, `monthly`, `weekly`, `daily` |
| <code>perPage</code> | <code>int?</code> | Maximum number of topics returned, between 1-100 |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TopJsonResponse](Models/TopJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task RemoveTopic(string id, string apiKey, string apiUsername, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Topics.RemoveTopic(id, apiKey, apiUsername);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | - |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TNotificationsJsonResponse&gt; SetNotificationLevel(string id, string apiKey, string apiUsername, TNotificationsJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Topics.SetNotificationLevel(id, apiKey, apiUsername, body);
    // TODO: Handle 'response' of type TNotificationsJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | - |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |
| <code>body</code> | <code>[TNotificationsJsonRequest?](Models/TNotificationsJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TNotificationsJsonResponse](Models/TNotificationsJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TJsonResponse1&gt; UpdateTopic(string id, string apiKey, string apiUsername, TJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Topics.UpdateTopic(id, apiKey, apiUsername, body);
    // TODO: Handle 'response' of type TJsonResponse1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | - |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |
| <code>body</code> | <code>[TJsonRequest?](Models/TJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TJsonResponse1](Models/TJsonResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TStatusJsonResponse&gt; UpdateTopicStatus(string id, string apiKey, string apiUsername, TStatusJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Topics.UpdateTopicStatus(id, apiKey, apiUsername, body);
    // TODO: Handle 'response' of type TStatusJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | - |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |
| <code>body</code> | <code>[TStatusJsonRequest?](Models/TStatusJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TStatusJsonResponse](Models/TStatusJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TChangeTimestampJsonResponse&gt; UpdateTopicTimestamp(string id, string apiKey, string apiUsername, TChangeTimestampJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Topics.UpdateTopicTimestamp(id, apiKey, apiUsername, body);
    // TODO: Handle 'response' of type TChangeTimestampJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | - |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |
| <code>body</code> | <code>[TChangeTimestampJsonRequest?](Models/TChangeTimestampJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TChangeTimestampJsonResponse](Models/TChangeTimestampJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Uploads

> Source: [Uploads](Api/Uploads.cs)

<details>
<summary><code>Task&lt;UploadsAbortMultipartJsonResponse&gt; AbortMultipart(UploadsAbortMultipartJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.Uploads.AbortMultipart(body);
    // TODO: Handle 'response' of type UploadsAbortMultipartJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[UploadsAbortMultipartJsonRequest?](Models/UploadsAbortMultipartJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadsAbortMultipartJsonResponse](Models/UploadsAbortMultipartJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UploadsBatchPresignMultipartPartsJsonResponse&gt; BatchPresignMultipartParts(UploadsBatchPresignMultipartPartsJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.Uploads.BatchPresignMultipartParts(body);
    // TODO: Handle 'response' of type UploadsBatchPresignMultipartPartsJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[UploadsBatchPresignMultipartPartsJsonRequest?](Models/UploadsBatchPresignMultipartPartsJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadsBatchPresignMultipartPartsJsonResponse](Models/UploadsBatchPresignMultipartPartsJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UploadsCompleteExternalUploadJsonResponse&gt; CompleteExternalUpload(UploadsCompleteExternalUploadJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.Uploads.CompleteExternalUpload(body);
    // TODO: Handle 'response' of type UploadsCompleteExternalUploadJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[UploadsCompleteExternalUploadJsonRequest?](Models/UploadsCompleteExternalUploadJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadsCompleteExternalUploadJsonResponse](Models/UploadsCompleteExternalUploadJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UploadsCompleteMultipartJsonResponse&gt; CompleteMultipart(UploadsCompleteMultipartJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.Uploads.CompleteMultipart(body);
    // TODO: Handle 'response' of type UploadsCompleteMultipartJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[UploadsCompleteMultipartJsonRequest?](Models/UploadsCompleteMultipartJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadsCompleteMultipartJsonResponse](Models/UploadsCompleteMultipartJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UploadsCreateMultipartJsonResponse&gt; CreateMultipartUpload(UploadsCreateMultipartJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.Uploads.CreateMultipartUpload(body);
    // TODO: Handle 'response' of type UploadsCreateMultipartJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[UploadsCreateMultipartJsonRequest?](Models/UploadsCreateMultipartJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadsCreateMultipartJsonResponse](Models/UploadsCreateMultipartJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UploadsJsonResponse&gt; CreateUpload(UploadType uploadType, int? userId, bool? synchronous, BinaryContent? file, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Uploads.CreateUpload(uploadType, userId, synchronous, file);
    // TODO: Handle 'response' of type UploadsJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>uploadType</code> | <code>[UploadType](Models/Enums/UploadType.cs)</code> | - |
| <code>userId</code> | <code>int?</code> | - |
| <code>synchronous</code> | <code>bool?</code> | - |
| <code>file</code> | <code>BinaryContent?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadsJsonResponse](Models/UploadsJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UploadsGeneratePresignedPutJsonResponse&gt; GeneratePresignedPut(UploadsGeneratePresignedPutJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.Uploads.GeneratePresignedPut(body);
    // TODO: Handle 'response' of type UploadsGeneratePresignedPutJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[UploadsGeneratePresignedPutJsonRequest?](Models/UploadsGeneratePresignedPutJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadsGeneratePresignedPutJsonResponse](Models/UploadsGeneratePresignedPutJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Users

> Source: [Users](Api/Users.cs)

<details>
<summary><code>Task&lt;AdminUsersActivateJsonResponse&gt; ActivateUser(int id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.ActivateUser(id);
    // TODO: Handle 'response' of type AdminUsersActivateJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersActivateJsonResponse](Models/AdminUsersActivateJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersJsonResponse&gt; AdminGetUser(int id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.AdminGetUser(id);
    // TODO: Handle 'response' of type AdminUsersJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersJsonResponse](Models/AdminUsersJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;AdminUsersJsonResponse2&gt;&gt; AdminListUsers(Order3? order, Asc? asc, int? page, bool? showEmails, bool? stats, string? email, string? ip, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.AdminListUsers(order, asc, page, showEmails, stats, email, ip);
    // TODO: Handle 'response' of type IReadOnlyList<AdminUsersJsonResponse2>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>order</code> | <code>[Order3?](Models/Enums/Order3.cs)</code> | - |
| <code>asc</code> | <code>[Asc?](Models/Enums/Asc.cs)</code> | - |
| <code>page</code> | <code>int?</code> | - |
| <code>showEmails</code> | <code>bool?</code> | Include user email addresses in response. These requests will<br>be logged in the staff action logs. |
| <code>stats</code> | <code>bool?</code> | Include user stats information |
| <code>email</code> | <code>string?</code> | Filter to the user with this email address |
| <code>ip</code> | <code>string?</code> | Filter to users with this IP address |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[AdminUsersJsonResponse2](Models/AdminUsersJsonResponse2.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;AdminUsersListJsonResponse&gt;&gt; AdminListUsersFlag(Flag flag, Order3? order, Asc? asc, int? page, bool? showEmails, bool? stats, string? email, string? ip, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.AdminListUsersFlag(flag, order, asc, page, showEmails, stats, email, ip);
    // TODO: Handle 'response' of type IReadOnlyList<AdminUsersListJsonResponse>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>flag</code> | <code>[Flag](Models/Enums/Flag.cs)</code> | - |
| <code>order</code> | <code>[Order3?](Models/Enums/Order3.cs)</code> | - |
| <code>asc</code> | <code>[Asc?](Models/Enums/Asc.cs)</code> | - |
| <code>page</code> | <code>int?</code> | - |
| <code>showEmails</code> | <code>bool?</code> | Include user email addresses in response. These requests will<br>be logged in the staff action logs. |
| <code>stats</code> | <code>bool?</code> | Include user stats information |
| <code>email</code> | <code>string?</code> | Filter to the user with this email address |
| <code>ip</code> | <code>string?</code> | Filter to users with this IP address |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[AdminUsersListJsonResponse](Models/AdminUsersListJsonResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersAnonymizeJsonResponse&gt; AnonymizeUser(int id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.AnonymizeUser(id);
    // TODO: Handle 'response' of type AdminUsersAnonymizeJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersAnonymizeJsonResponse](Models/AdminUsersAnonymizeJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task ChangePassword(string token, UsersPasswordResetJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Users.ChangePassword(token, body);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>token</code> | <code>string</code> | - |
| <code>body</code> | <code>[UsersPasswordResetJsonRequest?](Models/UsersPasswordResetJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsersJsonResponse&gt; CreateUser(string apiKey, string apiUsername, UsersJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.CreateUser(apiKey, apiUsername, body);
    // TODO: Handle 'response' of type UsersJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |
| <code>body</code> | <code>[UsersJsonRequest?](Models/UsersJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsersJsonResponse](Models/UsersJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersDeactivateJsonResponse&gt; DeactivateUser(int id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.DeactivateUser(id);
    // TODO: Handle 'response' of type AdminUsersDeactivateJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersDeactivateJsonResponse](Models/AdminUsersDeactivateJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersJsonResponse1&gt; DeleteUser(int id, AdminUsersJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.DeleteUser(id, body);
    // TODO: Handle 'response' of type AdminUsersJsonResponse1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | - |
| <code>body</code> | <code>[AdminUsersJsonRequest?](Models/AdminUsersJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersJsonResponse1](Models/AdminUsersJsonResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UJsonResponse&gt; GetUser(string username, string apiKey, string apiUsername, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.GetUser(username, apiKey, apiUsername);
    // TODO: Handle 'response' of type UJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>username</code> | <code>string</code> | - |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UJsonResponse](Models/UJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UEmailsJsonResponse&gt; GetUserEmails(string username, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.GetUserEmails(username);
    // TODO: Handle 'response' of type UEmailsJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>username</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UEmailsJsonResponse](Models/UEmailsJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UByExternalJsonResponse&gt; GetUserExternalId(string externalId, string apiKey, string apiUsername, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.GetUserExternalId(externalId, apiKey, apiUsername);
    // TODO: Handle 'response' of type UByExternalJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>externalId</code> | <code>string</code> | - |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UByExternalJsonResponse](Models/UByExternalJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UByExternalJsonResponse&gt; GetUserIdentiyProviderExternalId(string provider, string externalId, string apiKey, string apiUsername, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.GetUserIdentiyProviderExternalId(provider, externalId, apiKey, apiUsername);
    // TODO: Handle 'response' of type UByExternalJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>provider</code> | <code>string</code> | Authentication provider name. Can be found in the provider callback<br>URL: `/auth/{provider}/callback` |
| <code>externalId</code> | <code>string</code> | - |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UByExternalJsonResponse](Models/UByExternalJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserActionsJsonResponse&gt; ListUserActions(int offset, string username, string filter, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.ListUserActions(offset, username, filter);
    // TODO: Handle 'response' of type UserActionsJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>offset</code> | <code>int</code> | - |
| <code>username</code> | <code>string</code> | - |
| <code>filter</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserActionsJsonResponse](Models/UserActionsJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserBadgesJsonResponse&gt; ListUserBadges(string username, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.ListUserBadges(username);
    // TODO: Handle 'response' of type UserBadgesJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>username</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserBadgesJsonResponse](Models/UserBadgesJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DirectoryItemsJsonResponse&gt; ListUsersPublic(Period1 period, Order2 order, Asc? asc, int? page, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.ListUsersPublic(period, order, asc, page);
    // TODO: Handle 'response' of type DirectoryItemsJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>period</code> | <code>[Period1](Models/Enums/Period1.cs)</code> | - |
| <code>order</code> | <code>[Order2](Models/Enums/Order2.cs)</code> | - |
| <code>asc</code> | <code>[Asc?](Models/Enums/Asc.cs)</code> | - |
| <code>page</code> | <code>int?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DirectoryItemsJsonResponse](Models/DirectoryItemsJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersLogOutJsonResponse&gt; LogOutUser(int id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.LogOutUser(id);
    // TODO: Handle 'response' of type AdminUsersLogOutJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersLogOutJsonResponse](Models/AdminUsersLogOutJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserAvatarRefreshGravatarJsonResponse&gt; RefreshGravatar(string username, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.RefreshGravatar(username);
    // TODO: Handle 'response' of type UserAvatarRefreshGravatarJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>username</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserAvatarRefreshGravatarJsonResponse](Models/UserAvatarRefreshGravatarJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SessionForgotPasswordJsonResponse&gt; SendPasswordResetEmail(SessionForgotPasswordJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.SendPasswordResetEmail(body);
    // TODO: Handle 'response' of type SessionForgotPasswordJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SessionForgotPasswordJsonRequest?](Models/SessionForgotPasswordJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SessionForgotPasswordJsonResponse](Models/SessionForgotPasswordJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersSilenceJsonResponse&gt; SilenceUser(int id, AdminUsersSilenceJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.SilenceUser(id, body);
    // TODO: Handle 'response' of type AdminUsersSilenceJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | - |
| <code>body</code> | <code>[AdminUsersSilenceJsonRequest?](Models/AdminUsersSilenceJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersSilenceJsonResponse](Models/AdminUsersSilenceJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminUsersSuspendJsonResponse&gt; SuspendUser(int id, AdminUsersSuspendJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.SuspendUser(id, body);
    // TODO: Handle 'response' of type AdminUsersSuspendJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>int</code> | - |
| <code>body</code> | <code>[AdminUsersSuspendJsonRequest?](Models/AdminUsersSuspendJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminUsersSuspendJsonResponse](Models/AdminUsersSuspendJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UPreferencesAvatarPickJsonResponse&gt; UpdateAvatar(string username, UPreferencesAvatarPickJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UpdateAvatar(username, body);
    // TODO: Handle 'response' of type UPreferencesAvatarPickJsonResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>username</code> | <code>string</code> | - |
| <code>body</code> | <code>[UPreferencesAvatarPickJsonRequest?](Models/UPreferencesAvatarPickJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UPreferencesAvatarPickJsonResponse](Models/UPreferencesAvatarPickJsonResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task UpdateEmail(string username, UPreferencesEmailJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Users.UpdateEmail(username, body);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>username</code> | <code>string</code> | - |
| <code>body</code> | <code>[UPreferencesEmailJsonRequest?](Models/UPreferencesEmailJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UJsonResponse1&gt; UpdateUser(string username, string apiKey, string apiUsername, UJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Users.UpdateUser(username, apiKey, apiUsername, body);
    // TODO: Handle 'response' of type UJsonResponse1
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>username</code> | <code>string</code> | - |
| <code>apiKey</code> | <code>string</code> | - |
| <code>apiUsername</code> | <code>string</code> | - |
| <code>body</code> | <code>[UJsonRequest?](Models/UJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UJsonResponse1](Models/UJsonResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task UpdateUsername(string username, UPreferencesUsernameJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Users.UpdateUsername(username, body);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>username</code> | <code>string</code> | - |
| <code>body</code> | <code>[UPreferencesUsernameJsonRequest?](Models/UPreferencesUsernameJsonRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

