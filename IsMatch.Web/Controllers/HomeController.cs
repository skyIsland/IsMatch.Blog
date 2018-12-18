using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using IsMatch.Core;
using Microsoft.AspNetCore.Mvc;
using IsMatch.Web.Models;
using XCode;

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

        public IActionResult InitData()
        {
            ArticleCategory.Meta.BeginTrans();
            string message = "";
            try
            {
                var articleCategoryList = GetSeedDataBySecondCategory();
                var articleList = GetSeedDataByArticle();
                articleCategoryList.Save();
                articleList.Save();
                ArticleCategory.Meta.Commit();
                message = "插入数据出现完成";
            }
            catch (Exception ex)
            {
                ArticleCategory.Meta.Rollback();
                message = "插入数据出现错误，原因：" + ex.Message;
            }
            return Content(message);
        }

        public List<ArticleCategory> GetSeedDataBySecondCategory()
        {
            ArticleCategory ac = ArticleCategory.Find(ArticleCategory._.KindName == "文章");
            if (ac == null)
            {
                ac = new ArticleCategory
                {
                    KindName = "文章",
                    KindEnName = "index"
                };
                ac.Save();
            }
            return new List<ArticleCategory>
            {
                new ArticleCategory()
                {
                    KindName = "前端文章",
                    KindEnName = "frontend",
                    PId = ac.Id
                },
                new ArticleCategory()
                {
                    KindName = "后端文章",
                    KindEnName = "backend",
                    PId = ac.Id
                },
                new ArticleCategory()
                {
                    KindName = "旅游杂记",
                    KindEnName = "travel",
                    PId = ac.Id
                }
            };
        }

        public List<Article> GetSeedDataByArticle()
        {
            
            return new List<Article>
            {
                new Article()
                {
                    Title = "前端系列文章1",
                    Keyword = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Excepturi exercitationem error, quam inventore nobis corporis nam, tenetur quidem voluptatibus similique odit quas molestias? Magni alias enim sint eveniet harum quasi!",
                }
            };
        }
    }
}
