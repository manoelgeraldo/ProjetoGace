using AutoMapper;
using Domain.Entities;
using Infra.CrossCutting.ViewModels.Envolvido;

namespace Service.Mappings
{
    public class NovoSaudeMappingProfile : Profile
    {
        public NovoSaudeMappingProfile()
        {
            CreateMap<NovoSaude, EnvolvidoSaude>().ReverseMap();
        }
    }
}
