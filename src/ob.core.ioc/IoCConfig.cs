using Microsoft.Extensions.DependencyInjection;
using ob.core.application.Applications;
using ob.core.data.Repositories;
using ob.core.domain.Interface.Application;
using ob.core.domain.Interface.Repositories;
using ob.core.domain.Interface.Services;
using ob.core.service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ob.core.ioc
{
    public static class IoCConfig
    {
        public static IServiceCollection ConfigIoC(this IServiceCollection services)
        {
            services.IoCModulos();
            return services;
        }
        public static IServiceCollection IoCModulos(this IServiceCollection services)
        {
            services.AddTransient<IUsuarioApplication, UsuarioApplication>();
            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();

            services.AddTransient<IPerfilUsuarioApplication, PerfilUsuarioApplication>();
            services.AddTransient<IPerfilUsuarioService, PerfilUsuarioService>();
            services.AddTransient<IPerfilUsuarioRepository, PerfilUsuarioRepository>();

            services.AddTransient<ISistemaApplication, SistemaApplication>();
            services.AddTransient<ISistemaService, SistemaService>();
            services.AddTransient<ISistemaRepository, SistemaRepository>();

            services.AddTransient<IEmailApplication, EmailApplication>();
            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<IEmailRepository, EmailRepository>();
            services.AddTransient<IEmailConfiguracaoRepository, EmailConfiguracaoRepository>();
            services.AddTransient<IEmailNovoService, EmailNovoService>();
            

            return services;
        }
    }
}
