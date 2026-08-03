using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record SessionForgotPasswordJsonRequest
{
    [JsonPropertyName("login")]
    public required string Login { get; init; }
}
