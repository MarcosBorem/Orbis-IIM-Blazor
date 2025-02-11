using orbis.iim.api.Common.Api;
using orbis.iim.api.Endpoints.Categories;
using orbis.iim.api.Endpoints.Identity;
using orbis.iim.api.Endpoints.Transactions;
using orbis.iim.api.Models;

namespace orbis.iim.api.Endpoints
{
    public static class Endpoint
    {
        public static void MapEndpoints(this WebApplication app)
        {
            //Grupo de rotas
            var endpoints = app
                .MapGroup("");

            endpoints.MapGroup("/")
           .WithTags("Health Check")
           .MapGet("/", () => new { message = "OK" });

            endpoints.MapGroup("v1/categories")
                .WithTags("Categories")
                .RequireAuthorization()
                .MapEndpoint<CreateCategoryEndpoint>()
                .MapEndpoint<UpdateCategoryEndpoint>()
                .MapEndpoint<DeleteCategoryEndpoint>()
                .MapEndpoint<GetCategoryByIdEndpoint>()
                .MapEndpoint<GetAllCategoriesEndpoint>();

            endpoints.MapGroup("v1/transactions")
                .WithTags("Transactions")
                .RequireAuthorization()
                .MapEndpoint<CreateTransactionEndpoint>()
                .MapEndpoint<UpdateTransactionEndpoint>()
                .MapEndpoint<DeleteTransactionEndpoint>()
                .MapEndpoint<GetTransactionByIdEndpoint>()
                .MapEndpoint<GetTransactionsByPeriodEndpoint>();

            endpoints.MapGroup("v1/identity")
                .WithTags("Identity")
                .MapIdentityApi<User>();

            endpoints.MapGroup("v1/identity")
                .WithTags("Identity")
                .MapEndpoint<LogoutEndpoint>()
                .MapEndpoint<GetRolesEndpoint>();

        }

        private static IEndpointRouteBuilder MapEndpoint<TEndpoint>(this IEndpointRouteBuilder app)
            where TEndpoint : IEndpoint
        {
            TEndpoint.Map(app);
            return app;
        }
    }
}
