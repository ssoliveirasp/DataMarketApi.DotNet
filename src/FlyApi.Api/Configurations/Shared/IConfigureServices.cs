using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyApi.Api.Configurations.Shared
{
    public interface IConfigureServices
    {
        IConfigureServices addConfig();
        IConfigureServices addCors();
        IConfigureServices AddSwaggerGen();
        IConfigureServices addMvc();
        IConfigureServices AddRouting();
        IConfigureServices addApiVersioning();
    }

}
