using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using DiscourseApiDocumentation.Core;
using DiscourseApiDocumentation.Core.ErrorResponse;
using DiscourseApiDocumentation.Core.Exceptions;
using DiscourseApiDocumentation.Core.Extensions;
using DiscourseApiDocumentation.Core.Models;
using DiscourseApiDocumentation.Core.Request;
using DiscourseApiDocumentation.Core.Response;
using DiscourseApiDocumentation.Models;
using DiscourseApiDocumentation.Models.Enums;

namespace DiscourseApiDocumentation.Api;

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
    /// <param name="categoryId">Filter events by category ID</param>
    /// <param name="includeSubcategories">Include events from subcategories when filtering by category</param>
    /// <param name="attendingUser">Filter to events where the specified user (username) has RSVP'd as going</param>
    /// <param name="before">Return events starting before this date/time (ISO 8601 format)</param>
    /// <param name="after">Return events starting after this date/time (ISO 8601 format)</param>
    /// <param name="order">Sort order for events by start date (default: asc)</param>
    /// <param name="limit">Maximum number of events to return (default: 200)</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task ExportEventsIcs(int? categoryId,
        IncludeSubcategories? includeSubcategories,
        string? attendingUser,
        DateTimeOffset? before,
        DateTimeOffset? after,
        Order? order,
        int? limit,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/discourse-post-event/events.ics"),
            [],
            [new Param("category_id", categoryId),
                new Param("include_subcategories", includeSubcategories),
                new Param("attending_user", attendingUser),
                new Param("before", before?.ToIso8601()),
                new Param("after", after?.ToIso8601()),
                new Param("order", order),
                new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// List calendar events
    /// </summary>
    /// <param name="includeDetails">Include detailed event information (creator, invitees, stats, etc.)</param>
    /// <param name="categoryId">Filter events by category ID</param>
    /// <param name="includeSubcategories">Include events from subcategories when filtering by category</param>
    /// <param name="postId">Filter to events associated with a specific post ID</param>
    /// <param name="attendingUser">Filter to events where the specified user (username) has RSVP'd as going</param>
    /// <param name="before">Return events starting before this date/time (ISO 8601 format)</param>
    /// <param name="after">Return events starting after this date/time (ISO 8601 format)</param>
    /// <param name="order">Sort order for events by start date (default: asc)</param>
    /// <param name="limit">Maximum number of events to return (default: 200)</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DiscoursePostEventEventsJsonResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<DiscoursePostEventEventsJsonResponse> ListEvents(IncludeDetails? includeDetails,
        int? categoryId,
        IncludeSubcategories? includeSubcategories,
        int? postId,
        string? attendingUser,
        DateTimeOffset? before,
        DateTimeOffset? after,
        Order? order,
        int? limit,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/discourse-post-event/events.json"),
            [],
            [new Param("include_details", includeDetails),
                new Param("category_id", categoryId),
                new Param("include_subcategories", includeSubcategories),
                new Param("post_id", postId),
                new Param("attending_user", attendingUser),
                new Param("before", before?.ToIso8601()),
                new Param("after", after?.ToIso8601()),
                new Param("order", order),
                new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DiscoursePostEventEventsJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
