using System.Net.Http;
using Discourse.Api;
using Discourse.Core;
using Discourse.Core.Logging;
using Discourse.Core.Models;

namespace Discourse;

/// <summary>
/// This page contains the documentation on how to use Discourse through API calls.
/// <para>
/// &gt; Note: For any endpoints not listed you can follow the
/// <see href="https://meta.discourse.org/t/-/20576">reverse engineer the Discourse API</see>
/// guide to figure out how to use an API endpoint.
/// </para>
/// <para>
/// ### Request Content-Type
/// </para>
/// <para>
/// The Content-Type for POST and PUT requests can be set to <c>application/x-www-form-urlencoded</c>,
/// <c>multipart/form-data</c>, or <c>application/json</c>.
/// </para>
/// <para>
/// ### Endpoint Names and Response Content-Type
/// </para>
/// <para>
/// Most API endpoints provide the same content as their HTML counterparts. For example
/// the URL <c>/categories</c> serves a list of categories, the <c>/categories.json</c> API provides the
/// same information in JSON format.
/// </para>
/// <para>
/// Instead of sending API requests to <c>/categories.json</c> you may also send them to <c>/categories</c>
/// and add an <c>Accept: application/json</c> header to the request to get the JSON response.
/// Sending requests with the <c>Accept</c> header is necessary if you want to use URLs
/// for related endpoints returned by the API, such as pagination URLs.
/// These URLs are returned without the <c>.json</c> prefix so you need to add the header in
/// order to get the correct response format.
/// </para>
/// <para>
/// ### Authentication
/// </para>
/// <para>
/// Some endpoints do not require any authentication, pretty much anything else will
/// require you to be authenticated.
/// </para>
/// <para>
/// To become authenticated you will need to create an API Key from the admin panel.
/// </para>
/// <para>
/// Once you have your API Key you can pass it in along with your API Username
/// as an HTTP header like this:
/// </para>
/// <code>
/// curl -X GET "http://127.0.0.1:3000/admin/users/list/active.json" \
/// -H "Api-Key: 714552c6148e1617aeab526d0606184b94a80ec048fc09894ff1a72b740c5f19" \
/// -H "Api-Username: system"
/// </code>
/// <para>
/// and this is how POST requests will look:
/// </para>
/// <code>
/// curl -X POST "http://127.0.0.1:3000/categories" \
/// -H "Content-Type: multipart/form-data;" \
/// -H "Api-Key: 714552c6148e1617aeab526d0606184b94a80ec048fc09894ff1a72b740c5f19" \
/// -H "Api-Username: system" \
/// -F "name=89853c20-4409-e91a-a8ea-f6cdff96aaaa" \
/// -F "color=49d9e9" \
/// -F "text_color=f0fcfd"
/// </code>
/// <para>
/// ### Boolean values
/// </para>
/// <para>
/// If an endpoint accepts a boolean be sure to specify it as a lowercase
/// <c>true</c> or <c>false</c> value unless noted otherwise.
/// </para>
/// </summary>
public sealed class DiscourseClient
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    public DiscourseClient(HttpClient httpClient, DiscourseClientOptions options)
    {
        _server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory = new HeadersFactory([
            new HeaderParam("User-Agent", "DiscourseClient/latest CSharp"),
            new HeaderParam("X-APIMatic-Lang", "CSharp"),
            new HeaderParam("X-APIMatic-Package-Version", "latest"),
            new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
            new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
            new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime),
        ]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry, options.TimeProvider);
        var httpLogger = new HttpLogger(options.Logging, "DiscourseClient", options.TimeProvider);
        var responseContexts = new ResponseContextFactory(options.TimeProvider, options.StreamReadTimeout);
        _rawClient =
            new RawClient(
                httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                options.Hooks,
                responseContexts);
    }

    public Admin Admin => field ??= new Admin(_rawClient, _server);

    public Backups Backups => field ??= new Backups(_rawClient, _server);

    public Badges Badges => field ??= new Badges(_rawClient, _server);

    public Categories Categories => field ??= new Categories(_rawClient, _server);

    public DiscourseCalendarEvents DiscourseCalendarEvents =>
        field ??= new DiscourseCalendarEvents(_rawClient, _server);

    public Groups Groups => field ??= new Groups(_rawClient, _server);

    public Invites Invites => field ??= new Invites(_rawClient, _server);

    public Notifications Notifications => field ??= new Notifications(_rawClient, _server);

    public Posts Posts => field ??= new Posts(_rawClient, _server);

    public PrivateMessages PrivateMessages => field ??= new PrivateMessages(_rawClient, _server);

    public Search Search => field ??= new Search(_rawClient, _server);

    public Site Site => field ??= new Site(_rawClient, _server);

    public Tags Tags => field ??= new Tags(_rawClient, _server);

    public Topics Topics => field ??= new Topics(_rawClient, _server);

    public Uploads Uploads => field ??= new Uploads(_rawClient, _server);

    public Users Users => field ??= new Users(_rawClient, _server);
}
