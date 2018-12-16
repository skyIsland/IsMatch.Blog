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
    public class HomeController : Controller
    {
        public HomeController()
        {            
            ViewBag.Position = "Index";
        }
        /// <summary>
        /// 首页(文章列表页)
        /// </summary>
        /// <returns></returns>
        [Route("Index.html")]
        [Route("Index")]
        [Route("/")]
        public IActionResult Index()
        {
            ViewBag.Title = "首页";
            ViewBag.AllArticleCategory = ArticleCategory.FindAll(ArticleCategory._.IsDel == false & ArticleCategory._.PId == 0, ArticleCategory._.Sequence, null, 0, 0);
            return View();
        }

        /// <summary>
        /// 列表页
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

        /// <summary>
        /// 微语页
        /// </summary>
        /// <returns></returns>
        [Route("Whisper.html")]
        [Route("Whisper")]
        public IActionResult Whisper()
        {
            ViewBag.Title = "我的微语";
            return View();
        }

        /// <summary>
        /// 留言页
        /// </summary>
        /// <returns></returns>
        [Route("Leacots.html")]
        [Route("Leacots")]
        public IActionResult Leacots()
        {
            ViewBag.Title = "留言";
            return View();
        }

        /// <summary>
        /// 相册页
        /// </summary>
        /// <returns></returns>
        [Route("Album.html")]
        [Route("Album")]
        public IActionResult Album()
        {
            ViewBag.Title = "我的相册";
            return View();
        }

        /// <summary>
        /// 关于页
        /// </summary>
        /// <returns></returns>
        [Route("About.html")]
        [Route("About")]
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
