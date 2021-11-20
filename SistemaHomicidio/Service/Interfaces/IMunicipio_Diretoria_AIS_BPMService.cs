using Infra.CrossCutting.ViewModels.Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IMunicipio_Diretoria_AIS_BPMService
    {
        Task<IEnumerable<Exibir_Municipio_Diretoria_AIS_BPM>> GetAll();
    }
}
