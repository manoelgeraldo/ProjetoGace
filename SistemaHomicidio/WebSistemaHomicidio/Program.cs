using Blazored.LocalStorage;
using Blazored.Modal;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using System;
using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;
using WebSistemaHomicidio.Helpers;
using WebSistemaHomicidio.Interfaces;
using WebSistemaHomicidio.Services;

namespace WebSistemaHomicidio
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(x =>
            {
                var apiUrl = new Uri(builder.Configuration["apiUrl"]);
                return new HttpClient() { BaseAddress = apiUrl };
            });
            
            builder.Services
                .AddScoped<IAuthenticationService, AuthenticationService>()
                .AddScoped<IHttpService, HttpService>();

            //Registro de serviços MudBlazor
            builder.Services.AddMudServices();

            //Converte TimeSpan
            builder.Services.Configure<JsonSerializerOptions>(options => options.Converters.Add(new TimeSpanJsonConverter()));

            //Registro de serviços Blazored
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddBlazoredModal();
            var host = builder.Build();

            var authenticationService = host.Services.GetRequiredService<IAuthenticationService>();
            await authenticationService.Initialize();

            await host.RunAsync();
        }
    }
}
