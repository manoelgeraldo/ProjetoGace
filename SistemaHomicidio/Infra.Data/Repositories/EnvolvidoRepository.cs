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
    public class EnvolvidoRepository : IEnvolvidoRepository
    {
        #region Contexto
        private readonly DataBase _db;

        public EnvolvidoRepository(DataBase db)
        {
            _db = db;
        }
        #endregion

        public async Task<List<Envolvido>> ExibirTodosEnvolvidos()
        {
            return await _db.Envolvidos.AsNoTracking()
                                       .Include(c => c.Criminal)
                                       .Include(e => e.Endereco)
                                       .Include(s => s.Saude)
                                       .ToListAsync();
        }

        public async Task<Envolvido> ObterEnvolvidoPeloId(int id)
        {
            return await _db.Envolvidos.SingleOrDefaultAsync(i => i.Id == id);
        }

        public async Task<Envolvido> ObterEnvolvidoPeloNome(string nome)
        {
            return await _db.Envolvidos.SingleOrDefaultAsync(n => n.NomeEnvolvido == nome);
        }

        public async Task<Envolvido> AdicionarEnvolvido(Envolvido envolvido)
        {
            await _db.Envolvidos.AddAsync(envolvido);
            await _db.SaveChangesAsync();
            return envolvido;
        }

        public async Task<Envolvido> EditarEnvolvido(Envolvido envolvido)
        {
            var verificaEnvolvido = await _db.Envolvidos.SingleOrDefaultAsync(i => i.Id == envolvido.Id);

            if (verificaEnvolvido == null) { return null; }

            _db.Entry(verificaEnvolvido).CurrentValues.SetValues(envolvido);
            await _db.SaveChangesAsync();
            return verificaEnvolvido;
        }

        public async Task<Envolvido> ExcluirEnvolvido(int id)
        {
            var verificaEnvolvido = await _db.Envolvidos.FindAsync(id);

            if (verificaEnvolvido == null) { return null; }

            var envolvidoExcluido = _db.Envolvidos.Remove(verificaEnvolvido);
            await _db.SaveChangesAsync();
            return envolvidoExcluido.Entity;
        }
    }
}
