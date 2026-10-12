using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Discourse.Core.Hooks;

namespace Discourse.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
