using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record GroupsMembersJsonResponse1
{
    [JsonPropertyName("success")]
    public required string Success { get; init; }

    [JsonPropertyName("usernames")]
    public required IReadOnlyList<object> Usernames { get; init; }

    [JsonPropertyName("emails")]
    public required IReadOnlyList<object> Emails { get; init; }
}
