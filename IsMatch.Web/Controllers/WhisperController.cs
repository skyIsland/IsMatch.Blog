using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IsMatch.Web.Controllers
{
    public class WhisperController : BaseController
    {
        [Route("whisper")]
        public IActionResult Index()
        {
            ViewBag.Title = "我的微语";
            ViewBag.Position = "Whisper";
            return View();
        }
    }
}