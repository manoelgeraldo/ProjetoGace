using Domain.Entities;
using Infra.Data.Contexto;
using Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DataBase context;

        public UsuarioRepository(DataBase context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Usuario>> GetAllUsersAsync()
        {
            return await context.Usuarios.Include(f => f.Funcoes)
                                         .AsNoTracking()
                                         .ToListAsync()
                                         .ConfigureAwait(false);
        }

        public async Task<Usuario> GetAsync(string login)
        {
            return await context.Usuarios
                                .Include(f => f.Funcoes)
                                .AsNoTracking()
                                .SingleOrDefaultAsync(p => p.Login == login)
                                .ConfigureAwait(false);
        }

        public async Task<Usuario> InsertAsync(Usuario usuario)
        {
            var verificaUsuario = await context.Usuarios.SingleOrDefaultAsync(l => l.Login == usuario.Login).ConfigureAwait(false);

            if (verificaUsuario == null)
            {
                await InsertUsuarioFuncaoAsync(usuario).ConfigureAwait(false);
                await context.Usuarios.AddAsync(usuario).ConfigureAwait(false);
                await context.SaveChangesAsync().ConfigureAwait(false);
                return usuario;
            }

            return null;
        }

        private async Task InsertUsuarioFuncaoAsync(Usuario usuario)
        {
            var funcoesConsultas = new List<Funcao>();
            foreach (var funcao in usuario.Funcoes)
            {
                var funcaoConsultada = await context.Funcoes.FindAsync(funcao.Id).ConfigureAwait(false);
                funcoesConsultas.Add(funcaoConsultada);
            }
            usuario.Funcoes = funcoesConsultas;
        }

        public async Task<Usuario> UpdateAsync(Usuario usuario)
        {
            var usuarioConsultado = await context.Usuarios.FindAsync(usuario.Login).ConfigureAwait(false);
            if (usuarioConsultado == null)
            {
                return null;
            }
            context.Entry(usuarioConsultado).CurrentValues.SetValues(usuario);
            await context.SaveChangesAsync().ConfigureAwait(false);
            return usuarioConsultado;
        }

        public async Task<Usuario> DeleteAsync(string login)
        {
            var usuarioConsultado = await context.Usuarios.FindAsync(login).ConfigureAwait(false);

            if (usuarioConsultado != null)
            {
                var usuarioExcluido = context.Usuarios.Remove(usuarioConsultado);
                await context.SaveChangesAsync().ConfigureAwait(false);
                return usuarioExcluido.Entity;
            }
            return null;
        }
    }
}
