using AutoMapper;
using Domain.Entities;
using Infra.CrossCutting.ViewModels.Boe;

namespace Service.Mappings
{
    public class NovoBoeComplementadoMappingProfile : Profile
    {
        public NovoBoeComplementadoMappingProfile()
        {
            CreateMap<NovoBoe, BoeComplementado>().ReverseMap();
        }
    }
}
