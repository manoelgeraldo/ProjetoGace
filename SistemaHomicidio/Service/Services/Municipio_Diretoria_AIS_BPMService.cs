using AutoMapper;
using Infra.CrossCutting.ViewModels.Auxiliares;
using Infra.Data.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class Municipio_Diretoria_AIS_BPMService : IMunicipio_Diretoria_AIS_BPMService
    {
        private readonly IMunicipio_Diretoria_AIS_BPMRepository repository;
        private readonly IMapper mapper;

        public Municipio_Diretoria_AIS_BPMService(IMunicipio_Diretoria_AIS_BPMRepository _repository, IMapper _mapper)
        {
            repository = _repository;
            mapper = _mapper;
        }

        public async Task<IEnumerable<Exibir_Municipio_Diretoria_AIS_BPM>> GetAll()
        {
            var municipios = await repository.GetAll();
            return mapper.Map<IEnumerable<Exibir_Municipio_Diretoria_AIS_BPM>>(municipios);
        }
    }
}
