using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyApi.Api.Configurations.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace FlyApi.Api.Configuration
{
    public static partial class apiConfigureServices
    {
        public static void ApiFlyConfigureServices(this IServiceCollection services)
        {
               services.addFlyConfig();
               services.addFlyCors();
               services.AddFlyRouting();
               services.addFlyMvc();
               services.AddFlyApiVersioning();
               services.AddFlySwaggerGen();
        }
    }
}