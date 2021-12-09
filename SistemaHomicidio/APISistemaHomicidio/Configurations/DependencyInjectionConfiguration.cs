using Infra.Data.Interfaces;
using Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Service.Interfaces;
using Service.Services;

namespace APISistemaHomicidio.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IRegistroRepository, RegistroRepository>();
            services.AddScoped<IRegistroService, RegistroService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IMunicipio_Diretoria_AIS_BPMService, Municipio_Diretoria_AIS_BPMService>();
            services.AddScoped<IMunicipio_Diretoria_AIS_BPMRepository, Municipio_Diretoria_AIS_BPMRepository>();
        }
    }
}
