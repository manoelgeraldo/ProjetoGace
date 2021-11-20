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
                                         .ToListAsync();
        }

        public async Task<Usuario> GetAsync(string login)
        {
            return await context.Usuarios
                                .Include(f => f.Funcoes)
                                .AsNoTracking()
                                .SingleOrDefaultAsync(p => p.Login == login);
        }

        public async Task<Usuario> InsertAsync(Usuario usuario)
        {
            var verificaUsuario = await context.Usuarios.SingleOrDefaultAsync(l => l.Login == usuario.Login);

            if(verificaUsuario == null)
            {
                await InsertUsuarioFuncaoAsync(usuario);
                await context.Usuarios.AddAsync(usuario);
                await context.SaveChangesAsync();
                return usuario;
            }

            return null;
        }

        private async Task InsertUsuarioFuncaoAsync(Usuario usuario)
        {
            var funcoesConsultas = new List<Funcao>();
            foreach (var funcao in usuario.Funcoes)
            {
                var funcaoConsultada = await context.Funcoes.FindAsync(funcao.Id);
                funcoesConsultas.Add(funcaoConsultada);
            }
            usuario.Funcoes = funcoesConsultas;
        }

        public async Task<Usuario> UpdateAsync(Usuario usuario)
        {
            var usuarioConsultado = await context.Usuarios.FindAsync(usuario.Login);
            if (usuarioConsultado == null)
            {
                return null;
            }
            context.Entry(usuarioConsultado).CurrentValues.SetValues(usuario);
            await context.SaveChangesAsync();
            return usuarioConsultado;
        }
    }
}
