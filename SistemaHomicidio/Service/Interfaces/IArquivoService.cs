using Infra.CrossCutting.ViewModels.Arquivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IArquivoService
    {
        Task<ExibirArquivo> UploadArquivo(NovoArquivo novoArquivo);
    }
}
