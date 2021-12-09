using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Data.Interfaces
{
    public interface IMunicipio_Diretoria_AIS_BPMRepository
    {
        Task<IEnumerable<Municipio_Diretoria_AIS_BPM>> GetAll();
    }
}
