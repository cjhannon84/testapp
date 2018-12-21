using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MobileApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileApi.Controllers
{
    [Authorize]
    public abstract class BaseController : Controller
    {
        protected IDbConnectionFactory _connectionFactory;

        protected BaseController(IDbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }


    }
}
