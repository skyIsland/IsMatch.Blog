using System;
using System.Collections.Generic;
using System.ComponentModel;
using NewLife.Log;
using XCode;

namespace IsMatch.Core
{
    /// <summary>文章栏目</summary>
    public partial class ArticleCategory : Entity<ArticleCategory>
    {
        #region 对象操作
        static ArticleCategory()
        {
            // 累加字段
            //var df = Meta.Factory.AdditionalFields;
            //df.Add(__.IsList);

            // 过滤器 UserModule、TimeModule、IPModule
        }

        /// <summary>验证数据，通过抛出异常的方式提示验证失败。</summary>
        /// <param name="isNew">是否插入</param>
        public override void Valid(Boolean isNew)
        {
            // 如果没有脏数据，则不需要进行任何处理
            if (!HasDirty) return;

            // 在新插入数据或者修改了指定字段时进行修正
        }

        /// <summary>首次连接数据库时初始化数据，仅用于实体类重载，用户不应该调用该方法</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override void InitData()
        {
            // InitData一般用于当数据表没有数据时添加一些默认数据，该实体类的任何第一次数据库操作都会触发该方法，默认异步调用
            if (Meta.Session.Count > 0) return;

            if (XTrace.Debug) XTrace.WriteLine("开始初始化ArticleCategory[文章栏目]数据……");
            Dictionary<string, string> allArticleCategory = new Dictionary<string, string>()
            {
                {"Index", "文章"},
                {"Whisper", "微语"},
                {"Leacots", "留言"},
                {"Album", "相册"},
                {"About", "关于"}
            };
            int i = 0;
            foreach (var articleName in allArticleCategory)
            {
                var entity = new ArticleCategory
                {
                    KindName = articleName.Value,
                    Keyword = "我的" + articleName.Value,
                    Description = "我的" + articleName.Value,
                    LinkURL = "abc",
                    TitleColor = "abc",
                    IsList = 0,
                    PageSize = 5,
                    PId = 0,
                    IsHide = 0,
                    IsDel = 0,
                    KindEnName = articleName.Key,
                    Sequence = i
                };
                i++;
                entity.Insert();
            }
           

            if (XTrace.Debug) XTrace.WriteLine("完成初始化ArticleCategory[文章栏目]数据！");
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
        #endregion

        #region 扩展查询
        /// <summary>根据编号查找</summary>
        /// <param name="id">编号</param>
        /// <returns>实体对象</returns>
        public static ArticleCategory FindById(Int32 id)
        {
            if (id <= 0) return null;

            // 实体缓存
            if (Meta.Session.Count < 1000) return Meta.Cache.Find(e => e.Id == id);

            // 单对象缓存
            //return Meta.SingleCache[id];

            return Find(_.Id == id);
        }

        /// <summary>根据父级编号查找</summary>
        /// <param name="pId">编号</param>
        /// <returns>实体对象</returns>
        public static IList<ArticleCategory> FindByPId(Int32 pId)
        {
            if (pId <= 0) return null;

            // 实体缓存
            if (Meta.Session.Count < 1000) return Meta.Cache.FindAll(e => e.PId == pId);

            // 单对象缓存
            //return Meta.SingleCache[id];

            return FindAll(_.PId == pId);
        }
        #endregion

        #region 高级查询
        #endregion

        #region 业务操作
        #endregion
    }
}