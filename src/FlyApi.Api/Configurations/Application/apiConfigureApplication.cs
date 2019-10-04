using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace FlyApi.Api.Configuration
{
    public static partial class apiConfigureApplication
    {
        public  static void apiFlyConfigureApplication(this IApplicationBuilder application, IHostingEnvironment env, IApiVersionDescriptionProvider provider)
        {
            application.addFlyConfiguration(env, provider);
            application.UseFlySwaggerUI(env, provider);
            application.addFlyException(env, provider);
            application.addFlyHttps(env, provider);
            application.addFlyMvc(env, provider);
        }

    }
}