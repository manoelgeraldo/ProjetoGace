using AutoMapper;
using Domain.Entities;
using Infra.CrossCutting.ViewModels.Usuario;
using Infra.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository repository;
        private readonly IMapper mapper;
        private readonly IJWTService jwt;

        public UsuarioService(IUsuarioRepository repository, IMapper mapper, IJWTService jwt)
        {
            this.repository = repository;
            this.mapper = mapper;
            this.jwt = jwt;
        }

        public async Task<IEnumerable<ExibirUsuario>> GetAllUsersAsync()
        {
            return mapper.Map<IEnumerable<Usuario>, IEnumerable<ExibirUsuario>>(await repository.GetAllUsersAsync().ConfigureAwait(false));
        }

        public async Task<ExibirUsuario> GetAsync(string login)
        {
            return mapper.Map<ExibirUsuario>(await repository.GetAsync(login).ConfigureAwait(false));
        }

        public async Task<UsuarioLogado> GetUsuarioLogadoAsync(string login)
        {
            return mapper.Map<UsuarioLogado>(await repository.GetAsync(login).ConfigureAwait(false));
        }

        public async Task<ExibirUsuario> InsertAsync(NovoUsuario novoUsuario)
        {
            var usuario = mapper.Map<Usuario>(novoUsuario);
            ConverteSenhaEmHash(usuario);
            return mapper.Map<ExibirUsuario>(await repository.InsertAsync(usuario).ConfigureAwait(false));
        }

        private static void ConverteSenhaEmHash(Usuario usuario)
        {
            var passwordHasher = new PasswordHasher<Usuario>();
            usuario.Senha = passwordHasher.HashPassword(usuario, usuario.Senha);
        }

        public async Task<ExibirUsuario> UpdateUsuarioAsync(AlterarUsuario alterarUsuario)
        {
            var usuario = await repository.GetAsync(alterarUsuario.Login);
            usuario.Nome = alterarUsuario.Nome;
            usuario.Senha = alterarUsuario.Senha;
            ConverteSenhaEmHash(usuario);
            return mapper.Map<ExibirUsuario>(await repository.UpdateAsync(usuario).ConfigureAwait(false));
        }

        public async Task<ExibirUsuario> ValidaUsuarioEGeraTokenAsync(UsuarioLogin usuario)
        {
            var usuarioConsultado = await repository.GetAsync(usuario.Login).ConfigureAwait(false);
            if (usuarioConsultado == null)
            {
                return null;
            }
            if (await ValidaEAtualizaHashAsync(usuario, usuarioConsultado.Senha))
            {
                var usuarioLogado = mapper.Map<ExibirUsuario>(usuarioConsultado);
                usuarioLogado.Token = jwt.GerarToken(usuarioConsultado);
                return usuarioLogado;
            }
            return null;
        }

        private async Task<bool> ValidaEAtualizaHashAsync(UsuarioLogin usuario, string hash)
        {
            var usuarioConsultado = await repository.GetAsync(usuario.Login).ConfigureAwait(false);
            var passwordHasher = new PasswordHasher<Usuario>();
            var status = passwordHasher.VerifyHashedPassword(usuarioConsultado, hash, usuario.Senha);
            var usuarioAlterado = mapper.Map<AlterarUsuario>(usuarioConsultado);
            switch (status)
            {
                case PasswordVerificationResult.Failed:
                    return false;

                case PasswordVerificationResult.Success:
                    return true;

                case PasswordVerificationResult.SuccessRehashNeeded:
                    await UpdateUsuarioAsync(usuarioAlterado).ConfigureAwait(false);
                    return true;

                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
