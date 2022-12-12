using Asset.Variations.Domain.Acl;
using Asset.Variations.Domain.Services;
using Asset.Variations.Infra.Acl;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset.Variations.Infra.IOC.Module
{
    public static class DomainModule
    {
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterServices(configuration);
        }

        private static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IFinanceService, FinanceService>();
            return services;
        }
    }
}
