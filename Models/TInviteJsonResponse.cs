using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record TInviteJsonResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user")]
    public User1? User { get; init; }
}
