using AutoMapper;
using Domain.Entities;
using Infra.CrossCutting.ViewModels;
using Infra.CrossCutting.ViewModels.Arquivo;
using Infra.CrossCutting.ViewModels.Boe;
using Infra.CrossCutting.ViewModels.Envolvido;
using Infra.CrossCutting.ViewModels.Fato;

namespace Service.Mappings
{
    public class ExibirRegistroMappingProfile : Profile
    {
        public ExibirRegistroMappingProfile()
        {
            CreateMap<Registro, ExibirRegistro>();
            CreateMap<Fato, ExibirFato>();
            CreateMap<Envolvido, NovoEnvolvido>();
            CreateMap<Inquerito, NovoInquerito>();
            CreateMap<Arquivo, NovoArquivo>();
            CreateMap<BoeComplementado, NovoBoe>();
        }
    }
}
