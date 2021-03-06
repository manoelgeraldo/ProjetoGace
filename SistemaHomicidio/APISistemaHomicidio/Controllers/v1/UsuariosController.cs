using Infra.CrossCutting.ViewModels.Usuario;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System.Threading.Tasks;

namespace APISistemaHomicidio.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService manager;

        public UsuariosController(IUsuarioService manager)
        {
            this.manager = manager;
        }

        /// <summary>
        /// Efetua o login na API
        /// </summary>
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] UsuarioLogin login)
        {
            var usuarioLogado = await manager.ValidaUsuarioEGeraTokenAsync(login).ConfigureAwait(false);
            if (usuarioLogado != null)
            {
                return Ok(usuarioLogado);
            }
            return Unauthorized("Acesso não autorizado!");
        }

        /// <summary>
        /// Informa o usuário Logado.
        /// </summary>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Get()
        {
            string login = User.Identity.Name;
            var usuario = await manager.GetUsuarioLogadoAsync(login).ConfigureAwait(false);
            return Ok(usuario);
        }

        /// <summary>
        /// Exibe uma lista com todos os usuários.
        /// </summary>
        [HttpGet]
        [Authorize(Roles = "Gestor, Administrador")]
        [Route("lista-de-usuarios")]
        public async Task<IActionResult> GetAllUsers()
        {
            var usuarios = await manager.GetAllUsersAsync().ConfigureAwait(false);
            return Ok(usuarios);
        }

        /// <summary>
        /// Adiciona um novo usuário.
        /// </summary>
        [HttpPost]
        [Authorize(Roles = "Gestor, Administrador")]
        [Route("novo-usuario")]
        public async Task<IActionResult> Post(NovoUsuario usuario)
        {
            var usuarioInserido = await manager.InsertAsync(usuario).ConfigureAwait(false);

            if (usuarioInserido != null)
            {
                return CreatedAtAction(nameof(Get), new { login = usuario.Login }, usuarioInserido);
            }

            return new ObjectResult("Usuário já existe!") { StatusCode = 403 };
        }

        /// <summary>
        /// Altera um usuário existente.
        /// </summary>
        [HttpPut]
        [Authorize]
        [Route("alterar-usuario")]
        public async Task<IActionResult> Put(AlterarUsuario alterarUsuario)
        {
            var usuarioAlterado = await manager.UpdateUsuarioAsync(alterarUsuario).ConfigureAwait(false);
            if (usuarioAlterado is null)
            {
                return NotFound();
            }
            return Ok("Usuário alterado com sucesso!");
        }

        /// <summary>
        /// Exclui um usuário.
        /// </summary>
        /// <param name="login">Id do registro</param>
        /// <remarks>Ao excluir um usuário o mesmo será removido permanentemente da base!</remarks>
        [Authorize(Roles = "Gestor, Administrador")]
        [HttpDelete("excluir-usuario/{login}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(string login)
        {
            var usuarioExcluido = await manager.ExcluirUsuario(login).ConfigureAwait(false);
            if (usuarioExcluido is null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
