using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record UploadsCompleteMultipartJsonResponse
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("url")]
    public required string Url { get; init; }

    [JsonPropertyName("original_filename")]
    public required string OriginalFilename { get; init; }

    [JsonPropertyName("filesize")]
    public required int Filesize { get; init; }

    [JsonPropertyName("width")]
    public required int Width { get; init; }

    [JsonPropertyName("height")]
    public required int Height { get; init; }

    [JsonPropertyName("thumbnail_width")]
    public required int ThumbnailWidth { get; init; }

    [JsonPropertyName("thumbnail_height")]
    public required int ThumbnailHeight { get; init; }

    [JsonPropertyName("extension")]
    public required string Extension { get; init; }

    [JsonPropertyName("short_url")]
    public required string ShortUrl { get; init; }

    [JsonPropertyName("short_path")]
    public required string ShortPath { get; init; }

    [JsonPropertyName("retain_hours")]
    public required string? RetainHours { get; init; }

    [JsonPropertyName("human_filesize")]
    public required string HumanFilesize { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dominant_color")]
    public string? DominantColor { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("thumbnail")]
    public Thumbnail? Thumbnail { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("optimized_video")]
    public OptimizedVideo? OptimizedVideo { get; init; }
}
