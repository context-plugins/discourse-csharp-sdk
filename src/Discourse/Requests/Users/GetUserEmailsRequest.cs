namespace Discourse.Requests.Users;

/// <summary>
/// The inputs of the GetUserEmails operation.
/// </summary>
public sealed record GetUserEmailsRequest
{
    public required string Username { get; init; }
}
