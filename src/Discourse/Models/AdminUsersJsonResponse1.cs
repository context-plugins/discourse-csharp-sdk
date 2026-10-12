using System.Text.Json.Serialization;

namespace Discourse.Models;

public record AdminUsersJsonResponse1
{
    [JsonPropertyName("deleted")]
    public required bool Deleted { get; init; }
}
