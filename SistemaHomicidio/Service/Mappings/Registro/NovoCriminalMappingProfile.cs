using AutoMapper;
using Domain.Entities;
using Infra.CrossCutting.ViewModels.Envolvido;

namespace Service.Mappings
{
    public class NovoCriminalMappingProfile : Profile
    {
        public NovoCriminalMappingProfile()
        {
            CreateMap<NovoCriminal, EnvolvidoCriminal>().ReverseMap();
        }
    }
}
