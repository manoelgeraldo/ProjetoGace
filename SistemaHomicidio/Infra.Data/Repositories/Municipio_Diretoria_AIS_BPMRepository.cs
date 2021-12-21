using Domain.Entities;
using Infra.Data.Contexto;
using Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class Municipio_Diretoria_AIS_BPMRepository : IMunicipio_Diretoria_AIS_BPMRepository
    {
        #region Contexto
        private readonly DataBase db;

        public Municipio_Diretoria_AIS_BPMRepository(DataBase _db)
        {
            db = _db;
        }
        #endregion

        public async Task<IEnumerable<Municipio_Diretoria_AIS_BPM>> GetAll()
        {
            return await db.MUNICIPIOS.AsNoTracking()
                                      .OrderBy(m => m.Municipio)
                                      .ToListAsync()
                                      .ConfigureAwait(false);
        }
    }
}
