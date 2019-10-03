using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using FlyApi.Api.Configurations.Shared;

namespace FlyApi.Api.Configuration
{
    public static partial class ApiConfigureServices
    {
        public static void addFlyConfig(this IServiceCollection services)
        {
            services.AddOptions();
        }
        
    }
}