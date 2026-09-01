using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Discourse.Core;
using Discourse.Core.ErrorResponse;
using Discourse.Core.Exceptions;
using Discourse.Core.Models;
using Discourse.Core.Request;
using Discourse.Core.Response;
using Discourse.Models;

namespace Discourse.Api;

public sealed class Topics
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal Topics(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Bookmark topic
    /// </summary>
    /// <param name="id"></param>
    /// <param name="apiKey"></param>
    /// <param name="apiUsername"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task BookmarkTopic(string id,
        string apiKey,
        string apiUsername,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/t/{id}/bookmark.json"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Api-Key", apiKey),
                new HeaderParam("Api-Username", apiUsername),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Creates a new topic, a new post, or a private message
    /// </summary>
    /// <param name="apiKey"></param>
    /// <param name="apiUsername"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PostsJsonResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<PostsJsonResponse1> CreateTopicPostPm(string apiKey,
        string apiUsername,
        PostsJsonRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/posts.json"),
            [],
            [],
            [new HeaderParam("Api-Key", apiKey),
                new HeaderParam("Api-Username", apiUsername),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PostsJsonResponse1>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Create topic timer
    /// </summary>
    /// <param name="id"></param>
    /// <param name="apiKey"></param>
    /// <param name="apiUsername"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TTimerJsonResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<TTimerJsonResponse> CreateTopicTimer(string id,
        string apiKey,
        string apiUsername,
        TTimerJsonRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/t/{id}/timer.json"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Api-Key", apiKey),
                new HeaderParam("Api-Username", apiUsername),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TTimerJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get specific posts from a topic
    /// </summary>
    /// <param name="id"></param>
    /// <param name="apiKey"></param>
    /// <param name="apiUsername"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TPostsJsonResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<TPostsJsonResponse> GetSpecificPostsFromTopic(string id,
        string apiKey,
        string apiUsername,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/t/{id}/posts.json"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Api-Key", apiKey), new HeaderParam("Api-Username", apiUsername)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TPostsJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get a single topic
    /// </summary>
    /// <param name="id"></param>
    /// <param name="apiKey"></param>
    /// <param name="apiUsername"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TJsonResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<TJsonResponse> GetTopic(string id,
        string apiKey,
        string apiUsername,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/t/{id}.json"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Api-Key", apiKey), new HeaderParam("Api-Username", apiUsername)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get topic by external_id
    /// </summary>
    /// <param name="externalId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task GetTopicByExternalId(string externalId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/t/external_id/{external_id}.json"),
            [new TemplateParam("external_id", externalId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Invite group to topic
    /// </summary>
    /// <param name="id"></param>
    /// <param name="apiKey"></param>
    /// <param name="apiUsername"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TInviteGroupJsonResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<TInviteGroupJsonResponse> InviteGroupToTopic(string id,
        string apiKey,
        string apiUsername,
        TInviteGroupJsonRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/t/{id}/invite-group.json"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Api-Key", apiKey),
                new HeaderParam("Api-Username", apiUsername),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TInviteGroupJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Invite to topic
    /// </summary>
    /// <param name="id"></param>
    /// <param name="apiKey"></param>
    /// <param name="apiUsername"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TInviteJsonResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<TInviteJsonResponse> InviteToTopic(string id,
        string apiKey,
        string apiUsername,
        TInviteJsonRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/t/{id}/invite.json"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Api-Key", apiKey),
                new HeaderParam("Api-Username", apiUsername),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TInviteJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get the latest topics
    /// </summary>
    /// <param name="order">Enum: <c>default</c>, <c>created</c>, <c>activity</c>, <c>views</c>, <c>posts</c>, <c>category</c>, <c>likes</c>, <c>op_likes</c>, <c>posters</c></param>
    /// <param name="ascending">Defaults to <c>desc</c>, add <c>ascending=true</c> to sort asc</param>
    /// <param name="perPage">Maximum number of topics returned, between 1-100</param>
    /// <param name="apiKey"></param>
    /// <param name="apiUsername"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LatestJsonResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<LatestJsonResponse> ListLatestTopics(string? order,
        string? ascending,
        int? perPage,
        string apiKey,
        string apiUsername,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/latest.json"),
            [],
            [new Param("order", order), new Param("ascending", ascending), new Param("per_page", perPage)],
            [new HeaderParam("Api-Key", apiKey), new HeaderParam("Api-Username", apiUsername)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<LatestJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get the top topics filtered by period
    /// </summary>
    /// <param name="period">Enum: <c>all</c>, <c>yearly</c>, <c>quarterly</c>, <c>monthly</c>, <c>weekly</c>, <c>daily</c></param>
    /// <param name="perPage">Maximum number of topics returned, between 1-100</param>
    /// <param name="apiKey"></param>
    /// <param name="apiUsername"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TopJsonResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<TopJsonResponse> ListTopTopics(string? period,
        int? perPage,
        string apiKey,
        string apiUsername,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/top.json"),
            [],
            [new Param("period", period), new Param("per_page", perPage)],
            [new HeaderParam("Api-Key", apiKey), new HeaderParam("Api-Username", apiUsername)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TopJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Remove a topic
    /// </summary>
    /// <param name="id"></param>
    /// <param name="apiKey"></param>
    /// <param name="apiUsername"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task RemoveTopic(string id,
        string apiKey,
        string apiUsername,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/t/{id}.json"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Api-Key", apiKey),
                new HeaderParam("Api-Username", apiUsername),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Set notification level
    /// </summary>
    /// <param name="id"></param>
    /// <param name="apiKey"></param>
    /// <param name="apiUsername"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TNotificationsJsonResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<TNotificationsJsonResponse> SetNotificationLevel(string id,
        string apiKey,
        string apiUsername,
        TNotificationsJsonRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/t/{id}/notifications.json"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Api-Key", apiKey),
                new HeaderParam("Api-Username", apiUsername),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TNotificationsJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Update a topic
    /// </summary>
    /// <param name="id"></param>
    /// <param name="apiKey"></param>
    /// <param name="apiUsername"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TJsonResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<TJsonResponse1> UpdateTopic(string id,
        string apiKey,
        string apiUsername,
        TJsonRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/t/-/{id}.json"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Api-Key", apiKey),
                new HeaderParam("Api-Username", apiUsername),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<TJsonResponse1>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Update the status of a topic
    /// </summary>
    /// <param name="id"></param>
    /// <param name="apiKey"></param>
    /// <param name="apiUsername"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TStatusJsonResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<TStatusJsonResponse> UpdateTopicStatus(string id,
        string apiKey,
        string apiUsername,
        TStatusJsonRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/t/{id}/status.json"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Api-Key", apiKey),
                new HeaderParam("Api-Username", apiUsername),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<TStatusJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Update topic timestamp
    /// </summary>
    /// <param name="id"></param>
    /// <param name="apiKey"></param>
    /// <param name="apiUsername"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TChangeTimestampJsonResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<TChangeTimestampJsonResponse> UpdateTopicTimestamp(string id,
        string apiKey,
        string apiUsername,
        TChangeTimestampJsonRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/t/{id}/change-timestamp.json"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Api-Key", apiKey),
                new HeaderParam("Api-Username", apiUsername),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<TChangeTimestampJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
