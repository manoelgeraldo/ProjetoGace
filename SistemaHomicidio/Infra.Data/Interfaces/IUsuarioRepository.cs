using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Data.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> GetAllUsersAsync();

        Task<Usuario> GetAsync(string login);

        Task<Usuario> InsertAsync(Usuario usuario);

        Task<Usuario> UpdateAsync(Usuario usuario);

        Task<Usuario> DeleteAsync(string login);
    }
}