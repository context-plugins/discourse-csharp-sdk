using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record PostStream1
{
    [JsonPropertyName("posts")]
    public required IReadOnlyList<Post4> Posts { get; init; }

    [JsonPropertyName("stream")]
    public required IReadOnlyList<object> Stream { get; init; }
}
