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
using Discourse.Requests.Invites;
using Discourse.Requests.Topics;

namespace Discourse.Api;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvitesJsonResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<InvitesJsonResponse> CreateInvite(CreateInviteRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/invites.json"),
            [],
            [],
            [
                new HeaderParam("Api-Key", request.ApiKey),
                new HeaderParam("Api-Username", request.ApiUsername),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<InvitesJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create multiple invites
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvitesCreateMultipleJsonResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<InvitesCreateMultipleJsonResponse> CreateMultipleInvites(CreateMultipleInvitesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/invites/create-multiple.json"),
            [],
            [],
            [
                new HeaderParam("Api-Key", request.ApiKey),
                new HeaderParam("Api-Username", request.ApiUsername),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<InvitesCreateMultipleJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Invite group to topic
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TInviteGroupJsonResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<TInviteGroupJsonResponse> InviteGroupToTopic(InviteGroupToTopicRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/t/{id}/invite-group.json"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("Api-Key", request.ApiKey),
                new HeaderParam("Api-Username", request.ApiUsername),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TInviteGroupJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Invite to topic
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TInviteJsonResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<TInviteJsonResponse> InviteToTopic(InviteToTopicRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/t/{id}/invite.json"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("Api-Key", request.ApiKey),
                new HeaderParam("Api-Username", request.ApiUsername),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TInviteJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);
}
