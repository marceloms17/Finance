using Asset.Variations.Infra.IOC.Module;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Asset.Variations.Infra.IOC
{
    public static class IOC
    {
        public static IServiceCollection ConfigureContainer(this IServiceCollection services, IConfiguration configuration)
        {
            DomainModule.Register(services, configuration);
            InfraModule.Register(services, configuration);
            return services;
        }
    }
}