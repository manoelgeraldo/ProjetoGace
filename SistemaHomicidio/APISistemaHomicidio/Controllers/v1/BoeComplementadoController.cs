using Infra.CrossCutting.ViewModels.Boe;
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
    public class BoeComplementadoController : Controller
    {
        private readonly IBoeComplementadoService _boeComplementadoService;

        public BoeComplementadoController(IBoeComplementadoService boeComplementadoService)
        {
            _boeComplementadoService = boeComplementadoService;
        }

        /// <summary>
        /// Exibe uma lista com todos os BOEs Complementados
        /// </summary>
        [HttpGet("lista-de-boes-complementados")]
        [ProducesResponseType(typeof(ExibirBoeComplementado), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get()
        {
            var ExibirTodosBoeComplementados = await _boeComplementadoService.ExibirTodosBoeComplementado();

            if (ExibirTodosBoeComplementados.Any())
            {
                return Ok(ExibirTodosBoeComplementados);
            }
            return NotFound();
        }

        /// <summary>
        /// Exibe um BOE Complementado consultado pelo id
        /// </summary>
        /// <param name="id" example="2"> BOE Complementado</param>
        [HttpGet("buscar-boe-Complementado/{id}")]
        [ProducesResponseType(typeof(ExibirBoeComplementado), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get(int id)
        {
            var boeComplementado = await _boeComplementadoService.ObterBoeComplementadoPorID(id);

            if (boeComplementado.Id == 0)
            {
                return NotFound();
            }

            return Ok(boeComplementado);
        }

        /// <summary>
        /// Exibe BOE Complementado consultado pelo RegistroId
        /// </summary>
        /// <param name="id" example="2"> RegistroId</param>
        [HttpGet("buscar-boe-Complementado-por-registro/{id}")]
        [ProducesResponseType(typeof(ExibirBoeComplementado), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetByRegistroId(int id)
        {
            var boeComplementado = await _boeComplementadoService.ObterBoeComplementadoPorRegistroID(id);

            if (boeComplementado.Id == 0)
            {
                return NotFound();
            }

            return Ok(boeComplementado);
        }

        /// <summary>
        /// Adiciona um novo BOE Complementado
        /// </summary>
        /// <param name="novoBoeComplementado"></param>
        [HttpPost("novo-boe-complementado")]
        [ProducesResponseType(typeof(ExibirBoeComplementado), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post(NovoBoe novoBoeComplementado)
        {
            ExibirBoeComplementado boeComplementadoInserido;
            boeComplementadoInserido = await _boeComplementadoService.AdicionarBoeComplementado(novoBoeComplementado);
            return CreatedAtAction(nameof(Get), new { id = boeComplementadoInserido.Id }, boeComplementadoInserido);
        }

        /// <summary>
        /// Altera um BOE Complementado
        /// </summary>
        /// <param name="alterarBoeComplementado"></param>
        [HttpPut("alterar-boe-complementado/{id}")]
        [ProducesResponseType(typeof(ExibirBoeComplementado), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Put(AlterarBoe alterarBoeComplementado)
        {
            var boeComplementadoAtualizado = await _boeComplementadoService.EditarBoeComplementado(alterarBoeComplementado);
            if (boeComplementadoAtualizado == null)
            {
                return NotFound();
            }
            return Ok(boeComplementadoAtualizado);
        }

        /// <summary>
        /// Exclui um BOE Complementado
        /// </summary>
        /// <param name="id" example="2">Id do BOE Complementado</param>
        /// <remarks>Ao excluir um BOE Complementado o mesmo será removido permanentemente da base!</remarks>
        [HttpDelete("excluir-boe-complementado/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(int id)
        {
            var boeComplementadoExcluido = await _boeComplementadoService.ExcluirBoeComplementado(id);
            if (boeComplementadoExcluido == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
