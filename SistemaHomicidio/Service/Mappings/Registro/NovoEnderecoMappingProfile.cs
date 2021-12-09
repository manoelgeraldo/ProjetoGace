using AutoMapper;
using Domain.Entities;
using Infra.CrossCutting.ViewModels.Envolvido;

namespace Service.Mappings
{
    public class NovoEnderecoMappingProfile : Profile
    {
        public NovoEnderecoMappingProfile()
        {
            CreateMap<NovoEndereco, EnvolvidoEndereco>().ReverseMap();
        }
    }
}
