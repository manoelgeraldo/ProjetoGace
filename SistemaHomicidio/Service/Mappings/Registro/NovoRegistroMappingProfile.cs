using AutoMapper;
using Domain.Entities;
using Infra.CrossCutting.ViewModels;
using Infra.CrossCutting.ViewModels.Arquivo;
using Infra.CrossCutting.ViewModels.Boe;
using Infra.CrossCutting.ViewModels.Envolvido;
using System;

namespace Service.Mappings
{
    public class NovoRegistroMappingProfile : Profile
    {
        public NovoRegistroMappingProfile()
        {
            CreateMap<NovoRegistro, Registro>()
                .ForMember(d => d.DataLancamento, o => o.MapFrom(x => DateTime.Now.ToString("g")))
                .ForMember(d => d.DataRegistroBOE, o => o.MapFrom(x => x.DataRegistroBOE.ToString("d")));

            CreateMap<NovoFato, Fato>()
                .ForMember(d => d.DiaNumeralFato, o => o.MapFrom(x => x.DataFato.Day))
                .ForMember(d => d.DiaSemanaAbreviadoFato, o => o.MapFrom(x => x.DataFato.DayOfWeek))
                .ForMember(d => d.DataFato, o => o.MapFrom(x => x.DataFato.Date.ToString("d")))
                .ForMember(d => d.HoraFato, o => o.MapFrom(x => x.HoraFato.Value.ToString("t")))
                .ForMember(d => d.MunicipioFato, o => o.MapFrom(x => x.MunicipioFato.Municipio))
                .ForMember(d => d.DiretoriaFato, o => o.MapFrom(x => x.MunicipioFato.Diretoria))
                .ForMember(d => d.AisFato, o => o.MapFrom(x => x.MunicipioFato.AIS))
                .ForMember(d => d.UnidadePMFato, o => o.MapFrom(x => x.MunicipioFato.BPM));

            CreateMap<NovoEnvolvido, Envolvido>();

            CreateMap<NovoInquerito, Inquerito>();

            CreateMap<NovoArquivo, Arquivo>();

            CreateMap<NovoBoe, BoeComplementado>()
                .ForMember(d => d.DataRegistro, o => o.MapFrom(x => x.DataRegistro.Value.Date));

        }
    }
}
