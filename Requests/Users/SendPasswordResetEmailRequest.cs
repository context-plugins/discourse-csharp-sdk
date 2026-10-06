using Discourse.Models;

namespace Discourse.Requests.Users;

/// <summary>
/// The inputs of the SendPasswordResetEmail operation.
/// </summary>
public sealed record SendPasswordResetEmailRequest
{
    public SessionForgotPasswordJsonRequest? Body { get; init; }
}
