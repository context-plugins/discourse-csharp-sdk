using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using DiscourseApiDocumentation.Core;
using DiscourseApiDocumentation.Core.ErrorResponse;
using DiscourseApiDocumentation.Core.Exceptions;
using DiscourseApiDocumentation.Core.Models;
using DiscourseApiDocumentation.Core.Request;
using DiscourseApiDocumentation.Core.Response;
using DiscourseApiDocumentation.Models;

namespace DiscourseApiDocumentation.Api;

public sealed class Search
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal Search(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Search for a term
    /// </summary>
    /// <param name="q">The query string needs to be url encoded and is made up of the following options: - Search term. This is just a string. Usually it would be the first item in the query. - <c>@&lt;username&gt;</c>: Use the <c>@</c> followed by the username to specify posts by this user. - <c>#&lt;category&gt;</c>: Use the <c>#</c> followed by the category slug to search within this category. - <c>tags:</c>: <c>api,solved</c> or for posts that have all the specified tags <c>api+solved</c>. - <c>before:</c>: <c>yyyy-mm-dd</c> - <c>after:</c>: <c>yyyy-mm-dd</c> - <c>order:</c>: <c>latest</c>, <c>likes</c>, <c>views</c>, <c>latest_topic</c> - <c>assigned:</c>: username (without <c>@</c>) - <c>in:</c>: <c>title</c>, <c>likes</c>, <c>personal</c>, <c>messages</c>, <c>seen</c>, <c>unseen</c>, <c>posted</c>, <c>created</c>, <c>watching</c>, <c>tracking</c>, <c>bookmarks</c>, <c>assigned</c>, <c>unassigned</c>, <c>first</c>, <c>pinned</c>, <c>wiki</c> - <c>with:</c>: <c>images</c> - <c>status:</c>: <c>open</c>, <c>closed</c>, <c>public</c>, <c>archived</c>, <c>noreplies</c>, <c>single_user</c>, <c>solved</c>, <c>unsolved</c> - <c>group:</c>: group_name or group_id - <c>group_messages:</c>: group_name or group_id - <c>min_posts:</c>: 1 - <c>max_posts:</c>: 10 - <c>min_views:</c>: 1 - <c>max_views:</c>: 10  If you are using cURL you can use the <c>-G</c> and the <c>--data-urlencode</c> flags to encode the query:  ``` curl -i -sS -X GET -G "http://localhost:3000/search.json" \ --data-urlencode 'q=wordpress @scossar #fun after:2020-01-01' ```</param>
    /// <param name="page"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchJsonResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<SearchJsonResponse> SearchInvoke(string? q,
        int? page,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/search.json"),
            [],
            [new Param("q", q), new Param("page", page)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SearchJsonResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
