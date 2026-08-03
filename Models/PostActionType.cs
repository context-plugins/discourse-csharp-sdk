using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record PostActionType
{
    [JsonPropertyName("id")]
    public required int? Id { get; init; }

    [JsonPropertyName("name_key")]
    public required string? NameKey { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("description")]
    public required string Description { get; init; }

    [JsonPropertyName("short_description")]
    public required string ShortDescription { get; init; }

    [JsonPropertyName("is_flag")]
    public required bool IsFlag { get; init; }

    [JsonPropertyName("require_message")]
    public required bool RequireMessage { get; init; }

    [JsonPropertyName("enabled")]
    public required bool Enabled { get; init; }

    [JsonPropertyName("applies_to")]
    public required IReadOnlyList<object> AppliesTo { get; init; }

    [JsonPropertyName("is_used")]
    public required bool IsUsed { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("position")]
    public int? Position { get; init; }

    [JsonPropertyName("auto_action_type")]
    public required bool AutoActionType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("system")]
    public bool? System { get; init; }
}
