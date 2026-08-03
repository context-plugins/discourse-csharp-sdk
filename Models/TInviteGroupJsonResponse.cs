using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record TInviteGroupJsonResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("group")]
    public Group6? Group { get; init; }
}
