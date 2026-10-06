using System.Threading;
using System.Threading.Tasks;
using Discourse.Core.Models;

namespace Discourse.Core.ErrorResponse;

internal interface IErrorResponse<TError>
{
    Task<TError> Map(ResponseContext context, CancellationToken cancellationToken);
}