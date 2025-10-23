using Blazored.LocalStorage;
using BookStoreApp.Blazor.WebAssembly.UI.Providers;
using BookStoreApp.Blazor.WebAssembly.UI.Services.Base;
using Microsoft.AspNetCore.Authorization;

namespace BookStoreApp.Blazor.WebAssembly.UI.Services.Authentification
{
    public class AuthentificationService : IAuthentificationService
    {
        private readonly IClient httpClient;
        private readonly ILocalStorageService localStorage;
        private readonly AuthenticationStateProvider authentificationStateProvider;

        public AuthentificationService(IClient httpClient, ILocalStorageService localStorage, AuthenticationStateProvider authentificationStateProvider)
        {
            this.httpClient = httpClient;
            this.localStorage = localStorage;
            this.authentificationStateProvider = authentificationStateProvider;
        }
        public async Task<bool> AuthentificateAsync(LoginUserDto loginModel)
        {
            var response = await httpClient.LoginAsync(loginModel);

            // Store Token
            await localStorage.SetItemAsync("accessToken", response.Token);

            // Change auth state of app
            await ((ApiAuthenticationStateProvider)authentificationStateProvider).LoggedIn();

            return true;
        }

        public async Task Logout()
        {
            await ((ApiAuthenticationStateProvider)authentificationStateProvider).LoggedOut();
        }
    }
}
