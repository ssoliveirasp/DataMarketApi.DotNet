using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyApi.Api.Configurations.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace FlyApi.Api.Configuration
{
    public static  class apiConfigureSwagger
    {
        public static void UseFlySwaggerUI(this IApplicationBuilder application, IHostingEnvironment env, IApiVersionDescriptionProvider provider)
        {
            if (env.IsDevelopment())
            {
                apiConfigureSwagger.UseFlyConfigSwaggerUIDev(application, env, provider);
            }
            else
            {
                apiConfigureSwagger.UseFlyConfigSwaggerUIProd(application, env, provider);
            }
        }

        private static void UseFlyConfigSwaggerUIDev(IApplicationBuilder application, IHostingEnvironment env, IApiVersionDescriptionProvider provider)
        {
            application.UseSwagger();

            application.UseSwaggerUI(options =>
            {
                foreach (var description in provider.ApiVersionDescriptions)
                {
                    options.SwaggerEndpoint(
                    $"/swagger/{description.GroupName}/swagger.json",
                    description.GroupName.ToUpperInvariant());
                }

                options.DocExpansion(DocExpansion.List);
            });
        }

        private static void UseFlyConfigSwaggerUIProd(IApplicationBuilder application, IHostingEnvironment env, IApiVersionDescriptionProvider provider)
        {
        }

    }
}