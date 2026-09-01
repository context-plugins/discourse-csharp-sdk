using System.Text.Json.Serialization;

namespace Discourse.Models;

public record SessionForgotPasswordJsonResponse
{
    [JsonPropertyName("success")]
    public required string Success { get; init; }

    [JsonPropertyName("user_found")]
    public required bool UserFound { get; init; }
}
