using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Core.Models;

namespace DiscourseApiDocumentation.Models;

public record InvitesCreateMultipleJsonRequest
{
    /// <summary>
    /// pass 1 email per invite to be generated. other properties
    /// will be shared by each invite.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    [JsonPropertyName("skip_email")]
    public bool? SkipEmail { get; init; } = false;

    /// <summary>
    /// optional, for email invites
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_message")]
    public string? CustomMessage { get; init; }

    /// <summary>
    /// optional, for link invites
    /// </summary>
    [JsonPropertyName("max_redemptions_allowed")]
    public int? MaxRedemptionsAllowed { get; init; } = 1;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("topic_id")]
    public int? TopicId { get; init; }

    /// <summary>
    /// Optional, either this or <c>group_names</c>. Comma separated
    /// list for multiple ids.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("group_ids")]
    public string? GroupIds { get; init; }

    /// <summary>
    /// Optional, either this or <c>group_ids</c>. Comma separated
    /// list for multiple names.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("group_names")]
    public string? GroupNames { get; init; }

    /// <summary>
    /// optional, if not supplied, the invite_expiry_days site
    /// setting is used
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expires_at")]
    public string? ExpiresAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
