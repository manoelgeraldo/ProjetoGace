using Infra.CrossCutting.ViewModels.Auxiliares;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace APISistemaHomicidio.Controllers.v1
{
    [Authorize]
    [ApiController]
    [Route("api/v1/[controller]")]
    public class Municipio_Diretoria_AIS_BPMController : ControllerBase
    {
        private readonly IMunicipio_Diretoria_AIS_BPMService service;

        public Municipio_Diretoria_AIS_BPMController(IMunicipio_Diretoria_AIS_BPMService _service)
        {
            this.service = _service;
        }

        /// <summary>
        /// Exibe uma lista Municipio_Diretoria_AIS_BPM
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(Exibir_Municipio_Diretoria_AIS_BPM), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get()
        {
            var tbl_Municipio_Diretoria_AIS_BPM = await service.GetAll();

            if (tbl_Municipio_Diretoria_AIS_BPM.Any())
            {
                return Ok(tbl_Municipio_Diretoria_AIS_BPM);
            }
            return NotFound();
        }
    }
}
