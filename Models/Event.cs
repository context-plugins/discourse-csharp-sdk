using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Discourse.Models.Enums;

namespace Discourse.Models;

public record Event
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("category_id")]
    public required int? CategoryId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurrence")]
    public string? Recurrence { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurrence_until")]
    public DateTimeOffset? RecurrenceUntil { get; init; }

    [JsonPropertyName("starts_at")]
    public required DateTimeOffset? StartsAt { get; init; }

    [JsonPropertyName("ends_at")]
    public required DateTimeOffset? EndsAt { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rrule")]
    public string? Rrule { get; init; }

    [JsonPropertyName("show_local_time")]
    public required bool ShowLocalTime { get; init; }

    [JsonPropertyName("timezone")]
    public required string? Timezone { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("duration")]
    [RegularExpression("^\\d{2}:\\d{2}:\\d{2}$")]
    public string? Duration { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("all_day")]
    public bool? AllDay { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_fields")]
    public object? CustomFields { get; init; }

    [JsonPropertyName("post")]
    public required Post Post { get; init; }

    [JsonPropertyName("occurrences")]
    public required IReadOnlyList<Occurrence> Occurrences { get; init; }

    [JsonPropertyName("can_act_on_discourse_post_event")]
    public required bool? CanActOnDiscoursePostEvent { get; init; }

    [JsonPropertyName("can_update_attendance")]
    public required bool? CanUpdateAttendance { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creator")]
    public Creator? Creator { get; init; }

    [JsonPropertyName("is_closed")]
    public required bool IsClosed { get; init; }

    [JsonPropertyName("is_expired")]
    public required bool IsExpired { get; init; }

    [JsonPropertyName("is_ongoing")]
    public required bool IsOngoing { get; init; }

    [JsonPropertyName("is_private")]
    public required bool IsPrivate { get; init; }

    [JsonPropertyName("is_public")]
    public required bool IsPublic { get; init; }

    [JsonPropertyName("is_standalone")]
    public required bool IsStandalone { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minimal")]
    public bool? Minimal { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("raw_invitees")]
    public IReadOnlyList<string?>? RawInvitees { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reminders")]
    public IReadOnlyList<Reminder>? Reminders { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sample_invitees")]
    public IReadOnlyList<object>? SampleInvitees { get; init; }

    [JsonPropertyName("should_display_invitees")]
    public required bool ShouldDisplayInvitees { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stats")]
    public object? Stats { get; init; }

    [JsonPropertyName("status")]
    public required Status Status { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description_html")]
    public string? DescriptionHtml { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public string? Location { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("watching_invitee")]
    public object? WatchingInvitee { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chat_enabled")]
    public bool? ChatEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("channel")]
    public object? Channel { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("livestream")]
    public bool? Livestream { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("livestream_onebox")]
    public string? LivestreamOnebox { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_zoom_livestream")]
    public bool? IsZoomLivestream { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_attendees")]
    public int? MaxAttendees { get; init; }

    [JsonPropertyName("at_capacity")]
    public required bool AtCapacity { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("image_upload")]
    public object? ImageUpload { get; init; }
}
