using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record PostsJsonRequest1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("post")]
    public Post1? Post { get; init; }

    /// <summary>
    /// Skip bumping the topic when updating the post. Requires
    /// staff or TL4 permissions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bypass_bump")]
    public bool? BypassBump { get; init; }
}
