using System;
using Discourse.Core.Validation.Attributes;
using Discourse.Models.Enums;

namespace Discourse.Requests.DiscourseCalendarEvents;

/// <summary>
/// The inputs of the ExportEventsIcs operation.
/// </summary>
public sealed record ExportEventsIcsRequest
{
    /// <summary>
    /// Filter events by category ID
    /// </summary>
    public int? CategoryId { get; init; }

    /// <summary>
    /// Include events from subcategories when filtering by category
    /// </summary>
    public IncludeSubcategories? IncludeSubcategories { get; init; }

    /// <summary>
    /// Filter to events where the specified user (username) has RSVP'd
    /// as going
    /// </summary>
    public string? AttendingUser { get; init; }

    /// <summary>
    /// Return events starting before this date/time (ISO 8601 format)
    /// </summary>
    public DateTimeOffset? Before { get; init; }

    /// <summary>
    /// Return events starting after this date/time (ISO 8601 format)
    /// </summary>
    public DateTimeOffset? After { get; init; }

    /// <summary>
    /// Sort order for events by start date (default: asc)
    /// </summary>
    public Order? Order { get; init; }

    /// <summary>
    /// Maximum number of events to return (default: 200)
    /// </summary>
    [Minimum(1)]
    [Maximum(200)]
    public int? Limit { get; init; }
}
