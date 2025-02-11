using orbis.iim.core.Requests.Account;
using orbis.iim.core.Responses;

namespace orbis.iim.core.Handlers;

public interface IAccountHandler
{
    Task<Response<string>> LoginAsync(LoginRequest request);

    Task<Response<string>> RegisterAsync(RegisterRequest request);
    Task LogoutAsync();
}