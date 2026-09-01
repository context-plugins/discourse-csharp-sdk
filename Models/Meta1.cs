using System.Text.Json.Serialization;

namespace Discourse.Models;

public record Meta1
{
    [JsonPropertyName("last_updated_at")]
    public required string? LastUpdatedAt { get; init; }

    [JsonPropertyName("total_rows_directory_items")]
    public required int TotalRowsDirectoryItems { get; init; }

    [JsonPropertyName("load_more_directory_items")]
    public required string LoadMoreDirectoryItems { get; init; }
}
