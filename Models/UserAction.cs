using System.Text.Json.Serialization;

namespace Discourse.Models;

public record UserAction
{
    [JsonPropertyName("excerpt")]
    public required string Excerpt { get; init; }

    [JsonPropertyName("action_type")]
    public required int ActionType { get; init; }

    [JsonPropertyName("created_at")]
    public required string CreatedAt { get; init; }

    [JsonPropertyName("avatar_template")]
    public required string AvatarTemplate { get; init; }

    [JsonPropertyName("acting_avatar_template")]
    public required string ActingAvatarTemplate { get; init; }

    [JsonPropertyName("slug")]
    public required string Slug { get; init; }

    [JsonPropertyName("topic_id")]
    public required int TopicId { get; init; }

    [JsonPropertyName("target_user_id")]
    public required int TargetUserId { get; init; }

    [JsonPropertyName("target_name")]
    public required string? TargetName { get; init; }

    [JsonPropertyName("target_username")]
    public required string TargetUsername { get; init; }

    [JsonPropertyName("post_number")]
    public required int PostNumber { get; init; }

    [JsonPropertyName("post_id")]
    public required string? PostId { get; init; }

    [JsonPropertyName("username")]
    public required string Username { get; init; }

    [JsonPropertyName("name")]
    public required string? Name { get; init; }

    [JsonPropertyName("user_id")]
    public required int UserId { get; init; }

    [JsonPropertyName("acting_username")]
    public required string ActingUsername { get; init; }

    [JsonPropertyName("acting_name")]
    public required string? ActingName { get; init; }

    [JsonPropertyName("acting_user_id")]
    public required int ActingUserId { get; init; }

    [JsonPropertyName("title")]
    public required string Title { get; init; }

    [JsonPropertyName("deleted")]
    public required bool Deleted { get; init; }

    [JsonPropertyName("hidden")]
    public required string? Hidden { get; init; }

    [JsonPropertyName("post_type")]
    public required string? PostType { get; init; }

    [JsonPropertyName("action_code")]
    public required string? ActionCode { get; init; }

    [JsonPropertyName("category_id")]
    public required int CategoryId { get; init; }

    [JsonPropertyName("closed")]
    public required bool Closed { get; init; }

    [JsonPropertyName("archived")]
    public required bool Archived { get; init; }
}
