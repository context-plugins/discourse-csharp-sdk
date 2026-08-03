using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record PostTypes
{
    [JsonPropertyName("regular")]
    public required int Regular { get; init; }

    [JsonPropertyName("moderator_action")]
    public required int ModeratorAction { get; init; }

    [JsonPropertyName("small_action")]
    public required int SmallAction { get; init; }

    [JsonPropertyName("whisper")]
    public required int Whisper { get; init; }
}
