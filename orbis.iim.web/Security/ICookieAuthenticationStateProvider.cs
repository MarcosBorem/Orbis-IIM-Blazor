using Microsoft.AspNetCore.Components.Authorization;

namespace orbis.iim.web.Security;

public interface ICookieAuthenticationStateProvider
{
    Task<bool> CheckAuthenticatedAsync();
    Task<AuthenticationState> GetAuthenticationStateAsync();
    void NotifyAuthenticationStateChanged();
}