using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GetClientIPAddress.Models;
using System.Net;
using Microsoft.AspNetCore.Http;

namespace GetClientIPAddress.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public HomeController(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            ViewData["ipaddress"] = this.httpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
