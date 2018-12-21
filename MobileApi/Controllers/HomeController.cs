using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        public IActionResult Index() => new OkObjectResult(new string[]
        {
            "1",
            "2"
        });
    }
}
