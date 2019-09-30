using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyApi.Api.Configurations.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace FlyApi.Api.Configuration
{
    public partial class apiConfigureApplication: IConfigureApplication
    {

        public IConfigureApplication addHttps()
        {
            if (!_env.IsDevelopment())
            {
                this.addHttpsDev();
            }
            else
            {
                this.addHttpsProd();
            }

            return this;
        }

        public void addHttpsDev()
        {
            _application.UseHsts();
            _application.UseHttpsRedirection();
        }
        public void addHttpsProd()
        {
            _application.UseHttpsRedirection();
        }
    }
}