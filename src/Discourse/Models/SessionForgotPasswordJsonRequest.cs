using System.Text.Json.Serialization;

namespace Discourse.Models;

public record SessionForgotPasswordJsonRequest
{
    [JsonPropertyName("login")]
    public required string Login { get; init; }
}
