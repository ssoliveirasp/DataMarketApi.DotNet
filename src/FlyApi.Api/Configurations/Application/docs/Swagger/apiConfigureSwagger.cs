using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyApi.Api.Configurations.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace FlyApi.Api.Configuration
{
    public partial class apiConfigureApplication: IConfigureApplication
    {
        public IConfigureApplication UseSwaggerUI()
        {
            if (_env.IsDevelopment())
            {

                //this._application.UseSwaggerUI(c =>
                //{
                //    foreach (var description in )
                //        c.SwaggerEndpoint("/swagger/v1/swagger.json",
                //        "Conversor de Temperaturas");
                //});
                this._application.UseSwagger();

                this._application.UseSwaggerUI(options =>
                {
                    foreach (var description in this._provider.ApiVersionDescriptions)
                    {
                        options.SwaggerEndpoint(
                        $"/swagger/{description.GroupName}/swagger.json",
                        description.GroupName.ToUpperInvariant());
                    }

                    options.DocExpansion(DocExpansion.List);
                });
            }

            return this;
        }
        
    }
}