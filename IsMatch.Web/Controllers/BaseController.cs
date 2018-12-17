using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IsMatch.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace IsMatch.Web.Controllers
{
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
    }
}