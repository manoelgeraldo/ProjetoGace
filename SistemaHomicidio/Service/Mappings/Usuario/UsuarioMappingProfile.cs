using AutoMapper;
using Domain.Entities;
using Infra.CrossCutting.ViewModels.Usuario;

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
        }
    }
}
