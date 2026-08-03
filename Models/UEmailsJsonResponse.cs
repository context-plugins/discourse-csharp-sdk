using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record UEmailsJsonResponse
{
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    [JsonPropertyName("secondary_emails")]
    public required IReadOnlyList<object> SecondaryEmails { get; init; }

    [JsonPropertyName("unconfirmed_emails")]
    public required IReadOnlyList<object> UnconfirmedEmails { get; init; }

    [JsonPropertyName("associated_accounts")]
    public required IReadOnlyList<object> AssociatedAccounts { get; init; }
}
