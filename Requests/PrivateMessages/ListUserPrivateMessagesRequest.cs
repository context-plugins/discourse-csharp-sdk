namespace Discourse.Requests.PrivateMessages;

/// <summary>
/// The inputs of the ListUserPrivateMessages operation.
/// </summary>
public sealed record ListUserPrivateMessagesRequest
{
    public required string Username { get; init; }
}
