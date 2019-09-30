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
        public IConfigureApplication addException()
        {
            if (_env.IsDevelopment())
            {
                this.addExceptionDev();
            }

            return this;
        }
        public void addExceptionDev()
        {
            _application.UseDeveloperExceptionPage();
        }

        public void addExceptionProd()
        {

        }
    }
}