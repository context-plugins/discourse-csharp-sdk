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
using Discourse.Requests.Posts;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PostsJsonResponse1"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<PostsJsonResponse1> CreateTopicPostPm(CreateTopicPostPmRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/posts.json"),
            [],
            [],
            [
                new HeaderParam("Api-Key", request.ApiKey),
                new HeaderParam("Api-Username", request.ApiUsername),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PostsJsonResponse1>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// delete a single post
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task DeletePost(DeletePostRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/posts/{id}.json"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("Api-Key", request.ApiKey),
                new HeaderParam("Api-Username", request.ApiUsername),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            JsonRequest.Create(request.Body),
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Retrieve a single post
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PostsJsonResponse2"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint can be used to get the number of likes on a post using the
    /// <c>actions_summary</c> property in the response. <c>actions_summary</c> responses
    /// with the id of <c>2</c> signify a <c>like</c>. If there are no <c>actions_summary</c>
    /// items with the id of <c>2</c>, that means there are 0 likes. Other ids likely
    /// refer to various different flag types.
    /// </remarks>
    public Task<PostsJsonResponse2> GetPost(GetPostRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/posts/{id}.json"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PostsJsonResponse2>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List latest posts across topics
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PostsJsonResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<PostsJsonResponse> ListPosts(ListPostsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/posts.json"),
            [],
            [new Param("before", request.Before)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PostsJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Lock a post from being edited
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PostsLockedJsonResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<PostsLockedJsonResponse> LockPost(LockPostRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/posts/{id}/locked.json"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("Api-Key", request.ApiKey),
                new HeaderParam("Api-Username", request.ApiUsername),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PostsLockedJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Like a post and other actions
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PostActionsJsonResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<PostActionsJsonResponse> PerformPostAction(PerformPostActionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/post_actions.json"),
            [],
            [],
            [
                new HeaderParam("Api-Key", request.ApiKey),
                new HeaderParam("Api-Username", request.ApiUsername),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PostActionsJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List replies to a post
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="PostsRepliesJsonResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<IReadOnlyList<PostsRepliesJsonResponse>> PostReplies(PostRepliesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/posts/{id}/replies.json"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<PostsRepliesJsonResponse>>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a single post
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PostsJsonResponse3"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<PostsJsonResponse3> UpdatePost(UpdatePostRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/posts/{id}.json"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("Api-Key", request.ApiKey),
                new HeaderParam("Api-Username", request.ApiUsername),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PostsJsonResponse3>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);
}
