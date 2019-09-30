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
    public partial class apiConfigureServices : IConfigureServices
    {
        public IConfigureServices addConfig()
        {
            _services.AddOptions();
            
            return this;
        }
        
    }
}