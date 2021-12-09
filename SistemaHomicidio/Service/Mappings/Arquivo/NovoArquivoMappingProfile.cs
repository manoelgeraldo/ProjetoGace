using AutoMapper;
using Domain.Entities;
using Infra.CrossCutting.ViewModels.Arquivo;

namespace Service.Mappings
{
    public class NovoArquivoMappingProfile : Profile
    {
        public NovoArquivoMappingProfile()
        {
            CreateMap<NovoArquivo, Arquivo>().ReverseMap();
            CreateMap<ExibirArquivo, Arquivo>().ReverseMap();
        }
    }
}
