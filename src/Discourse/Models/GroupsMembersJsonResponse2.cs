using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record GroupsMembersJsonResponse2
{
    [JsonPropertyName("success")]
    public required string Success { get; init; }

    [JsonPropertyName("usernames")]
    public required IReadOnlyList<object> Usernames { get; init; }

    [JsonPropertyName("skipped_usernames")]
    public required IReadOnlyList<object> SkippedUsernames { get; init; }
}
