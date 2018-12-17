using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using IsMatch.Core;
using Microsoft.AspNetCore.Mvc;
using IsMatch.Web.Models;

namespace IsMatch.Web.Controllers
{
    public class HomeController : BaseController
    {

        #region 首页(文章列表页)
        /// <summary>
        /// 首页(文章列表页)
        /// </summary>
        /// <returns></returns>
        [Route("index")]
        [Route("/")]
        public IActionResult Index()
        {
            ViewBag.Title = "首页";
            ViewBag.Position = "Index";
            return View();
        }

        /// <summary>
        /// 文章列表页
        /// </summary>
        /// <returns></returns>
        public IActionResult List()
        {
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
        #endregion        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
