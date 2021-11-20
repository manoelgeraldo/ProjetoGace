using Infra.CrossCutting.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISistemaHomicidio.Controllers.v1
{
    [Authorize]
    [ApiController]
    [Route("api/v1/[controller]")]
    public class RegistroController : ControllerBase
    {
        private readonly IRegistroService _registroService;

        public RegistroController(IRegistroService registroService)
        {
            _registroService = registroService;
        }

        /// <summary>
        /// Exibe uma lista com todos os registros
        /// </summary>
        [HttpGet("lista-de-registros")]
        [ProducesResponseType(typeof(ExibirRegistro), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get()
        {
            var ExibirTodosResgistros = await _registroService.ExibirTodosRegistros();
            
            if (ExibirTodosResgistros.Any())
            {
                return Ok(ExibirTodosResgistros);
            }
            return NotFound("Base sem Registros");
        }

        /// <summary>
        /// Exibe um Registro consultado pelo id
        /// </summary>
        /// <param name="id" example="2">Registro</param>
        [HttpGet("buscar-registro/{id}")]
        [ProducesResponseType(typeof(AlterarRegistro), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get(int id)
        {
            var registro = await _registroService.ExibirRegistroPorId(id);

            if (registro.Id == 0)
            {
                return NotFound();
            }
            
            return Ok(registro);
        }

        /// <summary>
        /// Adiciona um novo registro
        /// </summary>
        /// <param name="novoRegistro"></param>
        [HttpPost("novo-registro")]
        [ProducesResponseType(typeof(ExibirRegistro), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post(NovoRegistro novoRegistro)
        {
            ExibirRegistro registroInserido;
            registroInserido = await _registroService.AdicionarRegistro(novoRegistro);
            return CreatedAtAction(nameof(Get), new { id = registroInserido.Id }, registroInserido);
        }

        /// <summary>
        /// Altera um registro existente
        /// </summary>
        /// <param name="alterarRegistro"></param>
        [HttpPut("alterar-registro/{id}")]
        [ProducesResponseType(typeof(ExibirRegistro), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Put(AlterarRegistro alterarRegistro)
        {
            var registroAtualizado = await _registroService.EditarRegistro(alterarRegistro);
            if (registroAtualizado == null)
            {
                return NotFound();
            }
            return Ok(registroAtualizado);
        }

        /// <summary>
        /// Exclui um registro
        /// </summary>
        /// <param name="id" example="2">Id do registro</param>
        /// <remarks>Ao excluir um registro o mesmo será removido permanentemente da base!</remarks>
        [HttpDelete("excluir-registro/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(int id)
        {
            var registroExcluido = await _registroService.ExcluirRegistro(id);
            if (registroExcluido == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
