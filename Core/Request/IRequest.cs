using System.Net.Http;

namespace DiscourseApiDocumentation.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}