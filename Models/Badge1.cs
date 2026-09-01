using System.Text.Json.Serialization;

namespace Discourse.Models;

public record Badge1
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("description")]
    public required string Description { get; init; }

    [JsonPropertyName("grant_count")]
    public required int GrantCount { get; init; }

    [JsonPropertyName("allow_title")]
    public required bool AllowTitle { get; init; }

    [JsonPropertyName("multiple_grant")]
    public required bool MultipleGrant { get; init; }

    [JsonPropertyName("icon")]
    public required string Icon { get; init; }

    [JsonPropertyName("image_url")]
    public required string? ImageUrl { get; init; }

    [JsonPropertyName("image_upload_id")]
    public required int? ImageUploadId { get; init; }

    [JsonPropertyName("listable")]
    public required bool Listable { get; init; }

    [JsonPropertyName("enabled")]
    public required bool Enabled { get; init; }

    [JsonPropertyName("badge_grouping_id")]
    public required int BadgeGroupingId { get; init; }

    [JsonPropertyName("system")]
    public required bool System { get; init; }

    [JsonPropertyName("long_description")]
    public required string LongDescription { get; init; }

    [JsonPropertyName("slug")]
    public required string Slug { get; init; }

    [JsonPropertyName("manually_grantable")]
    public required bool ManuallyGrantable { get; init; }

    [JsonPropertyName("query")]
    public required string? Query { get; init; }

    [JsonPropertyName("trigger")]
    public required string? Trigger { get; init; }

    [JsonPropertyName("target_posts")]
    public required bool TargetPosts { get; init; }

    [JsonPropertyName("auto_revoke")]
    public required bool AutoRevoke { get; init; }

    [JsonPropertyName("show_posts")]
    public required bool ShowPosts { get; init; }

    [JsonPropertyName("badge_type_id")]
    public required int BadgeTypeId { get; init; }

    [JsonPropertyName("show_in_post_header")]
    public required bool ShowInPostHeader { get; init; }
}
