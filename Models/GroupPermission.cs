using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record GroupPermission
{
    [JsonPropertyName("permission_type")]
    public required int PermissionType { get; init; }

    [JsonPropertyName("group_name")]
    public required string GroupName { get; init; }

    [JsonPropertyName("group_id")]
    public required int GroupId { get; init; }
}
