using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Interfaces
{
    public interface IBoeComplementadoRepository
    {
        Task<List<BoeComplementado>> ExibirTodosBoeComplementado();
        Task<BoeComplementado> ObterBoeComplementadoPeloId(int id);
        Task<BoeComplementado> AdicionarBoeComplementado(BoeComplementado boeComplementado);
        Task<BoeComplementado> EditarBoeComplementado(BoeComplementado boeComplementado);
        Task<BoeComplementado> ExcluirBoeComplementado(int id);
        Task<List<BoeComplementado>> ObterBoeComplementadoPeloRegistroId(int id);
    }
}
