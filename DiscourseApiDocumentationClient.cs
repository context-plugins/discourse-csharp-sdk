using System.Net.Http;
using DiscourseApiDocumentation.Api;
using DiscourseApiDocumentation.Core;
using DiscourseApiDocumentation.Core.Logging;
using DiscourseApiDocumentation.Core.Models;

namespace DiscourseApiDocumentation;

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
public sealed class DiscourseApiDocumentationClient
{
    public DiscourseApiDocumentationClient(HttpClient httpClient, DiscourseApiDocumentationClientOptions options)
    {
        var server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory =
            new HeadersFactory([new HeaderParam("User-Agent", "DiscourseApiDocumentationClient/latest CSharp"),
                    new HeaderParam("X-APIMatic-Lang", "CSharp"),
                    new HeaderParam("X-APIMatic-Package-Version", "latest"),
                    new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
                    new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
                    new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime)]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry);
        var httpLogger = new HttpLogger(options.Logging, "DiscourseApiDocumentationClient");
        var rawClient =
            new RawClient(httpClient, urlFactory, httpStatusPolicy, headersFactory, resiliencePipelineFactory, httpLogger);
        Admin = new Admin(rawClient, server);
        Backups = new Backups(rawClient, server);
        Badges = new Badges(rawClient, server);
        Categories = new Categories(rawClient, server);
        DiscourseCalendarEvents = new DiscourseCalendarEvents(rawClient, server);
        Groups = new Groups(rawClient, server);
        Invites = new Invites(rawClient, server);
        Notifications = new Notifications(rawClient, server);
        Posts = new Posts(rawClient, server);
        PrivateMessages = new PrivateMessages(rawClient, server);
        Search = new Search(rawClient, server);
        Site = new Site(rawClient, server);
        Tags = new Tags(rawClient, server);
        Topics = new Topics(rawClient, server);
        Uploads = new Uploads(rawClient, server);
        Users = new Users(rawClient, server);
    }

    public Admin Admin { get; }

    public Backups Backups { get; }

    public Badges Badges { get; }

    public Categories Categories { get; }

    public DiscourseCalendarEvents DiscourseCalendarEvents { get; }

    public Groups Groups { get; }

    public Invites Invites { get; }

    public Notifications Notifications { get; }

    public Posts Posts { get; }

    public PrivateMessages PrivateMessages { get; }

    public Search Search { get; }

    public Site Site { get; }

    public Tags Tags { get; }

    public Topics Topics { get; }

    public Uploads Uploads { get; }

    public Users Users { get; }
}
