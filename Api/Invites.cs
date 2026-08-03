using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using DiscourseApiDocumentation.Core;
using DiscourseApiDocumentation.Core.ErrorResponse;
using DiscourseApiDocumentation.Core.Exceptions;
using DiscourseApiDocumentation.Core.Models;
using DiscourseApiDocumentation.Core.Request;
using DiscourseApiDocumentation.Core.Response;
using DiscourseApiDocumentation.Models;

namespace DiscourseApiDocumentation.Api;

public sealed class Invites
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal Invites(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Create an invite
    /// </summary>
    /// <param name="apiKey"></param>
    /// <param name="apiUsername"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvitesJsonResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<InvitesJsonResponse> CreateInvite(string apiKey,
        string apiUsername,
        InvitesJsonRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/invites.json"),
            [],
            [],
            [new HeaderParam("Api-Key", apiKey),
                new HeaderParam("Api-Username", apiUsername),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<InvitesJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Create multiple invites
    /// </summary>
    /// <param name="apiKey"></param>
    /// <param name="apiUsername"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvitesCreateMultipleJsonResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<InvitesCreateMultipleJsonResponse> CreateMultipleInvites(string apiKey,
        string apiUsername,
        InvitesCreateMultipleJsonRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/invites/create-multiple.json"),
            [],
            [],
            [new HeaderParam("Api-Key", apiKey),
                new HeaderParam("Api-Username", apiUsername),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<InvitesCreateMultipleJsonResponse>(),
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
}
