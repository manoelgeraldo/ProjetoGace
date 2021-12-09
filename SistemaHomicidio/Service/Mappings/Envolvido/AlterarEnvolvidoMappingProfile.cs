using AutoMapper;
using Domain.Entities;
using Infra.CrossCutting.ViewModels.Envolvido;

namespace Service.Mappings
{
    public class AlterarEnvolvidoMappingProfile : Profile
    {
        public AlterarEnvolvidoMappingProfile()
        {
            CreateMap<AlterarEnvolvido, Envolvido>().ReverseMap();
        }
    }
}
