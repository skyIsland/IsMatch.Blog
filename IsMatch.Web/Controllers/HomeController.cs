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
        [Route("Index.do")]
        public IActionResult Index()
        {
            ViewBag.Title = "首页";
            return View();
        }

        /// <summary>
        /// 详情页
        /// </summary>
        /// <returns></returns>
        public IActionResult Detail()
        {
            return View();
        }

        /// <summary>
        /// 微语页
        /// </summary>
        /// <returns></returns>
        public IActionResult Whisper()
        {
            ViewBag.Title = "我的微语";
            return View();
        }

        /// <summary>
        /// 留言页
        /// </summary>
        /// <returns></returns>
        public IActionResult Leacots()
        {
            ViewBag.Title = "留言";
            return View();
        }

        /// <summary>
        /// 相册页
        /// </summary>
        /// <returns></returns>
        public IActionResult Album()
        {
            ViewBag.Title = "我的相册";
            return View();
        }

        /// <summary>
        /// 关于页
        /// </summary>
        /// <returns></returns>
        [Route("About.do")]
        public IActionResult About()
        {
            ViewBag.Title = "关于我";
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
