using System.Text.Json.Serialization;

namespace Discourse.Models;

public record GroupsMembersJsonRequest
{
    /// <summary>
    /// comma separated list
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usernames")]
    public string? Usernames { get; init; }
}
