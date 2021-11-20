using Infra.CrossCutting.ViewModels.Envolvido;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISistemaHomicidio.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EnvolvidoController : Controller
    {
        private IEnvolvidoService _envolvidoService;

        public EnvolvidoController(IEnvolvidoService envolvidoService)
        {
            _envolvidoService = envolvidoService;
        }

        /// <summary>
        /// Exibe uma lista com todos os Envolvidos
        /// </summary>
        [HttpGet("lista-de-envolvidos")]
        [ProducesResponseType(typeof(ExibirEnvolvido), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get()
        {
            var ExibirTodosEnvolvidos = await _envolvidoService.ExibirTodosEnvolvidos();

            if (ExibirTodosEnvolvidos.Any())
            {
                return Ok(ExibirTodosEnvolvidos);
            }
            return NotFound();
        }

        /// <summary>
        /// Exibe um Envolvido consultado pelo id
        /// </summary>
        /// <param name="id" example="2">Envolvido</param>
        [HttpGet("buscar-envolvido/{id}")]
        [ProducesResponseType(typeof(ExibirEnvolvido), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get(int id)
        {
            var envolvido = await _envolvidoService.ObterEnvolvidoPorID(id);

            if (envolvido.Id == 0)
            {
                return NotFound();
            }

            return Ok(envolvido);
        }

        /// <summary>
        /// Exibe um Envolvido consultado pelo nome
        /// </summary>
        /// <param name="nome" example="Fulano de tal">Envolvido</param>
        [HttpGet("buscar-envolvido-pelo-nome/{nome}")]
        [ProducesResponseType(typeof(ExibirEnvolvido), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetByName(string nome)
        {
            var nomeEnvolvido = await _envolvidoService.ObterEnvolvidoPeloNome(nome);

            if (nomeEnvolvido.Id == 0)
            {
                return NotFound();
            }

            return Ok(nomeEnvolvido);
        }

        /// <summary>
        /// Adiciona um novo Envolvido
        /// </summary>
        /// <param name="novoEnvolvido"></param>
        [HttpPost("novo-envolvido")]
        [ProducesResponseType(typeof(ExibirEnvolvido), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post(NovoEnvolvido novoEnvolvido)
        {
            ExibirEnvolvido envolvidoInserido;
            envolvidoInserido = await _envolvidoService.AdicionarEnvolvido(novoEnvolvido);
            return CreatedAtAction(nameof(Get), new { id = envolvidoInserido.Id }, envolvidoInserido);
        }

        /// <summary>
        /// Altera um Envolvido existente
        /// </summary>
        /// <param name="alterarEnvolvido"></param>
        [HttpPut("alterar-envolvido/{id}")]
        [ProducesResponseType(typeof(ExibirEnvolvido), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Put(AlterarEnvolvido alterarEnvolvido)
        {
            var envolvidoAtualizado = await _envolvidoService.EditarEnvolvido(alterarEnvolvido);
            if (envolvidoAtualizado == null)
            {
                return NotFound();
            }
            return Ok(envolvidoAtualizado);
        }

        /// <summary>
        /// Exclui um Envolvido
        /// </summary>
        /// <param name="id" example="2">Id do Envolvido</param>
        /// <remarks>Ao excluir um Envolvido o mesmo será removido permanentemente da base!</remarks>
        [HttpDelete("excluir-envolvido/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(int id)
        {
            var envolvidoExcluido = await _envolvidoService.ExcluirEnvolvido(id);
            if (envolvidoExcluido == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
