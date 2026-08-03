using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record UserActionsJsonResponse
{
    [JsonPropertyName("user_actions")]
    public required IReadOnlyList<UserAction> UserActions { get; init; }
}
