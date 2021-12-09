using AutoMapper;
using Domain.Entities;
using Infra.CrossCutting.ViewModels.Auxiliares;

namespace Service.Mappings.Auxiliares
{
    public class Municipio_Diretoria_AIS_BPMMappingProfile : Profile
    {
        public Municipio_Diretoria_AIS_BPMMappingProfile()
        {
            CreateMap<Municipio_Diretoria_AIS_BPM, Exibir_Municipio_Diretoria_AIS_BPM>().ReverseMap();
        }
    }
}
