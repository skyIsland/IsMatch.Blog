﻿using IsMatch.Common.Web;
using IsMatch.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace IsMatch.Web.Controllers
{
    /// <summary>
    /// 控制器基类
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Prepare();
            base.OnActionExecuting(context);
        }

        public virtual void Prepare()
        {
            ViewBag.AllArticleCategory = ArticleCategory.FindAll(ArticleCategory._.IsDel == false & ArticleCategory._.PId == 0, ArticleCategory._.Sequence, null, 0, 0);

            ViewBag.Position = "Index";
        }

        [NonAction]
        protected IActionResult Prompt(Action<Prompt> setupPrompt)
        {
            var prompt = new Prompt();
            setupPrompt(prompt);
            Response.StatusCode = prompt.StatusCode;
            return View("Prompt", prompt);
        }

        //public virtual IActionResult GetList(IsMatchPager p = null)
        //{
        //    if (p == null) p = new IsMatchPager();
        //    string key = p["key"];
        //    var list = Entity<TEntity>.Search(key, p);
        //    var result = PageResult.FromPager(p);
        //    result.Data = list;
        //    return Json(result);
        //}
    }
}