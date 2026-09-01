using System.Net.Http;

namespace DiscourseApiDocumentation.Core.Extensions;

internal static class HttpContentExtension
{
    extension(HttpContent)
    {
        public static HttpContent None => null!;
    }
}
