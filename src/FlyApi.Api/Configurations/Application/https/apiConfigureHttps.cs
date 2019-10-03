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

namespace FlyApi.Api.Configuration
{
    public static partial class apiConfigureApplication
    {

        public static void addFlyHttps(this IApplicationBuilder application, IHostingEnvironment env, IApiVersionDescriptionProvider provider)
        {
            if (env.IsDevelopment())
            {
                apiConfigureApplication.addFlyHttpsDev(application);
            }
            else
            {
                apiConfigureApplication.addFlyHttpsProd(application);
            }
        }

        private static void addFlyHttpsDev(IApplicationBuilder application)
        {
            application.UseHttpsRedirection();
        }
        private static void addFlyHttpsProd(IApplicationBuilder application)
        {
            application.UseHsts();
            application.UseHttpsRedirection();
        }
    }
}