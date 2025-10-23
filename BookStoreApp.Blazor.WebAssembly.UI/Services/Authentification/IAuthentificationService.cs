using BookStoreApp.Blazor.WebAssembly.UI.Services.Base;

namespace BookStoreApp.Blazor.WebAssembly.UI.Services.Authentification
{
    public interface IAuthentificationService
    {
        Task<bool> AuthentificateAsync(LoginUserDto loginModel);
        public Task Logout();
    }
}
