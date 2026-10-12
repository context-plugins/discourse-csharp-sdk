namespace Discourse.Requests.Groups;

/// <summary>
/// The inputs of the DeleteGroup operation.
/// </summary>
public sealed record DeleteGroupRequest
{
    public required int Id { get; init; }
}
