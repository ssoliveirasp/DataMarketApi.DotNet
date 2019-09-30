using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyApi.Api.Configurations.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.DependencyInjection;

namespace FlyApi.Api.Configuration
{
    public partial class apiConfigureServices : IConfigureServices
    {
        public IConfigureServices addApiVersioning()
        {
            _services.AddApiVersioning(config =>
            {
                config.ReportApiVersions = true;
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.ApiVersionReader = new HeaderApiVersionReader("api-version");
            });

            _services.AddMvcCore().AddVersionedApiExplorer(o => { o.GroupNameFormat = "'v'VVV"; });

            return this;
        }
    }
}