using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Data.Interfaces
{
    public interface IRegistroRepository
    {
        Task<List<Registro>> ExibirTodosRegistros();
        Task<Registro> ObterRegistroPorID(int id);
        Task<Registro> AdicionarRegistro(Registro registro);
        Task<Registro> EditarRegistro(Registro registro);
        Task<Registro> ExcluirRegistro(int id);
    }
}
