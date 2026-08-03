using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record InvitesJsonResponse
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("invite_key")]
    public required string InviteKey { get; init; }

    [JsonPropertyName("link")]
    public required string Link { get; init; }

    [JsonPropertyName("description")]
    public required string? Description { get; init; }

    [JsonPropertyName("email")]
    public required string Email { get; init; }

    [JsonPropertyName("domain")]
    public required string? Domain { get; init; }

    [JsonPropertyName("emailed")]
    public required bool Emailed { get; init; }

    [JsonPropertyName("can_delete_invite")]
    public required bool CanDeleteInvite { get; init; }

    [JsonPropertyName("custom_message")]
    public required string? CustomMessage { get; init; }

    [JsonPropertyName("created_at")]
    public required string CreatedAt { get; init; }

    [JsonPropertyName("updated_at")]
    public required string UpdatedAt { get; init; }

    [JsonPropertyName("expires_at")]
    public required string ExpiresAt { get; init; }

    [JsonPropertyName("expired")]
    public required bool Expired { get; init; }

    [JsonPropertyName("grants_admin")]
    public required bool GrantsAdmin { get; init; }

    [JsonPropertyName("grants_moderator")]
    public required bool GrantsModerator { get; init; }

    [JsonPropertyName("topics")]
    public required IReadOnlyList<object> Topics { get; init; }

    [JsonPropertyName("groups")]
    public required IReadOnlyList<object> Groups { get; init; }
}
