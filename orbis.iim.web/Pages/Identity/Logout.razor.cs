using orbis.iim.core.Handlers;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using orbis.iim.web.Security;

namespace orbis.iim.web.Pages.Identity;

public partial class LogoutPage : ComponentBase
{
    #region Services

    [Inject]
    public ISnackbar Snackbar { get; set; } = null!;

    [Inject]
    public IAccountHandler Handler { get; set; } = null!;

    [Inject]
    public NavigationManager NavigationManager { get; set; } = null!;

    [Inject]
    public ICookieAuthenticationStateProvider AuthenticationStateProvider { get; set; } = null!;

    #endregion

    #region Overrides

    protected override async Task OnInitializedAsync()
    {
        if (await AuthenticationStateProvider.CheckAuthenticatedAsync())
        {
            await Handler.LogoutAsync();
            await AuthenticationStateProvider.GetAuthenticationStateAsync();
            AuthenticationStateProvider.NotifyAuthenticationStateChanged();
        }

        await base.OnInitializedAsync();
        NavigationManager.NavigateTo("/login", true);
    }

    #endregion
}