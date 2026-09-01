using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record UserActionsJsonResponse
{
    [JsonPropertyName("user_actions")]
    public required IReadOnlyList<UserAction> UserActions { get; init; }
}
