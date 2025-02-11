using orbis.iim.api.Common.Api;
using orbis.iim.core.Handlers;
using orbis.iim.core.Models;
using orbis.iim.core.Requests.Transactions;
using orbis.iim.core.Responses;
using System.Security.Claims;

namespace orbis.iim.api.Endpoints.Transactions;

public class UpdateTransactionEndpoint : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app)
        => app.MapPut("/{id}", HandleAsync)
            .WithName("Transactions: Update")
            .WithSummary("Atualiza uma transação")
            .WithDescription("Atualiza uma transação")
            .WithOrder(2)
            .Produces<Response<Transaction?>>();

    private static async Task<IResult> HandleAsync(
        ClaimsPrincipal user,
        ITransactionHandler handler,
        UpdateTransactionRequest request,
        long id)
    {
        request.UserId = user.Identity?.Name ?? string.Empty;
        request.Id = id;

        var result = await handler.UpdateAsync(request);
        return result.IsSuccess
            ? TypedResults.Ok(result)
            : TypedResults.BadRequest(result);
    }
}