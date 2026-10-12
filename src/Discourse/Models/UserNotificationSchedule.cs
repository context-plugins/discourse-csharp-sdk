using System.Text.Json.Serialization;

namespace Discourse.Models;

public record UserNotificationSchedule
{
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; init; }

    [JsonPropertyName("day_0_start_time")]
    public required int Day0StartTime { get; init; }

    [JsonPropertyName("day_0_end_time")]
    public required int Day0EndTime { get; init; }

    [JsonPropertyName("day_1_start_time")]
    public required int Day1StartTime { get; init; }

    [JsonPropertyName("day_1_end_time")]
    public required int Day1EndTime { get; init; }

    [JsonPropertyName("day_2_start_time")]
    public required int Day2StartTime { get; init; }

    [JsonPropertyName("day_2_end_time")]
    public required int Day2EndTime { get; init; }

    [JsonPropertyName("day_3_start_time")]
    public required int Day3StartTime { get; init; }

    [JsonPropertyName("day_3_end_time")]
    public required int Day3EndTime { get; init; }

    [JsonPropertyName("day_4_start_time")]
    public required int Day4StartTime { get; init; }

    [JsonPropertyName("day_4_end_time")]
    public required int Day4EndTime { get; init; }

    [JsonPropertyName("day_5_start_time")]
    public required int Day5StartTime { get; init; }

    [JsonPropertyName("day_5_end_time")]
    public required int Day5EndTime { get; init; }

    [JsonPropertyName("day_6_start_time")]
    public required int Day6StartTime { get; init; }

    [JsonPropertyName("day_6_end_time")]
    public required int Day6EndTime { get; init; }
}
