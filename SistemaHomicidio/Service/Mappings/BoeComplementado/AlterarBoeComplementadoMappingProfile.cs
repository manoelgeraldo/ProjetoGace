using AutoMapper;
using Domain.Entities;
using Infra.CrossCutting.ViewModels.Boe;

namespace Service.Mappings
{
    public class AlterarBoeComplementadoMappingProfile : Profile
    {
        public AlterarBoeComplementadoMappingProfile()
        {
            CreateMap<AlterarBoe, BoeComplementado>().ReverseMap();
        }
    }
}
