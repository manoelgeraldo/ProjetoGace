using AutoMapper;
using Domain.Entities;
using Infra.CrossCutting.ViewModels.Envolvido;

namespace Service.Mappings
{
    public class NovoEnvolvidoMappingProfile : Profile
    {
        public NovoEnvolvidoMappingProfile()
        {
            CreateMap<NovoEnvolvido, Envolvido>().ReverseMap();
        }
    }
}
