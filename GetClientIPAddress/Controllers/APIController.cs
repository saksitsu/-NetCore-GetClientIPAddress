using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GetClientIPAddress.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class APIController : Controller
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        public APIController(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        [ActionName("GET_IPADDRESS")]
        [HttpGet]
        public JsonResult GET_IPADDRESS()
        {
            string str = "";

            str = this.httpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();

            return Json(str);
        }
    }
}