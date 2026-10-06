namespace Discourse.Requests.PrivateMessages;

/// <summary>
/// The inputs of the GetUserSentPrivateMessages operation.
/// </summary>
public sealed record GetUserSentPrivateMessagesRequest
{
    public required string Username { get; init; }
}
