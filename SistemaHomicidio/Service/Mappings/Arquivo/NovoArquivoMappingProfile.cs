using AutoMapper;
using Domain.Entities;
using Infra.CrossCutting.ViewModels.Arquivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
