using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyApi.Api.Configurations.Shared
{
    public interface IConfigureApplication
    {
        IConfigureApplication addException();
        void addExceptionDev();
        void addExceptionProd();
        IConfigureApplication addHttps();
        void addHttpsDev();
        void addHttpsProd();
        IConfigureApplication addMvc();

        IConfigureApplication UseSwaggerUI();
    }
}
