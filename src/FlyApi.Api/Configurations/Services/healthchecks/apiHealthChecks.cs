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
    public static class apiHealthChecks
    {
        public static void AddFlyHealthChecks(this IServiceCollection services)
        {
            services.AddHealthChecks();
        }
    }
}