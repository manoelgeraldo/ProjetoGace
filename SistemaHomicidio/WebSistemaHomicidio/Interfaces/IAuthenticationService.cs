using System.Threading.Tasks;
using WebSistemaHomicidio.ViewModels.Usuario;

namespace WebSistemaHomicidio.Interfaces
{
    public interface IAuthenticationService
    {
        ExibirUsuario Usuario { get; }
        Task Initialize();
        Task Logout();
        Task<ExibirUsuario> Login(UsuarioLogin usuarioLogin);
    }
}
