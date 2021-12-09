using Infra.CrossCutting.ViewModels.Usuario;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IUsuarioService
    {
        Task<IEnumerable<ExibirUsuario>> GetAllUsersAsync();

        Task<ExibirUsuario> GetAsync(string login);

        Task<UsuarioLogado> GetUsuarioLogadoAsync(string login);

        Task<ExibirUsuario> InsertAsync(NovoUsuario usuario);

        Task<ExibirUsuario> UpdateUsuarioAsync(AlterarUsuario alterarUsuario);

        Task<ExibirUsuario> ValidaUsuarioEGeraTokenAsync(UsuarioLogin login);

        Task<ExibirUsuario> ExcluirUsuario(string login);
    }
}
