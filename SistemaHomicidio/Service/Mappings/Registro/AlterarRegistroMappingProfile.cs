using AutoMapper;
using Domain.Entities;
using Infra.CrossCutting.ViewModels;
using Infra.CrossCutting.ViewModels.Arquivo;
using Infra.CrossCutting.ViewModels.Boe;
using Infra.CrossCutting.ViewModels.Envolvido;
using Infra.CrossCutting.ViewModels.Fato;
using Infra.CrossCutting.ViewModels.Inquerito;
using System;

namespace Service.Mappings
{
    public class AlterarRegistroMappingProfile : Profile
    {
        public AlterarRegistroMappingProfile()
        {
            CreateMap<AlterarRegistro, Registro>()
                .ForMember(d => d.DataLancamento, o => o.Ignore())
                .ForMember(d => d.DataAtualizacao, o => o.MapFrom(s => DateTime.Now.ToString("g")))
                .ReverseMap();
            CreateMap<AlterarFato, Fato>()
                .ForMember(d => d.MunicipioFato, o => o.MapFrom(s => s.MunicipioFato.Municipio))
                .ForMember(d => d.DiretoriaFato, o => o.MapFrom(s => s.MunicipioFato.Diretoria))
                .ForMember(d => d.AisFato, o => o.MapFrom(s => s.MunicipioFato.AIS))
                .ForMember(d => d.UnidadePMFato, o => o.MapFrom(s => s.MunicipioFato.BPM))
                .ReverseMap()
                .ForPath(d => d.MunicipioFato.Municipio, o => o.MapFrom(s => s.MunicipioFato))
                .ForPath(d => d.MunicipioFato.Diretoria, o => o.MapFrom(s => s.DiretoriaFato))
                .ForPath(d => d.MunicipioFato.AIS, o => o.MapFrom(s => s.AisFato))
                .ForPath(d => d.MunicipioFato.BPM, o => o.MapFrom(s => s.UnidadePMFato));
            CreateMap<AlterarEnvolvido, Envolvido>()
                .ReverseMap();
            CreateMap<AlterarInquerito, Inquerito>()
                .ReverseMap();
            CreateMap<AlterarArquivo, Arquivo>()
                .ReverseMap();
            CreateMap<AlterarBoe, BoeComplementado>()
                .ReverseMap();
        }
    }
}
