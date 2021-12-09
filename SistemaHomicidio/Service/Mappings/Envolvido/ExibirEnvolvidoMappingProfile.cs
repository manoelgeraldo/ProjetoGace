using AutoMapper;
using Domain.Entities;
using Infra.CrossCutting.ViewModels.Envolvido;

namespace Service.Mappings
{
    public class ExibirEnvolvidoMappingProfile : Profile
    {
        public ExibirEnvolvidoMappingProfile()
        {
            CreateMap<Envolvido, ExibirEnvolvido>().ReverseMap();
        }
    }
}
