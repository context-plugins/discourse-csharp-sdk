using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record DirectoryItemsJsonResponse
{
    [JsonPropertyName("directory_items")]
    public required IReadOnlyList<DirectoryItem> DirectoryItems { get; init; }

    [JsonPropertyName("meta")]
    public required Meta1 Meta { get; init; }
}
