using Microsoft.Extensions.DependencyInjection;
using Service.Mappings;
using Service.Mappings.Auxiliares;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISistemaHomicidio.Configurations
{
    public static class AutoMapperConfiguration
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(
                typeof(ExibirRegistroMappingProfile),
                typeof(NovoRegistroMappingProfile),
                typeof(AlterarRegistroMappingProfile),
                typeof(ExibirEnvolvidoMappingProfile),
                typeof(NovoEnvolvidoMappingProfile),
                typeof(AlterarEnvolvidoMappingProfile),
                typeof(NovoCriminalMappingProfile),
                typeof(NovoSaudeMappingProfile),
                typeof(NovoEnderecoMappingProfile),
                typeof(ExibirBoeComplementadoMappingProfile),
                typeof(NovoBoeComplementadoMappingProfile),
                typeof(AlterarBoeComplementadoMappingProfile),
                typeof(UsuarioMappingProfile),
                typeof(NovoArquivoMappingProfile),
                typeof(Municipio_Diretoria_AIS_BPMMappingProfile));
        }
    }
}
