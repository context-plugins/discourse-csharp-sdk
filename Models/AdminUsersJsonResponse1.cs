using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record AdminUsersJsonResponse1
{
    [JsonPropertyName("deleted")]
    public required bool Deleted { get; init; }
}
