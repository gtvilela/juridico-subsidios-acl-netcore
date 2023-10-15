using Juridico.Subsidios.Acl.Application.Handlers;
using Juridico.Subsidios.Acl.Domain.Interfaces.Handlers;
using System.Reflection;

namespace Juridico.Subsidios.Acl.Application
{
    public static class Setup
    {

        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            
            services.AddScoped<IProcessoHandler, ProcessoHandler>();
            services.AddScoped<ISubsidiosHandler, SubsidiosHandler>();

            return services;
        }
    }
}
