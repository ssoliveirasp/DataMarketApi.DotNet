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
    public partial class apiConfigureApplication
    {
        private IApplicationBuilder _application;
        private IHostingEnvironment _env;
        private IApiVersionDescriptionProvider _provider;

        public apiConfigureApplication(IApplicationBuilder application, IHostingEnvironment env, IApiVersionDescriptionProvider provider)
        {
            _application = application;
            _env = env;
            _provider = provider;
        }

    }
}