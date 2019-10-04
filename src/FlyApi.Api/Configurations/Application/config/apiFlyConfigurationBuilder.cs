using FlyApi.Api.Configurations.Application.config.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Configuration;

namespace FlyApi.Api.Configuration
{
    public static class apiFlyConfigurationBuilder
    {
        public static void addFlyConfiguration(this IApplicationBuilder application, IHostingEnvironment env, IApiVersionDescriptionProvider provider)
        {
            var config = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
               .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
               .AddEnvironmentVariables()
               .Build();

            LoggingSection logSettings = config.GetSection("logging").Get<LoggingSection>();
        }

    }
}



