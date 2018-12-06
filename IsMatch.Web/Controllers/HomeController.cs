using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IsMatch.Web.Models;

namespace IsMatch.Web.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 首页(文章列表页)
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 微语页
        /// </summary>
        /// <returns></returns>
        public IActionResult Whisper()
        {
            ViewData["Message"] = "微语页.";

            return View();
        }

        /// <summary>
        /// 留言页
        /// </summary>
        /// <returns></returns>
        public IActionResult Leacots()
        {
            ViewData["Message"] = "留言页.";

            return View();
        }

        /// <summary>
        /// 相册页
        /// </summary>
        /// <returns></returns>
        public IActionResult Album()
        {
            ViewData["Message"] = "相册页.";

            return View();
        }

        /// <summary>
        /// 关于页
        /// </summary>
        /// <returns></returns>
        public IActionResult About()
        {
            ViewData["Message"] = "关于页.";

            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
