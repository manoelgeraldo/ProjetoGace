using Infra.CrossCutting.ViewModels.Arquivo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace APISistemaHomicidio.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ArquivosController : Controller
    {
        private readonly IArquivoService _arquivoService;

        public ArquivosController(IArquivoService arquivoService)
        {
            _arquivoService = arquivoService;
        }
        #region Opção de salvar Arquivo na raiz do diretório
        ///// <summary>
        ///// Uploads de arquivos salvos na pasta "Arquivos" na raiz da API.
        ///// </summary>
        ///// <param name="registroId"></param>
        ///// <param name="arquivos"></param>
        ///// <returns></returns>
        //[HttpPost("{registroId:int}")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //public async Task<ActionResult<List<ArquivosCarregados>>> Upload(int registroId, List<IFormFile> arquivos)
        //{
        //    var result = new List<ArquivosCarregados>();

        //    if (!arquivos.Any() || registroId == 0)
        //    {
        //        return BadRequest("Nenhum arquivo foi carregado!");
        //    }

        //    foreach(var arquivo in arquivos)
        //    {
        //        var filePath = Path.Combine(@"Arquivos", registroId.ToString(), arquivo.FileName);
        //        new FileInfo(filePath).Directory?.Create();

        //        await using var stream = new FileStream(filePath, FileMode.Create);
        //        await arquivo.CopyToAsync(stream);

        //        result.Add(new ArquivosCarregados { NomeArquivo = arquivo.FileName });
        //    }

        //    return Ok(result);
        //}

        //public class ArquivosCarregados
        //{
        //    public string NomeArquivo { get; set; }
        //}
        #endregion

        /// <summary>
        /// Anexar arquivo ao registro.
        /// </summary>
        /// <param name="registroId"></param>
        /// <param name="novoArquivo"></param>
        /// <returns></returns>
        [HttpPost("{registroId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UploadArquivo(int registroId, IFormFile novoArquivo)
        {
            if(novoArquivo != null & novoArquivo.Length > 0)
            {
                var nomeArquivo = Path.GetFileName(novoArquivo.FileName);
                var extensaoArquivo = Path.GetExtension(nomeArquivo);
                //var novoNomeArquivo = String.Concat(Convert.ToString(Guid.NewGuid()), extensaoArquivo);

                var objArquivo = new NovoArquivo()
                {
                    RegistroId = registroId,
                    NomeArquivo = nomeArquivo,
                    TipoArquivo = extensaoArquivo,
                    CriacaoArquivo = DateTime.Now
                };

                using var target = new MemoryStream();
                novoArquivo.CopyTo(target);
                objArquivo.DadosArquivo = target.ToArray();

                await _arquivoService.UploadArquivo(objArquivo);
                return CreatedAtAction(nameof(UploadArquivo), new { registroId }, novoArquivo.FileName);
            }
            return BadRequest("Nenhum arquivo foi carregado!");
        }
    }
}
