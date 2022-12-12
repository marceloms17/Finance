﻿using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace Asset.Variations.Api.Configuration.Extensions
{
    public static class SwaggerExtensions
    {
        public static IApplicationBuilder ConfigureSwagger(this IApplicationBuilder app, IConfiguration config, IApiVersionDescriptionProvider provider)
        {
            var useSwagger = config.GetValue<bool>("UseSwagger");

            if (!useSwagger)
            {
                return app;
            }

            return app
                .UseSwagger()
                .UseSwaggerUI(options => provider.ApiVersionDescriptions
                    .ToList()
                    .ForEach(act =>
                        options.SwaggerEndpoint($"/swagger/{act.GroupName}/swagger.json", act.GroupName.ToUpper())));
        }
    }
}