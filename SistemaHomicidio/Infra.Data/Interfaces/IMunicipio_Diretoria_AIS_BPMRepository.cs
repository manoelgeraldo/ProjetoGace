using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Interfaces
{
    public interface IMunicipio_Diretoria_AIS_BPMRepository
    {
        Task<IEnumerable<Municipio_Diretoria_AIS_BPM>> GetAll();
    }
}
