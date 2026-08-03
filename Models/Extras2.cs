using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record Extras2
{
    [JsonPropertyName("type_filters")]
    public required IReadOnlyList<object> TypeFilters { get; init; }
}
