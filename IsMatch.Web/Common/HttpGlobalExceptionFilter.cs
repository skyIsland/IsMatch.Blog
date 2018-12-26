using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewLife.Log;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using IsMatch.Common.Web;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace IsMatch.Web.Common
{
    public class HttpGlobalExceptionFilter : IExceptionFilter
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IModelMetadataProvider _modelMetadataProvider;
        public HttpGlobalExceptionFilter(IHostingEnvironment hostingEnvironment,
        IModelMetadataProvider modelMetadataProvider)
        {
            _hostingEnvironment = hostingEnvironment;
            _modelMetadataProvider = modelMetadataProvider;
        }

        public void OnException(ExceptionContext context)
        {
            XTrace.WriteException(context.Exception);

            string contentType = context.HttpContext.Request.ContentType;
            if (contentType == "application/json" || contentType == "application/x-www-form-urlencoded")
            {
                var result = new AjaxResult();
                result.Status = 0;
                result.Message = "服务器发生异常，异常信息：" + context.Exception.Message;
                context.Result = new JsonResult(result);
            }
            else
            {
                var prompt = new Prompt
                {
                    StatusCode = 500,
                    Details = "服务器发生异常，异常信息：" + context.Exception.Message
                };
                var result = new ViewResult
                {
                    ViewName = "Prompt",
                    ViewData = new ViewDataDictionary(new EmptyModelMetadataProvider(), context.ModelState) { Model = prompt }
                };
                context.Result = result;
            }

            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.ExceptionHandled = true;
        }
    }
}
