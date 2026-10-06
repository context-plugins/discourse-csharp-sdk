namespace Discourse.Requests.Users;

/// <summary>
/// The inputs of the GetUserExternalId operation.
/// </summary>
public sealed record GetUserExternalIdRequest
{
    public required string ExternalId { get; init; }

    public required string ApiKey { get; init; }

    public required string ApiUsername { get; init; }
}
