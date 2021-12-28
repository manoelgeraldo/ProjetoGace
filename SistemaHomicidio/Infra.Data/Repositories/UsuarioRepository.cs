using Domain.Entities;
using Infra.Data.Contexto;
using Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DataBase db;

        public UsuarioRepository(DataBase db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<Usuario>> GetAllUsersAsync()
        {
            return await db.USUARIOS.AsNoTracking()
                                    .ToListAsync()
                                    .ConfigureAwait(false);
        }

        public async Task<Usuario> GetAsync(string login)
        {
            return await db.USUARIOS.AsNoTracking()
                                    .SingleOrDefaultAsync(x => x.Login == login)
                                    .ConfigureAwait(false);
        }

        public async Task<Usuario> InsertAsync(Usuario usuario)
        {
            var verificaUsuario = await GetAsync(usuario.Login);

            if (verificaUsuario == null)
            {
                //await InsertUsuarioFuncaoAsync(usuario).ConfigureAwait(false);
                await db.USUARIOS.AddAsync(usuario).ConfigureAwait(false);
                await db.SaveChangesAsync().ConfigureAwait(false);
                return usuario;
            }

            return null;
        }

        //private async Task InsertUsuarioFuncaoAsync(Usuario usuario)
        //{
        //    var funcoesConsultas = new List<Funcao>();
        //    foreach (var funcao in usuario.Funcoes)
        //    {
        //        var funcaoConsultada = await db.FUNCOES.FindAsync(funcao.Id).ConfigureAwait(false);
        //        funcoesConsultas.Add(funcaoConsultada);
        //    }
        //    usuario.Funcoes = funcoesConsultas;
        //}

        public async Task<Usuario> UpdateAsync(Usuario usuario)
        {
            var usuarioConsultado = await db.USUARIOS.FindAsync(usuario.Login).ConfigureAwait(false);
            if (usuarioConsultado == null)
            {
                return null;
            }
            db.Entry(usuarioConsultado).CurrentValues.SetValues(usuario);
            await db.SaveChangesAsync().ConfigureAwait(false);
            return usuarioConsultado;
        }

        public async Task<Usuario> DeleteAsync(string login)
        {
            var usuarioConsultado = await db.USUARIOS.FindAsync(login).ConfigureAwait(false);

            if (usuarioConsultado != null)
            {
                var usuarioExcluido = db.USUARIOS.Remove(usuarioConsultado);
                await db.SaveChangesAsync().ConfigureAwait(false);
                return usuarioExcluido.Entity;
            }
            return null;
        }
    }
}
