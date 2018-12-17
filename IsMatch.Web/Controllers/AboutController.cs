using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IsMatch.Web.Controllers
{
    public class AboutController : BaseController
    {
        [Route("about")]
        public IActionResult Index()
        {
            ViewBag.Title = "关于";
            ViewBag.Position = "About";
            return View();
        }
    }
}