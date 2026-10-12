using System.Text.Json.Serialization;
using Discourse.Core.Validation;
using Discourse.Core.Validation.Attributes;

namespace Discourse.Models;

public record UPreferencesEmailJsonRequest
{
    [JsonPropertyName("email")]
    [Format(FormatKind.Email)]
    public required string Email { get; init; }
}
