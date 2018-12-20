using IsMatch.Common.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Script.Serialization;
using NewLife.Log;
using XCode;
using XCode.Membership;

namespace IsMatch.Core
{
    /// <summary>文章</summary>
    public partial class Article : Entity<Article>
    {
        #region 对象操作
        static Article()
        {
            // 累加字段
            //var df = Meta.Factory.AdditionalFields;
            //df.Add(__.KId);

            // 过滤器 UserModule、TimeModule、IPModule
            Meta.Modules.Add<TimeModule>();
        }

        /// <summary>验证数据，通过抛出异常的方式提示验证失败。</summary>
        /// <param name="isNew">是否插入</param>
        public override void Valid(Boolean isNew)
        {
            // 如果没有脏数据，则不需要进行任何处理
            if (!HasDirty) return;

            // 在新插入数据或者修改了指定字段时进行修正
            //if (!Dirtys[nameof(UpdateTime)]) nameof(UpdateTime) = DateTime.Now;
        }

        /// <summary>首次连接数据库时初始化数据，仅用于实体类重载，用户不应该调用该方法</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override void InitData()
        {
            // InitData一般用于当数据表没有数据时添加一些默认数据，该实体类的任何第一次数据库操作都会触发该方法，默认异步调用
            if (Meta.Session.Count > 0) return;

            if (XTrace.Debug) XTrace.WriteLine("开始初始化Article[文章]数据……");

            var a1 = new Article()
            {
                Title = "前端系列文章1",
                Keyword = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Excepturi exercitationem error, quam inventore nobis corporis nam, tenetur quidem voluptatibus similique odit quas molestias? Magni alias enim sint eveniet harum quasi!",
                KId = 6,
                SubTitle = "abc",
                Content = "abc",
                LinkURL = "abc",
                IsHide = 0,
                IsDel = 0,
                IsTop = 0,
                IsComment = 0,
                Hits = 0,
                Sequence = 0,
                Icon = "abc",
                Pic = "",
                Tags = "abc",
                AddTime = DateTime.Now,
                UpdateTime = DateTime.Now
            };

            var a2 = new Article()
            {
                Title = "后端系列文章1",
                Keyword = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Excepturi exercitationem error, quam inventore nobis corporis nam, tenetur quidem voluptatibus similique odit quas molestias? Magni alias enim sint eveniet harum quasi!",
                KId = 7,
                Content = "abc",
                LinkURL = "abc",
                IsHide = 0,
                IsDel = 0,
                IsTop = 0,
                IsComment = 0,
                Hits = 0,
                Sequence = 0,
                Icon = "abc",
                Pic = "",
                Tags = "abc",
                AddTime = DateTime.Now,
                UpdateTime = DateTime.Now
            };
            var a3 = new Article()
            {
                Title = "旅游杂记系列文章1",
                Keyword = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Excepturi exercitationem error, quam inventore nobis corporis nam, tenetur quidem voluptatibus similique odit quas molestias? Magni alias enim sint eveniet harum quasi!",
                KId = 8,
                Content = "abc",
                LinkURL = "abc",
                IsHide = 0,
                IsDel = 0,
                IsTop = 0,
                IsComment = 0,
                Hits = 0,
                Sequence = 0,
                Icon = "abc",
                Pic = "",
                Tags = "abc",
                AddTime = DateTime.Now,
                UpdateTime = DateTime.Now
            };
            a1.Insert();
            a2.Insert();
            a3.Insert();

            if (XTrace.Debug) XTrace.WriteLine("完成初始化Article[文章]数据！");
        }

        ///// <summary>已重载。基类先调用Valid(true)验证数据，然后在事务保护内调用OnInsert</summary>
        ///// <returns></returns>
        //public override Int32 Insert()
        //{
        //    return base.Insert();
        //}

        ///// <summary>已重载。在事务保护范围内处理业务，位于Valid之后</summary>
        ///// <returns></returns>
        //protected override Int32 OnDelete()
        //{
        //    return base.OnDelete();
        //}
        #endregion

        #region 扩展属性
        [ScriptIgnore]
        private ArticleCategory _MyArticleCategory;
       
        public ArticleCategory MyArticleCategory => _MyArticleCategory ?? (_MyArticleCategory = ArticleCategory.FindById(this.KId));

        public string CategoryName => MyArticleCategory.KindName;
        public bool IsNew => DateTime.Now.ToString("yyyyMMdd").ToInt() - UpdateTime.ToString("yyyyMMdd").ToInt() < 4;

        #endregion

        #region 扩展查询
        /// <summary>根据编号查找</summary>
        /// <param name="id">编号</param>
        /// <returns>实体对象</returns>
        public static Article FindById(Int32 id)
        {
            if (id <= 0) return null;

            // 实体缓存
            if (Meta.Session.Count < 1000) return Meta.Cache.Find(e => e.Id == id);

            // 单对象缓存
            //return Meta.SingleCache[id];

            return Find(_.Id == id);
        }

        public static IList<Article> FindByCategoryId(Int32 categoryId, IsMatchPager p)
        {
            //if (pId <= 0) return null;

            //// 实体缓存
            //if (Meta.Session.Count < 1000) return Meta.Cache.FindAll(e => e.KId == pId);

            //// 单对象缓存
            ////return Meta.SingleCache[id];
            if (p == null) p = new IsMatchPager();
            p.Order = "Desc";
            p.OrderBy = "Sequence";
            var exp = new WhereExpression();
            exp += _.IsDel == 0;
            if (categoryId > 0)
            {
                exp &= _.KId == categoryId;
            }
            p.TotalCount = FindCount(exp);
            return FindAll(exp, p);
        }
        #endregion

        #region 高级查询
        #endregion

        #region 业务操作
        #endregion
    }
}