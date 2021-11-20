using AutoMapper;
using Domain.Entities;
using Infra.CrossCutting.ViewModels.Boe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Mappings
{
    public class ExibirBoeComplementadoMappingProfile : Profile
    {
        public ExibirBoeComplementadoMappingProfile()
        {
            CreateMap<BoeComplementado, ExibirBoeComplementado>().ReverseMap();
        }
    }
}
