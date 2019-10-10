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
    public static class apiConfigMVC
    {
        public static void addFlyMvc(this IServiceCollection services)
        {
            IMvcBuilder MvcBuilder = services.AddMvc(options => options.EnableEndpointRouting = false);

            apiConfigMVC.SetFlyCompatibilityVersion(MvcBuilder);
            apiConfigMVC.AddFlyJsonOptions(MvcBuilder);
            apiConfigMVC.AddFlyXmlSerializerFormatters(MvcBuilder);
        }

        private static void SetFlyCompatibilityVersion(IMvcBuilder MvcBuilder)
        {
            MvcBuilder.SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        private static void AddFlyJsonOptions(IMvcBuilder MvcBuilder) {
            MvcBuilder.AddJsonOptions(
                option => option.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore
            );
        }

        private static void AddFlyXmlSerializerFormatters(IMvcBuilder MvcBuilder)
        {
            MvcBuilder.AddXmlSerializerFormatters();
        }


    }
}