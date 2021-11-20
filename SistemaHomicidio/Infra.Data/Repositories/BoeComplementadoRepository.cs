using Domain.Entities;
using Infra.Data.Contexto;
using Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class BoeComplementadoRepository : IBoeComplementadoRepository
    {
        #region Contexto
        private readonly DataBase _db;

        public BoeComplementadoRepository(DataBase db)
        {
            _db = db;
        }
        #endregion

        public async Task<List<BoeComplementado>> ExibirTodosBoeComplementado()
        {
            return await _db.BoeComplementados.AsNoTracking().ToListAsync();
        }

        public async Task<BoeComplementado> ObterBoeComplementadoPeloId(int id)
        {
            return await _db.BoeComplementados.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<BoeComplementado> ObterBoeComplementadoPeloRegistroId(int id)
        {
            return await _db.BoeComplementados.SingleOrDefaultAsync(x => x.RegistroId == id);
        }

        public async Task<BoeComplementado> AdicionarBoeComplementado(BoeComplementado boeComplementado)
        {
            await _db.BoeComplementados.AddAsync(boeComplementado);
            await _db.SaveChangesAsync();
            return boeComplementado;
        }

        public async Task<BoeComplementado> EditarBoeComplementado(BoeComplementado boeComplementado)
        {
            var verificaBoeComplementado = await _db.BoeComplementados.SingleOrDefaultAsync(x => x.Id == boeComplementado.Id);
            
            if (verificaBoeComplementado == null) { return null; }
            
            _db.Entry(verificaBoeComplementado).CurrentValues.SetValues(boeComplementado);
            await _db.SaveChangesAsync();
            return verificaBoeComplementado;
        }

        public async Task<BoeComplementado> ExcluirBoeComplementado(int id)
        {
            var verificaBoeComplementado = await _db.BoeComplementados.FindAsync(id);

            if (verificaBoeComplementado == null) { return null; }

            var boeExcluido = _db.BoeComplementados.Remove(verificaBoeComplementado);
            await _db.SaveChangesAsync();
            return boeExcluido.Entity;
        }

    }
}
