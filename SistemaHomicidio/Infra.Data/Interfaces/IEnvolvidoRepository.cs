using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Interfaces
{
    public interface IEnvolvidoRepository
    {
        Task<List<Envolvido>> ExibirTodosEnvolvidos();
        Task<Envolvido> ObterEnvolvidoPeloId(int id);
        Task<Envolvido> AdicionarEnvolvido(Envolvido envolvido);
        Task<Envolvido> EditarEnvolvido(Envolvido envolvido);
        Task<Envolvido> ExcluirEnvolvido(int id);
        Task<Envolvido> ObterEnvolvidoPeloNome(string nome);
    }
}
