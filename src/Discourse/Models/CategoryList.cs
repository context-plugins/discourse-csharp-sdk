using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record CategoryList
{
    [JsonPropertyName("can_create_category")]
    public required bool CanCreateCategory { get; init; }

    [JsonPropertyName("can_create_topic")]
    public required bool CanCreateTopic { get; init; }

    [JsonPropertyName("categories")]
    public required IReadOnlyList<Category1> Categories { get; init; }
}
