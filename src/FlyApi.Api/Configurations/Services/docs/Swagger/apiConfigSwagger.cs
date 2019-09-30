using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyApi.Api.Configurations.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace FlyApi.Api.Configuration
{
    public partial class apiConfigureServices : IConfigureServices
    {
        public IConfigureServices AddSwaggerGen()
        {
            _services.AddSwaggerGen(
                options =>
                {
                    var provider = _services.BuildServiceProvider()
                                        .GetRequiredService<IApiVersionDescriptionProvider>();

                    foreach (var description in provider.ApiVersionDescriptions)
                    {
                        options.SwaggerDoc(
                            description.GroupName,
                            new Info()
                            {
                                Title = $"Sample API {description.ApiVersion}",
                                Version = description.ApiVersion.ToString()
                            });
                    }
                });

            return this;
        }
    }
}