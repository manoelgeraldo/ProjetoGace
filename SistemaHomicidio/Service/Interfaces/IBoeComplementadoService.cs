using Infra.CrossCutting.ViewModels.Boe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IBoeComplementadoService
    {
        Task<List<ExibirBoeComplementado>> ExibirTodosBoeComplementado();
        Task<ExibirBoeComplementado> ObterBoeComplementadoPorID(int id);
        Task<ExibirBoeComplementado> AdicionarBoeComplementado(NovoBoe NovoBoeComplementado);
        Task<ExibirBoeComplementado> EditarBoeComplementado(AlterarBoe AlteraBoeComplementado);
        Task<ExibirBoeComplementado> ExcluirBoeComplementado(int id);
        Task<ExibirBoeComplementado> ObterBoeComplementadoPorRegistroID(int id);
    }
}
