using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace IsMatch.Core
{
    /// <summary>文章</summary>
    [Serializable]
    [DataObject]
    [Description("文章")]
    [BindTable("Article", Description = "文章", ConnName = "mssqlconn", DbType = DatabaseType.SqlServer)]
    public partial class Article : IArticle
    {
        #region 属性
        private Int32 _Id;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("Id", "编号", "int")]
        public Int32 Id { get { return _Id; } set { if (OnPropertyChanging(__.Id, value)) { _Id = value; OnPropertyChanged(__.Id); } } }

        private Int32 _KId;
        /// <summary>栏目ID</summary>
        [DisplayName("栏目ID")]
        [Description("栏目ID")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("KId", "栏目ID", "int")]
        public Int32 KId { get { return _KId; } set { if (OnPropertyChanging(__.KId, value)) { _KId = value; OnPropertyChanged(__.KId); } } }

        private String _Title;
        /// <summary>标题</summary>
        [DisplayName("标题")]
        [Description("标题")]
        [DataObjectField(false, false, true, 250)]
        [BindColumn("Title", "标题", "nvarchar(250)", Master = true)]
        public String Title { get { return _Title; } set { if (OnPropertyChanging(__.Title, value)) { _Title = value; OnPropertyChanged(__.Title); } } }

        private String _EnTitle;
        /// <summary>英文标题</summary>
        [DisplayName("英文标题")]
        [Description("英文标题")]
        [DataObjectField(false, false, true, 250)]
        [BindColumn("EnTitle", "英文标题", "nvarchar(250)", Master = true)]
        public String EnTitle { get { return _EnTitle; } set { if (OnPropertyChanging(__.EnTitle, value)) { _EnTitle = value; OnPropertyChanged(__.EnTitle); } } }

        private String _SubTitle;
        /// <summary>副标题</summary>
        [DisplayName("副标题")]
        [Description("副标题")]
        [DataObjectField(false, false, true, 250)]
        [BindColumn("SubTitle", "副标题", "nvarchar(250)")]
        public String SubTitle { get { return _SubTitle; } set { if (OnPropertyChanging(__.SubTitle, value)) { _SubTitle = value; OnPropertyChanged(__.SubTitle); } } }

        private String _Content;
        /// <summary>内容</summary>
        [DisplayName("内容")]
        [Description("内容")]
        [DataObjectField(false, false, true, -1)]
        [BindColumn("Content", "内容", "ntext")]
        public String Content { get { return _Content; } set { if (OnPropertyChanging(__.Content, value)) { _Content = value; OnPropertyChanged(__.Content); } } }

        private String _Keyword;
        /// <summary>描述</summary>
        [DisplayName("描述")]
        [Description("描述")]
        [DataObjectField(false, false, true, 250)]
        [BindColumn("Keyword", "描述", "nvarchar(250)")]
        public String Keyword { get { return _Keyword; } set { if (OnPropertyChanging(__.Keyword, value)) { _Keyword = value; OnPropertyChanged(__.Keyword); } } }

        private String _LinkURL;
        /// <summary>跳转链接</summary>
        [DisplayName("跳转链接")]
        [Description("跳转链接")]
        [DataObjectField(false, false, true, 250)]
        [BindColumn("LinkURL", "跳转链接", "nvarchar(250)")]
        public String LinkURL { get { return _LinkURL; } set { if (OnPropertyChanging(__.LinkURL, value)) { _LinkURL = value; OnPropertyChanged(__.LinkURL); } } }

        private Int32 _IsHide;
        /// <summary>是否隐藏</summary>
        [DisplayName("是否隐藏")]
        [Description("是否隐藏")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("IsHide", "是否隐藏", "int")]
        public Int32 IsHide { get { return _IsHide; } set { if (OnPropertyChanging(__.IsHide, value)) { _IsHide = value; OnPropertyChanged(__.IsHide); } } }

        private Int32 _IsDel;
        /// <summary>是否删除,已经删除到回收站</summary>
        [DisplayName("是否删除")]
        [Description("是否删除,已经删除到回收站")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("IsDel", "是否删除,已经删除到回收站", "int")]
        public Int32 IsDel { get { return _IsDel; } set { if (OnPropertyChanging(__.IsDel, value)) { _IsDel = value; OnPropertyChanged(__.IsDel); } } }

        private Int32 _IsTop;
        /// <summary>是否置顶</summary>
        [DisplayName("是否置顶")]
        [Description("是否置顶")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("IsTop", "是否置顶", "int")]
        public Int32 IsTop { get { return _IsTop; } set { if (OnPropertyChanging(__.IsTop, value)) { _IsTop = value; OnPropertyChanged(__.IsTop); } } }

        private Int32 _IsComment;
        /// <summary>是否允许评论</summary>
        [DisplayName("是否允许评论")]
        [Description("是否允许评论")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("IsComment", "是否允许评论", "int")]
        public Int32 IsComment { get { return _IsComment; } set { if (OnPropertyChanging(__.IsComment, value)) { _IsComment = value; OnPropertyChanged(__.IsComment); } } }

        private Int32 _Hits;
        /// <summary>点击数量</summary>
        [DisplayName("点击数量")]
        [Description("点击数量")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Hits", "点击数量", "int")]
        public Int32 Hits { get { return _Hits; } set { if (OnPropertyChanging(__.Hits, value)) { _Hits = value; OnPropertyChanged(__.Hits); } } }

        private Int32 _Sequence;
        /// <summary>排序</summary>
        [DisplayName("排序")]
        [Description("排序")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Sequence", "排序", "int")]
        public Int32 Sequence { get { return _Sequence; } set { if (OnPropertyChanging(__.Sequence, value)) { _Sequence = value; OnPropertyChanged(__.Sequence); } } }

        private String _Icon;
        /// <summary>图标</summary>
        [DisplayName("图标")]
        [Description("图标")]
        [DataObjectField(false, false, true, 100)]
        [BindColumn("Icon", "图标", "nvarchar(100)")]
        public String Icon { get { return _Icon; } set { if (OnPropertyChanging(__.Icon, value)) { _Icon = value; OnPropertyChanged(__.Icon); } } }

        private String _Pic;
        /// <summary>图片</summary>
        [DisplayName("图片")]
        [Description("图片")]
        [DataObjectField(false, false, true, 250)]
        [BindColumn("Pic", "图片", "nvarchar(250)")]
        public String Pic { get { return _Pic; } set { if (OnPropertyChanging(__.Pic, value)) { _Pic = value; OnPropertyChanged(__.Pic); } } }

        private String _Tags;
        /// <summary>TAG</summary>
        [DisplayName("TAG")]
        [Description("TAG")]
        [DataObjectField(false, false, true, 250)]
        [BindColumn("Tags", "TAG", "nvarchar(250)")]
        public String Tags { get { return _Tags; } set { if (OnPropertyChanging(__.Tags, value)) { _Tags = value; OnPropertyChanged(__.Tags); } } }

        private DateTime _AddTime;
        /// <summary>添加时间</summary>
        [DisplayName("添加时间")]
        [Description("添加时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("AddTime", "添加时间", "datetime")]
        public DateTime AddTime { get { return _AddTime; } set { if (OnPropertyChanging(__.AddTime, value)) { _AddTime = value; OnPropertyChanged(__.AddTime); } } }

        private DateTime _UpdateTime;
        /// <summary>时间</summary>
        [DisplayName("时间")]
        [Description("时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("UpdateTime", "时间", "datetime")]
        public DateTime UpdateTime { get { return _UpdateTime; } set { if (OnPropertyChanging(__.UpdateTime, value)) { _UpdateTime = value; OnPropertyChanged(__.UpdateTime); } } }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case __.Id : return _Id;
                    case __.KId : return _KId;
                    case __.Title : return _Title;
                    case __.EnTitle : return _EnTitle;
                    case __.SubTitle : return _SubTitle;
                    case __.Content : return _Content;
                    case __.Keyword : return _Keyword;
                    case __.LinkURL : return _LinkURL;
                    case __.IsHide : return _IsHide;
                    case __.IsDel : return _IsDel;
                    case __.IsTop : return _IsTop;
                    case __.IsComment : return _IsComment;
                    case __.Hits : return _Hits;
                    case __.Sequence : return _Sequence;
                    case __.Icon : return _Icon;
                    case __.Pic : return _Pic;
                    case __.Tags : return _Tags;
                    case __.AddTime : return _AddTime;
                    case __.UpdateTime : return _UpdateTime;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.Id : _Id = Convert.ToInt32(value); break;
                    case __.KId : _KId = Convert.ToInt32(value); break;
                    case __.Title : _Title = Convert.ToString(value); break;
                    case __.EnTitle : _EnTitle = Convert.ToString(value); break;
                    case __.SubTitle : _SubTitle = Convert.ToString(value); break;
                    case __.Content : _Content = Convert.ToString(value); break;
                    case __.Keyword : _Keyword = Convert.ToString(value); break;
                    case __.LinkURL : _LinkURL = Convert.ToString(value); break;
                    case __.IsHide : _IsHide = Convert.ToInt32(value); break;
                    case __.IsDel : _IsDel = Convert.ToInt32(value); break;
                    case __.IsTop : _IsTop = Convert.ToInt32(value); break;
                    case __.IsComment : _IsComment = Convert.ToInt32(value); break;
                    case __.Hits : _Hits = Convert.ToInt32(value); break;
                    case __.Sequence : _Sequence = Convert.ToInt32(value); break;
                    case __.Icon : _Icon = Convert.ToString(value); break;
                    case __.Pic : _Pic = Convert.ToString(value); break;
                    case __.Tags : _Tags = Convert.ToString(value); break;
                    case __.AddTime : _AddTime = Convert.ToDateTime(value); break;
                    case __.UpdateTime : _UpdateTime = Convert.ToDateTime(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得文章字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field Id = FindByName(__.Id);

            /// <summary>栏目ID</summary>
            public static readonly Field KId = FindByName(__.KId);

            /// <summary>标题</summary>
            public static readonly Field Title = FindByName(__.Title);

            /// <summary>英文标题</summary>
            public static readonly Field EnTitle = FindByName(__.EnTitle);

            /// <summary>副标题</summary>
            public static readonly Field SubTitle = FindByName(__.SubTitle);

            /// <summary>内容</summary>
            public static readonly Field Content = FindByName(__.Content);

            /// <summary>描述</summary>
            public static readonly Field Keyword = FindByName(__.Keyword);

            /// <summary>跳转链接</summary>
            public static readonly Field LinkURL = FindByName(__.LinkURL);

            /// <summary>是否隐藏</summary>
            public static readonly Field IsHide = FindByName(__.IsHide);

            /// <summary>是否删除,已经删除到回收站</summary>
            public static readonly Field IsDel = FindByName(__.IsDel);

            /// <summary>是否置顶</summary>
            public static readonly Field IsTop = FindByName(__.IsTop);

            /// <summary>是否允许评论</summary>
            public static readonly Field IsComment = FindByName(__.IsComment);

            /// <summary>点击数量</summary>
            public static readonly Field Hits = FindByName(__.Hits);

            /// <summary>排序</summary>
            public static readonly Field Sequence = FindByName(__.Sequence);

            /// <summary>图标</summary>
            public static readonly Field Icon = FindByName(__.Icon);

            /// <summary>图片</summary>
            public static readonly Field Pic = FindByName(__.Pic);

            /// <summary>TAG</summary>
            public static readonly Field Tags = FindByName(__.Tags);

            /// <summary>添加时间</summary>
            public static readonly Field AddTime = FindByName(__.AddTime);

            /// <summary>时间</summary>
            public static readonly Field UpdateTime = FindByName(__.UpdateTime);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得文章字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String Id = "Id";

            /// <summary>栏目ID</summary>
            public const String KId = "KId";

            /// <summary>标题</summary>
            public const String Title = "Title";

            /// <summary>英文标题</summary>
            public const String EnTitle = "EnTitle";

            /// <summary>副标题</summary>
            public const String SubTitle = "SubTitle";

            /// <summary>内容</summary>
            public const String Content = "Content";

            /// <summary>描述</summary>
            public const String Keyword = "Keyword";

            /// <summary>跳转链接</summary>
            public const String LinkURL = "LinkURL";

            /// <summary>是否隐藏</summary>
            public const String IsHide = "IsHide";

            /// <summary>是否删除,已经删除到回收站</summary>
            public const String IsDel = "IsDel";

            /// <summary>是否置顶</summary>
            public const String IsTop = "IsTop";

            /// <summary>是否允许评论</summary>
            public const String IsComment = "IsComment";

            /// <summary>点击数量</summary>
            public const String Hits = "Hits";

            /// <summary>排序</summary>
            public const String Sequence = "Sequence";

            /// <summary>图标</summary>
            public const String Icon = "Icon";

            /// <summary>图片</summary>
            public const String Pic = "Pic";

            /// <summary>TAG</summary>
            public const String Tags = "Tags";

            /// <summary>添加时间</summary>
            public const String AddTime = "AddTime";

            /// <summary>时间</summary>
            public const String UpdateTime = "UpdateTime";
        }
        #endregion
    }

    /// <summary>文章接口</summary>
    public partial interface IArticle
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 Id { get; set; }

        /// <summary>栏目ID</summary>
        Int32 KId { get; set; }

        /// <summary>标题</summary>
        String Title { get; set; }

        /// <summary>英文标题</summary>
        String EnTitle { get; set; }

        /// <summary>副标题</summary>
        String SubTitle { get; set; }

        /// <summary>内容</summary>
        String Content { get; set; }

        /// <summary>描述</summary>
        String Keyword { get; set; }

        /// <summary>跳转链接</summary>
        String LinkURL { get; set; }

        /// <summary>是否隐藏</summary>
        Int32 IsHide { get; set; }

        /// <summary>是否删除,已经删除到回收站</summary>
        Int32 IsDel { get; set; }

        /// <summary>是否置顶</summary>
        Int32 IsTop { get; set; }

        /// <summary>是否允许评论</summary>
        Int32 IsComment { get; set; }

        /// <summary>点击数量</summary>
        Int32 Hits { get; set; }

        /// <summary>排序</summary>
        Int32 Sequence { get; set; }

        /// <summary>图标</summary>
        String Icon { get; set; }

        /// <summary>图片</summary>
        String Pic { get; set; }

        /// <summary>TAG</summary>
        String Tags { get; set; }

        /// <summary>添加时间</summary>
        DateTime AddTime { get; set; }

        /// <summary>时间</summary>
        DateTime UpdateTime { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}