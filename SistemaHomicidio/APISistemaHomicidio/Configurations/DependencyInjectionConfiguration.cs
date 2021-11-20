using Infra.Data.Interfaces;
using Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Service.Interfaces;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISistemaHomicidio.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IRegistroRepository, RegistroRepository>();
            services.AddScoped<IRegistroService, RegistroService>();
            services.AddScoped<IEnvolvidoRepository, EnvolvidoRepository>();
            services.AddScoped<IEnvolvidoService, EnvolvidoService>();
            services.AddScoped<IBoeComplementadoRepository, BoeComplementadoRepository>();
            services.AddScoped<IBoeComplementadoService, BoeComplementadoService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IArquivoService, ArquivoService>();
            services.AddScoped<IArquivoRepository, ArquivoRepository>();
            services.AddScoped<IMunicipio_Diretoria_AIS_BPMService, Municipio_Diretoria_AIS_BPMService>();
            services.AddScoped<IMunicipio_Diretoria_AIS_BPMRepository, Municipio_Diretoria_AIS_BPMRepository>();
        }
    }
}
