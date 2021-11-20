using AutoMapper;
using Domain.Entities;
using Infra.CrossCutting.ViewModels.Arquivo;
using Infra.Data.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ArquivoService : IArquivoService
    {
        private readonly IArquivoRepository _arquivoRepository;
        private readonly IMapper _mapper;

        public ArquivoService(IArquivoRepository arquivoRepository, IMapper mapper)
        {
            _arquivoRepository = arquivoRepository;
            _mapper = mapper;
        }

        public async Task<ExibirArquivo> UploadArquivo(NovoArquivo novoArquivo)
        {
            var arquivo = _mapper.Map<Arquivo>(novoArquivo);
            arquivo = await _arquivoRepository.UploadArquivo(arquivo);
            return _mapper.Map<ExibirArquivo>(arquivo);
        }
    }
}
