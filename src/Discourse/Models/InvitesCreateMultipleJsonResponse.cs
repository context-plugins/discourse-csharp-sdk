using System.Collections.Generic;
using System.Text.Json.Serialization;
using Discourse.Core.Models;

namespace Discourse.Models;

public record InvitesCreateMultipleJsonResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_successfully_created_invitations")]
    public int? NumSuccessfullyCreatedInvitations { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_failed_invitations")]
    public int? NumFailedInvitations { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("failed_invitations")]
    public IReadOnlyList<object>? FailedInvitations { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("successful_invitations")]
    public IReadOnlyList<object>? SuccessfulInvitations { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
