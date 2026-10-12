using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record DiscoursePostEventEventsJsonResponse
{
    [JsonPropertyName("events")]
    public required IReadOnlyList<Event> Events { get; init; }
}
