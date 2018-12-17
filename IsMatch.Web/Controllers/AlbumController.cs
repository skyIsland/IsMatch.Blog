using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IsMatch.Web.Controllers
{
    public class AlbumController : BaseController
    {
        [Route("album")]
        public IActionResult Index()
        {
            ViewBag.Title = "相册";
            ViewBag.Position = "Album";
            return View();
        }
    }
}