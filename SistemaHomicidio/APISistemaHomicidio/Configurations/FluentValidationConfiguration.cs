using FluentValidation.AspNetCore;
using MicroElements.Swashbuckle.FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Service.Validators;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APISistemaHomicidio.Configurations
{
    public static class FluentValidationConfiguration
    {
        public static void AddFluentValidationConfiguration(this IServiceCollection services)
        {
            services.AddControllers()
                .AddNewtonsoftJson(x =>
                {
                    x.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                    x.SerializerSettings.Converters.Add(new StringEnumConverter());
                })
                .AddJsonOptions(p =>
                {
                    p.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                })
                .AddFluentValidation(p =>
                {
                    p.RegisterValidatorsFromAssemblyContaining<NovoRegistroValidator>();
                    p.RegisterValidatorsFromAssemblyContaining<NovoEnvolvidoValidator>();
                    p.RegisterValidatorsFromAssemblyContaining<NovoFatoValidator>();
                    p.RegisterValidatorsFromAssemblyContaining<UsuarioValidator>();
                    p.RegisterValidatorsFromAssemblyContaining<NovoUsuarioValidator>();
                    p.ValidatorFactoryType = typeof(HttpContextServiceProviderValidatorFactory);
                    p.ValidatorOptions.LanguageManager.Culture = new CultureInfo("pt-BR");
                });
        }
    }
}
