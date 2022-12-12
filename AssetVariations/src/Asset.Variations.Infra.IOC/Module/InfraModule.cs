using Asset.Variations.Domain.Acl;
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
    public static class InfraModule
    {
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterAcl(configuration);
        }

        private static IServiceCollection RegisterAcl(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IFinanceAcl, FinanceAcl>();
            return services;
        }
    }
}
