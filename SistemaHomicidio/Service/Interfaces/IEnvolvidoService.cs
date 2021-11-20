using Infra.CrossCutting.ViewModels.Envolvido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IEnvolvidoService
    {
        Task<List<ExibirEnvolvido>> ExibirTodosEnvolvidos();
        Task<ExibirEnvolvido> ObterEnvolvidoPorID(int id);
        Task<ExibirEnvolvido> AdicionarEnvolvido(NovoEnvolvido novoEnvolvido);
        Task<ExibirEnvolvido> EditarEnvolvido(AlterarEnvolvido alterarEnvolvido);
        Task<ExibirEnvolvido> ExcluirEnvolvido(int id);
        Task<ExibirEnvolvido> ObterEnvolvidoPeloNome(string nome);
    }
}
