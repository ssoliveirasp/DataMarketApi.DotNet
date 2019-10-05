using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyApi.Api.Configurations.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Mime;

namespace FlyApi.Api.Configuration
{
    public static class apiUseHealthChecks
    {

        public static void UseFlyHealthChecks(this IApplicationBuilder application, IHostingEnvironment env, IApiVersionDescriptionProvider provider)
        {
            application.UseHealthChecks("/status", getHealthCheckOptions());
        }

        private static HealthCheckOptions getHealthCheckOptions()
        {
            HealthCheckOptions option =  new HealthCheckOptions()
            {
                ResponseWriter = async (context, report) =>
                {
                    var result = JsonConvert.SerializeObject(
                        new
                        {
                            statusApplication = report.Status.ToString(),
                            healthChecks = report.Entries.Select(e => new
                            {
                                check = e.Key,
                                status = Enum.GetName(typeof(HealthStatus), e.Value.Status)
                            })
                        });
                    context.Response.ContentType = MediaTypeNames.Application.Json;
                    await context.Response.WriteAsync(result);
                }
            };

            return option;
        }
    }
}