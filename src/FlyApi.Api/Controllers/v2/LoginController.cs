using System;
using System.Linq;

using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace FlyApi.Api.Controllers.v2
{
    [ApiController]
    [AllowAnonymous]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class LoginController : ControllerBase
    {
         // GET api/values
         [HttpGet]
         public ActionResult<IEnumerable<string>> Get()
         {
             return new string[] { "Version: 2.0" };
         }
    }
}