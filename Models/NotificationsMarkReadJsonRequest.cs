using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record NotificationsMarkReadJsonRequest
{
    /// <summary>
    /// (optional) Leave off to mark all notifications as
    /// read
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public int? Id { get; init; }
}
