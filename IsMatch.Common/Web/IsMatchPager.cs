using NewLife.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsMatch.Common.Web
{
    public class IsMatchPager : Pager
    {
        private String _Order;
        /// <summary>排序方式 Desc 倒序 Asc 正序</summary>
        public String Order
        {
            get { return _Order; }
            set
            {
                _Order = value;
                if (!String.IsNullOrEmpty(value) && value.ToLower() == "desc")
                {
                    Desc = true;
                }
            }
        }
        public override int PageSize { get => base.PageSize == 5 ? 1 : base.PageSize; set => base.PageSize = value; }
    }
}
