using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record GroupsMembersJsonResponse
{
    [JsonPropertyName("members")]
    public required IReadOnlyList<Member> Members { get; init; }

    [JsonPropertyName("owners")]
    public required IReadOnlyList<Owner> Owners { get; init; }

    [JsonPropertyName("meta")]
    public required Meta Meta { get; init; }
}
