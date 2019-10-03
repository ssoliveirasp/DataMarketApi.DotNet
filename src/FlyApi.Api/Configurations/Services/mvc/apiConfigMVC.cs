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
        private static void addFlyMvc(this IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting = false)
                            .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }
    }
}