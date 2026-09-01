using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record GroupedSearchResult
{
    [JsonPropertyName("more_posts")]
    public required string? MorePosts { get; init; }

    [JsonPropertyName("more_users")]
    public required string? MoreUsers { get; init; }

    [JsonPropertyName("more_categories")]
    public required string? MoreCategories { get; init; }

    [JsonPropertyName("term")]
    public required string Term { get; init; }

    [JsonPropertyName("search_log_id")]
    public required int SearchLogId { get; init; }

    [JsonPropertyName("more_full_page_results")]
    public required string? MoreFullPageResults { get; init; }

    [JsonPropertyName("can_create_topic")]
    public required bool CanCreateTopic { get; init; }

    [JsonPropertyName("error")]
    public required string? Error { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extra")]
    public Extra? Extra { get; init; }

    [JsonPropertyName("post_ids")]
    public required IReadOnlyList<object> PostIds { get; init; }

    [JsonPropertyName("user_ids")]
    public required IReadOnlyList<object> UserIds { get; init; }

    [JsonPropertyName("category_ids")]
    public required IReadOnlyList<object> CategoryIds { get; init; }

    [JsonPropertyName("tag_ids")]
    public required IReadOnlyList<object> TagIds { get; init; }

    [JsonPropertyName("group_ids")]
    public required IReadOnlyList<object> GroupIds { get; init; }
}
