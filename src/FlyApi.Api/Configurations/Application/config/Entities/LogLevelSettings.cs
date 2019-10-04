using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace FlyApi.Api.Configurations.Application.config.Entities
{
  
    public class LogLevelSettings
    {
        public LogLevel Default { get; set; }
        public LogLevel Identity { get; set; }
    }

}

