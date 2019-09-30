using System;
using System.Linq;

using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace FlyApi.Api.Controllers.v1
{
    [ApiController]
    [AllowAnonymous]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class LoginController : ControllerBase
    {
         // GET api/values
         [HttpGet]
         public ActionResult<IEnumerable<string>> Get()
         {
             return new string[] { "Version: 1.0" };
         }
    }
}