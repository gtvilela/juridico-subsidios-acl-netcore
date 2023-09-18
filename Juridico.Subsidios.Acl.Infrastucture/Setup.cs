using Microsoft.Extensions.DependencyInjection;
using RestSharp;

namespace Juridico.Subsidios.Acl.Infrastucture
{
    public static class Setup
    {

        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IRestClient, RestClient>();

            return services;
        }
    }
}
