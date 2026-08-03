using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record DiscoursePostEventEventsJsonResponse
{
    [JsonPropertyName("events")]
    public required IReadOnlyList<Event> Events { get; init; }
}
