using orbis.iim.api.Common.Api;
using orbis.iim.core.Handlers;
using orbis.iim.core.Models;
using orbis.iim.core.Requests.Categories;
using orbis.iim.core.Responses;
using System.Security.Claims;

namespace orbis.iim.api.Endpoints.Categories
{
    public class CreateCategoryEndpoint : IEndpoint
    {
        public static void Map(IEndpointRouteBuilder app)
        => app.MapPost("/", HandleAsync)
            .WithName("Categories: Create")
            .WithSummary("Cria uma nova categoria")
            .WithDescription("Cria uma nova categoria")
            .WithOrder(1)
            .Produces<Response<Category?>>();
        private static async Task<IResult> HandleAsync(
            ClaimsPrincipal user,
            ICategoryHandler handler,
            CreateCategoryRequest request)
        {
            request.UserId = user.Identity?.Name ?? string.Empty;
            var result = await handler.CreateAsync(request);
            return result.IsSuccess
                ? TypedResults.Created($"/{result.Data?.Id}", result)
                : TypedResults.BadRequest(result.Data);
        }
    }
}
