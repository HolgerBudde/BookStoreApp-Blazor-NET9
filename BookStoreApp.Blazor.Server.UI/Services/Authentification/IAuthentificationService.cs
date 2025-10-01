using BookStoreApp.Blazor.Server.UI.Services.Base;

namespace BookStoreApp.Blazor.Server.UI.Services.Authentification
{
    public interface IAuthentificationService
    {
        Task<bool> AuthentificateAsync(LoginUserDto loginModel);
        public Task Logout();
    }
}
