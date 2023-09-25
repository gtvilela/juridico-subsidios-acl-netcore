using Juridico.Subsidios.Acl.Domain.Interfaces;
using Juridico.Subsidios.Acl.Infrastucture.Gateways;
using Microsoft.Extensions.DependencyInjection;
using RestSharp;

namespace Juridico.Subsidios.Acl.Infrastucture
{
    public static class Setup
    {

        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IRestClient, RestClient>();
            services.AddScoped<IFornecedorGateway, FornecedorGateway>();

            return services;
        }
    }
}
