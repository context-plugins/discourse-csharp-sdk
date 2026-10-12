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
using Discourse.Requests.Tags;

namespace Discourse.Api;

public sealed class Tags
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal Tags(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Creates a tag group
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TagGroupsJsonResponse1"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<TagGroupsJsonResponse1> CreateTagGroup(CreateTagGroupRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/tag_groups.json"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TagGroupsJsonResponse1>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a specific tag
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TagJsonResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<TagJsonResponse> GetTag(GetTagRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/tag/{name}.json"),
            [new TemplateParam("name", request.Name)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TagJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a single tag group
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TagGroupsJsonResponse2"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<TagGroupsJsonResponse2> GetTagGroup(GetTagGroupRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/tag_groups/{id}.json"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TagGroupsJsonResponse2>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of tag groups
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TagGroupsJsonResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<TagGroupsJsonResponse> ListTagGroups(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/tag_groups.json"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TagGroupsJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of tags
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TagsJsonResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<TagsJsonResponse> ListTags(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/tags.json"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TagsJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update tag group
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TagGroupsJsonResponse3"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<TagGroupsJsonResponse3> UpdateTagGroup(UpdateTagGroupRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/tag_groups/{id}.json"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TagGroupsJsonResponse3>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);
}
