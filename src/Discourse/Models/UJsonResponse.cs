using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record UJsonResponse
{
    [JsonPropertyName("user_badges")]
    public required IReadOnlyList<object> UserBadges { get; init; }

    [JsonPropertyName("user")]
    public required User8 User { get; init; }
}
