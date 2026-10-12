using System.Text.Json.Serialization;

namespace Discourse.Models;

public record UserAvatarRefreshGravatarJsonResponse
{
    [JsonPropertyName("gravatar_upload_id")]
    public required int? GravatarUploadId { get; init; }

    [JsonPropertyName("gravatar_avatar_template")]
    public required string? GravatarAvatarTemplate { get; init; }
}
