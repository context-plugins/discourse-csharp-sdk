using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record AdminUsersJsonRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delete_posts")]
    public bool? DeletePosts { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("block_email")]
    public bool? BlockEmail { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("block_urls")]
    public bool? BlockUrls { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("block_ip")]
    public bool? BlockIp { get; init; }
}
