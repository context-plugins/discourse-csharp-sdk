using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record Extras
{
    [JsonPropertyName("visible_group_names")]
    public required IReadOnlyList<object> VisibleGroupNames { get; init; }
}
