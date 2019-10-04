using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyApi.Api.Configurations.Application.config.Entities
{
    public class LoggingSection
    {
        public bool IncludeScopes { get; set; }
        public int MaxMessageLength { get; set; }
        public LogLevelSettings LogLevel { get; set; }
    }
    
}

