using Juridico.Subsidios.Acl.Domain.Handlers;
using Juridico.Subsidios.Acl.Domain.Interfaces.Gateways;
using Juridico.Subsidios.Acl.Domain.Interfaces.Handlers;
using Juridico.Subsidios.Acl.Domain.Interfaces.Services;
using Juridico.Subsidios.Acl.Infrastucture.Gateways;
using Juridico.Subsidios.Acl.Infrastucture.Handlers;
using Juridico.Subsidios.Acl.Infrastucture.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Juridico.Subsidios.Acl.Infrastucture
{
    public static class Setup
    {

        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IFornecedorGateway, FornecedorGateway>();
            
            services.AddScoped<IProcessoHandler, ProcessoHandler>();
            services.AddScoped<ISubsidiosHandler, SubsidiosHandler>();
            
            services.AddSingleton<IConfigCatService, ConfigCatService>();
            services.AddScoped<IProcessoService, ProcessoService>();
            services.AddScoped<IDocumentoService, DocumentoService>();
            services.AddScoped<IInformacaoAdicionalService, InformacaoAdicionalService>();
            services.AddScoped<IAndamentoService, AndamentoService>();
            
            services.AddAutoMapper(GetCurrentAssemblies());

            return services;
        }

        public static IEnumerable<Assembly> GetCurrentAssemblies()
        {
            return new Assembly[]
            {
                Assembly.Load("Juridico.Subsidios.Acl.Application"),
                Assembly.Load("Juridico.Subsidios.Acl.Domain")
            };
        }
    }
}
