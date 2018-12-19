using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using IsMatch.Core;
using Microsoft.AspNetCore.Mvc;
using IsMatch.Web.Models;
using XCode;
using IsMatch.Common.Web;

namespace IsMatch.Web.Controllers
{
    public class HomeController : BaseController
    {

        #region 视图
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
            ViewBag.SecondCatogory = ArticleCategory.FindByPId(1);
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
        [Route("Post")]
        public IActionResult Post(string id)
        {
            return View();
        }
        #endregion

        #region 方法
        [HttpGet]
        [Route("Home/GetList/{pId}")]
        public virtual IActionResult GetList(int pId = 1, IsMatchPager p = null)
        {
            if (p == null) p = new IsMatchPager();
            var list = Article.FindByPId(pId, p);
            var result = PageResult.FromPager(p);
            result.Data = list;
            return Json(result);
        }
        #endregion
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }     
    }
}
