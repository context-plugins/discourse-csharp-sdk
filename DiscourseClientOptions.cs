using System.Collections.Generic;
using Discourse.Core.Configuration;
using Discourse.Core.Hooks;
using Discourse.Servers;

namespace Discourse;

public class DiscourseClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public ServerOptions Server { get; set; } = new();
    public IReadOnlyList<SdkHook> Hooks { get; set; } = [];
}
