using Infra.CrossCutting.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IRegistroService
    {
        Task<List<ExibirRegistro>> ExibirTodosRegistros();
        Task<AlterarRegistro> ExibirRegistroPorId(int id);
        Task<ExibirRegistro> AdicionarRegistro(NovoRegistro novoRegistro);
        Task<ExibirRegistro> EditarRegistro(AlterarRegistro alterarRegistro);
        Task<ExibirRegistro> ExcluirRegistro(int id);
    }
}
