using Microsoft.Extensions.Logging;

namespace DiscourseApiDocumentation.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }
}
