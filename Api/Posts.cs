using System;
using System.Collections.Generic;
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

public sealed class Posts
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal Posts(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

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
    /// delete a single post
    /// </summary>
    /// <param name="id"></param>
    /// <param name="apiKey"></param>
    /// <param name="apiUsername"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task DeletePost(int id,
        string apiKey,
        string apiUsername,
        PostsJsonRequest2? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/posts/{id}.json"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Api-Key", apiKey),
                new HeaderParam("Api-Username", apiUsername),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve a single post
    /// </summary>
    /// <param name="id"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PostsJsonResponse2"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint can be used to get the number of likes on a post using the
    /// <c>actions_summary</c> property in the response. <c>actions_summary</c> responses
    /// with the id of <c>2</c> signify a <c>like</c>. If there are no <c>actions_summary</c>
    /// items with the id of <c>2</c>, that means there are 0 likes. Other ids likely
    /// refer to various different flag types.
    /// </remarks>
    public Task<PostsJsonResponse2> GetPost(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/posts/{id}.json"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PostsJsonResponse2>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// List latest posts across topics
    /// </summary>
    /// <param name="before">Load posts with an id lower than this value. Useful for pagination.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PostsJsonResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<PostsJsonResponse> ListPosts(int? before,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/posts.json"),
            [],
            [new Param("before", before)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PostsJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Lock a post from being edited
    /// </summary>
    /// <param name="id"></param>
    /// <param name="apiKey"></param>
    /// <param name="apiUsername"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PostsLockedJsonResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<PostsLockedJsonResponse> LockPost(string id,
        string apiKey,
        string apiUsername,
        PostsLockedJsonRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/posts/{id}/locked.json"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Api-Key", apiKey),
                new HeaderParam("Api-Username", apiUsername),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<PostsLockedJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Like a post and other actions
    /// </summary>
    /// <param name="apiKey"></param>
    /// <param name="apiUsername"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PostActionsJsonResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<PostActionsJsonResponse> PerformPostAction(string apiKey,
        string apiUsername,
        PostActionsJsonRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/post_actions.json"),
            [],
            [],
            [new HeaderParam("Api-Key", apiKey),
                new HeaderParam("Api-Username", apiUsername),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PostActionsJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// List replies to a post
    /// </summary>
    /// <param name="id"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="PostsRepliesJsonResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<IReadOnlyList<PostsRepliesJsonResponse>> PostReplies(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/posts/{id}/replies.json"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<PostsRepliesJsonResponse>>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Update a single post
    /// </summary>
    /// <param name="id"></param>
    /// <param name="apiKey"></param>
    /// <param name="apiUsername"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PostsJsonResponse3"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<PostsJsonResponse3> UpdatePost(string id,
        string apiKey,
        string apiUsername,
        PostsJsonRequest1? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/posts/{id}.json"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Api-Key", apiKey),
                new HeaderParam("Api-Username", apiUsername),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<PostsJsonResponse3>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
