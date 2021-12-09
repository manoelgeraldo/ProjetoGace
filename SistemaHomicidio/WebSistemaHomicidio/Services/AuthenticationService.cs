using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using WebSistemaHomicidio.Interfaces;
using WebSistemaHomicidio.ViewModels.Usuario;

namespace WebSistemaHomicidio.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IHttpService httpService;
        private readonly ILocalStorageService localStorage;
        private readonly NavigationManager navigationManager;

        public AuthenticationService(IHttpService httpService, ILocalStorageService localStorage, NavigationManager navigationManager)
        {
            this.httpService = httpService;
            this.localStorage = localStorage;
            this.navigationManager = navigationManager;
        }

        public ExibirUsuario Usuario { get; private set; }

        public async Task Initialize()
        {
            Usuario = await localStorage.GetItemAsync<ExibirUsuario>("usuario").ConfigureAwait(false);
        }

        public async Task<ExibirUsuario> Login(UsuarioLogin usuarioLogin)
        {
            Usuario = await httpService.Post<ExibirUsuario>("https://localhost:44315/api/Usuarios/login", usuarioLogin).ConfigureAwait(false);
            return Usuario;
        }

        public async Task Logout()
        {
            Usuario = null;
            await localStorage.RemoveItemAsync("usuario").ConfigureAwait(false);
            navigationManager.NavigateTo("login");
        }
    }
}
