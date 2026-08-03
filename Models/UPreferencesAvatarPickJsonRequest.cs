using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Models.Enums;

namespace DiscourseApiDocumentation.Models;

public record UPreferencesAvatarPickJsonRequest
{
    [JsonPropertyName("upload_id")]
    public required int UploadId { get; init; }

    [JsonPropertyName("type")]
    public required Type1 Type { get; init; }
}
