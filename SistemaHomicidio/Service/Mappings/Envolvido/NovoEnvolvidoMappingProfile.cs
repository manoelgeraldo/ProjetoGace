using AutoMapper;
using Domain.Entities;
using Infra.CrossCutting.ViewModels.Envolvido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
