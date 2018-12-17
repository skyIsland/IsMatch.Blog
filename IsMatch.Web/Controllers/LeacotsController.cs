using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IsMatch.Web.Controllers
{
    public class LeacotsController : BaseController
    {
        [Route("leacots")]
        public IActionResult Index()
        {
            ViewBag.Title = "留言";
            ViewBag.Position = "Leacots";
            return View();
        }
    }
}