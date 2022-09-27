using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;

namespace eShopOnMicroservices.Catalog.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class Ids4Controller : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public string GetTest()
        {
            return "123";
        }
    }
}
