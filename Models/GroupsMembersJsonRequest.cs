using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record GroupsMembersJsonRequest
{
    /// <summary>
    /// comma separated list
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usernames")]
    public string? Usernames { get; init; }
}
