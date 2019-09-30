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
    public partial class apiConfigureServices: IConfigureServices
    {
        private IServiceCollection _services;

        public apiConfigureServices(IServiceCollection services)
        {
            _services = services;
        }

    }
}