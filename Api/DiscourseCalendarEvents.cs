using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Discourse.Core;
using Discourse.Core.ErrorResponse;
using Discourse.Core.Exceptions;
using Discourse.Core.Extensions;
using Discourse.Core.Models;
using Discourse.Core.Request;
using Discourse.Core.Response;
using Discourse.Models;
using Discourse.Requests.DiscourseCalendarEvents;

namespace Discourse.Api;

public sealed class DiscourseCalendarEvents
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal DiscourseCalendarEvents(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Export calendar events in iCalendar format
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task ExportEventsIcs(ExportEventsIcsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/discourse-post-event/events.ics"),
            [],
            [
                new Param("category_id", request.CategoryId),
                new Param("include_subcategories", request.IncludeSubcategories),
                new Param("attending_user", request.AttendingUser),
                new Param("before", request.Before?.ToIso8601()),
                new Param("after", request.After?.ToIso8601()),
                new Param("order", request.Order),
                new Param("limit", request.Limit),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List calendar events
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DiscoursePostEventEventsJsonResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<DiscoursePostEventEventsJsonResponse> ListEvents(ListEventsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/discourse-post-event/events.json"),
            [],
            [
                new Param("include_details", request.IncludeDetails),
                new Param("category_id", request.CategoryId),
                new Param("include_subcategories", request.IncludeSubcategories),
                new Param("post_id", request.PostId),
                new Param("attending_user", request.AttendingUser),
                new Param("before", request.Before?.ToIso8601()),
                new Param("after", request.After?.ToIso8601()),
                new Param("order", request.Order),
                new Param("limit", request.Limit),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DiscoursePostEventEventsJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);
}
