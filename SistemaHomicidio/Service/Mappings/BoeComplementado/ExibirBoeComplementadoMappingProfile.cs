using AutoMapper;
using Domain.Entities;
using Infra.CrossCutting.ViewModels.Boe;

namespace Service.Mappings
{
    public class ExibirBoeComplementadoMappingProfile : Profile
    {
        public ExibirBoeComplementadoMappingProfile()
        {
            CreateMap<BoeComplementado, ExibirBoeComplementado>().ReverseMap();
        }
    }
}
