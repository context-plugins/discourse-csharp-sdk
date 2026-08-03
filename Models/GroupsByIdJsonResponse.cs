using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record GroupsByIdJsonResponse
{
    [JsonPropertyName("group")]
    public required Group1 Group { get; init; }

    [JsonPropertyName("extras")]
    public required Extras Extras { get; init; }
}
