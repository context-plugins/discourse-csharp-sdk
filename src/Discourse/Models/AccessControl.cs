using System.Text.Json.Serialization;

namespace Discourse.Models;

public record AccessControl
{
    [JsonPropertyName("mandatory_acl")]
    public required object MandatoryAcl { get; init; }

    [JsonPropertyName("banned_acl")]
    public required object BannedAcl { get; init; }
}
