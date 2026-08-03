using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Core.Validation;
using DiscourseApiDocumentation.Core.Validation.Attributes;

namespace DiscourseApiDocumentation.Models;

public record UPreferencesEmailJsonRequest
{
    [JsonPropertyName("email")]
    [Format(FormatKind.Email)]
    public required string Email { get; init; }
}
