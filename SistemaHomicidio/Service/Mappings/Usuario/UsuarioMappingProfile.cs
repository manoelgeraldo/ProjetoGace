using AutoMapper;
using Domain.Entities;
using Infra.CrossCutting.ViewModels.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Mappings
{
    public class UsuarioMappingProfile : Profile
    {
        public UsuarioMappingProfile()
        {
            CreateMap<Usuario, AlterarUsuario>().ReverseMap();
            CreateMap<Usuario, UsuarioLogado>().ReverseMap();
            CreateMap<Usuario, UsuarioLogin>().ReverseMap();
            CreateMap<Usuario, ExibirUsuario>().ReverseMap();
            CreateMap<Usuario, NovoUsuario>().ReverseMap();
            CreateMap<Funcao, ExibirFuncao>().ReverseMap();
            CreateMap<Funcao, ReferenciaFuncao>().ReverseMap();
        }
    }
}
