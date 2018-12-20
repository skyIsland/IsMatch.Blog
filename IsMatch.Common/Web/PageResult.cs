using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewLife.Web;

namespace IsMatch.Common.Web
{
    /// <summary>带分页的Ajax返回结果</summary>
    /// <typeparam name="T"></typeparam>
    public class PageResult<T> : AjaxResult<T>
    {
        #region 属性

        /// <summary>页面索引</summary>
        public virtual Int32 PageIndex { get; set; }

        /// <summary>页面大小</summary>
        public virtual Int32 PageSize { get; set; }

        /// <summary>总记录数</summary>
        public Int32 TotalCount { get; set; }

        /// <summary>页数</summary>
        public Int32 PageCount { get; set; }

        #endregion

        #region 方法
        /// <summary>从后端分页器转换</summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static PageResult<T> FromPager(Pager p)
        {
            return new PageResult<T> { PageIndex = p.PageIndex, PageSize = p.PageSize, TotalCount = (int)p.TotalCount, PageCount = (int)p.PageCount };
        }

        #endregion
    }
    /// <summary>带分页的Ajax返回结果</summary>
    public class PageResult : PageResult<Object> { }
}
