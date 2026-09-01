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

public sealed class PrivateMessages
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal PrivateMessages(RawClient rawClient, Server server)
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
    /// Get a list of private messages sent for a user
    /// </summary>
    /// <param name="username"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TopicsPrivateMessagesSentJsonResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<TopicsPrivateMessagesSentJsonResponse> GetUserSentPrivateMessages(string username,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/topics/private-messages-sent/{username}.json"),
            [new TemplateParam("username", username)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TopicsPrivateMessagesSentJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get a list of private messages for a user
    /// </summary>
    /// <param name="username"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TopicsPrivateMessagesJsonResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<TopicsPrivateMessagesJsonResponse> ListUserPrivateMessages(string username,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/topics/private-messages/{username}.json"),
            [new TemplateParam("username", username)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TopicsPrivateMessagesJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
