using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MobileApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileApi.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : BaseController
    {
        public HomeController(IDbConnectionFactory dbConnectionFactory)
            :base(dbConnectionFactory)
        { }

        public IActionResult Index() => new OkObjectResult(new string[]
        {
            "1",
            "2"
        });
    }
}
