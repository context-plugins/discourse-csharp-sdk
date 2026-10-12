namespace Discourse.Requests.Users;

/// <summary>
/// The inputs of the GetUserIdentiyProviderExternalId operation.
/// </summary>
public sealed record GetUserIdentiyProviderExternalIdRequest
{
    /// <summary>
    /// Authentication provider name. Can be found in the provider callback
    /// URL: <c>/auth/{provider}/callback</c>
    /// </summary>
    public required string Provider { get; init; }

    public required string ExternalId { get; init; }

    public required string ApiKey { get; init; }

    public required string ApiUsername { get; init; }
}
