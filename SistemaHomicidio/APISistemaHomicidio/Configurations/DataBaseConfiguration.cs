using Infra.Data.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace APISistemaHomicidio.Configurations
{
    public static class DataBaseConfiguration
    {
        public static void AddDataBaseConfiguration(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<DataBase>(options => options.UseSqlServer(Configuration.GetConnectionString("SqlConnection")));
        }
    }
}
