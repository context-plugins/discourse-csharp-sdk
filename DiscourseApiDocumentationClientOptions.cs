using System.Collections.Generic;
using DiscourseApiDocumentation.Core.Configuration;
using DiscourseApiDocumentation.Core.Hooks;
using DiscourseApiDocumentation.Servers;

namespace DiscourseApiDocumentation;

public class DiscourseApiDocumentationClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public ServerOptions Server { get; set; } = new();
    public IReadOnlyList<SdkHook> Hooks { get; set; } = [];
}
