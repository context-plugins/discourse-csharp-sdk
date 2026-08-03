using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using DiscourseApiDocumentation.Core;
using DiscourseApiDocumentation.Core.ErrorResponse;
using DiscourseApiDocumentation.Core.Exceptions;
using DiscourseApiDocumentation.Core.Request;
using DiscourseApiDocumentation.Core.Response;
using DiscourseApiDocumentation.Models;

namespace DiscourseApiDocumentation.Api;

public sealed class Site
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal Site(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Get site info
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SiteJsonResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Can be used to fetch all categories and subcategories
    /// </remarks>
    public Task<SiteJsonResponse> GetSite(RequestOptions? requestOptions = null, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/site.json"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SiteJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get site basic info
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SiteBasicInfoJsonResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Can be used to fetch basic info about a site
    /// </remarks>
    public Task<SiteBasicInfoJsonResponse> GetSiteBasicInfo(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/site/basic-info.json"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SiteBasicInfoJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
