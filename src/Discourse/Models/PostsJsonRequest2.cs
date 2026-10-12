using System.Text.Json.Serialization;

namespace Discourse.Models;

public record PostsJsonRequest2
{
    /// <summary>
    /// The <c>SiteSetting.can_permanently_delete</c> needs to be
    /// enabled first before this param can be used. Also this endpoint
    /// needs to be called first without <c>force_destroy</c> and then followed
    /// up with a second call 5 minutes later with <c>force_destroy</c> to
    /// permanently delete.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("force_destroy")]
    public bool? ForceDestroy { get; init; }
}
