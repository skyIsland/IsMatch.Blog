using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace IsMatch.Core
{
    /// <summary>文章栏目</summary>
    [Serializable]
    [DataObject]
    [Description("文章栏目")]
    [BindTable("ArticleCategory", Description = "文章栏目", ConnName = "mssqlconn", DbType = DatabaseType.SqlServer)]
    public partial class ArticleCategory : IArticleCategory
    {
        #region 属性
        private Int32 _Id;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("Id", "编号", "int")]
        public Int32 Id { get { return _Id; } set { if (OnPropertyChanging(__.Id, value)) { _Id = value; OnPropertyChanged(__.Id); } } }

        private String _KindName;
        /// <summary>栏目名称</summary>
        [DisplayName("栏目名称")]
        [Description("栏目名称")]
        [DataObjectField(false, false, true, 250)]
        [BindColumn("KindName", "栏目名称", "nvarchar(250)")]
        public String KindName { get { return _KindName; } set { if (OnPropertyChanging(__.KindName, value)) { _KindName = value; OnPropertyChanged(__.KindName); } } }

        private String _KindEnName;
        /// <summary>栏目英文名</summary>
        [DisplayName("栏目英文名")]
        [Description("栏目英文名")]
        [DataObjectField(false, false, true, 250)]
        [BindColumn("KindEnName", "栏目英文名", "nvarchar(250)")]
        public String KindEnName { get { return _KindEnName; } set { if (OnPropertyChanging(__.KindEnName, value)) { _KindEnName = value; OnPropertyChanged(__.KindEnName); } } }

        private String _Keyword;
        /// <summary>描述</summary>
        [DisplayName("描述")]
        [Description("描述")]
        [DataObjectField(false, false, true, 250)]
        [BindColumn("Keyword", "描述", "nvarchar(250)")]
        public String Keyword { get { return _Keyword; } set { if (OnPropertyChanging(__.Keyword, value)) { _Keyword = value; OnPropertyChanged(__.Keyword); } } }

        private String _Description;
        /// <summary>介绍</summary>
        [DisplayName("介绍")]
        [Description("介绍")]
        [DataObjectField(false, false, true, 250)]
        [BindColumn("Description", "介绍", "nvarchar(250)")]
        public String Description { get { return _Description; } set { if (OnPropertyChanging(__.Description, value)) { _Description = value; OnPropertyChanged(__.Description); } } }

        private String _LinkURL;
        /// <summary>跳转链接</summary>
        [DisplayName("跳转链接")]
        [Description("跳转链接")]
        [DataObjectField(false, false, true, 250)]
        [BindColumn("LinkURL", "跳转链接", "nvarchar(250)")]
        public String LinkURL { get { return _LinkURL; } set { if (OnPropertyChanging(__.LinkURL, value)) { _LinkURL = value; OnPropertyChanged(__.LinkURL); } } }

        private String _TitleColor;
        /// <summary>类别名称颜色</summary>
        [DisplayName("类别名称颜色")]
        [Description("类别名称颜色")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("TitleColor", "类别名称颜色", "nvarchar(50)")]
        public String TitleColor { get { return _TitleColor; } set { if (OnPropertyChanging(__.TitleColor, value)) { _TitleColor = value; OnPropertyChanged(__.TitleColor); } } }

        private Int32 _IsList;
        /// <summary>是否为列表页面</summary>
        [DisplayName("是否为列表页面")]
        [Description("是否为列表页面")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("IsList", "是否为列表页面", "int")]
        public Int32 IsList { get { return _IsList; } set { if (OnPropertyChanging(__.IsList, value)) { _IsList = value; OnPropertyChanged(__.IsList); } } }

        private Int32 _PageSize;
        /// <summary>每页显示数量</summary>
        [DisplayName("每页显示数量")]
        [Description("每页显示数量")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("PageSize", "每页显示数量", "int")]
        public Int32 PageSize { get { return _PageSize; } set { if (OnPropertyChanging(__.PageSize, value)) { _PageSize = value; OnPropertyChanged(__.PageSize); } } }

        private Int32 _PId;
        /// <summary>上级ID</summary>
        [DisplayName("上级ID")]
        [Description("上级ID")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("PId", "上级ID", "int")]
        public Int32 PId { get { return _PId; } set { if (OnPropertyChanging(__.PId, value)) { _PId = value; OnPropertyChanged(__.PId); } } }

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

        private Int32 _Sequence;
        /// <summary>排序</summary>
        [DisplayName("排序")]
        [Description("排序")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Sequence", "排序", "int")]
        public Int32 Sequence { get { return _Sequence; } set { if (OnPropertyChanging(__.Sequence, value)) { _Sequence = value; OnPropertyChanged(__.Sequence); } } }
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
                    case __.KindName : return _KindName;
                    case __.KindEnName : return _KindEnName;
                    case __.Keyword : return _Keyword;
                    case __.Description : return _Description;
                    case __.LinkURL : return _LinkURL;
                    case __.TitleColor : return _TitleColor;
                    case __.IsList : return _IsList;
                    case __.PageSize : return _PageSize;
                    case __.PId : return _PId;
                    case __.IsHide : return _IsHide;
                    case __.IsDel : return _IsDel;
                    case __.Sequence : return _Sequence;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.Id : _Id = Convert.ToInt32(value); break;
                    case __.KindName : _KindName = Convert.ToString(value); break;
                    case __.KindEnName : _KindEnName = Convert.ToString(value); break;
                    case __.Keyword : _Keyword = Convert.ToString(value); break;
                    case __.Description : _Description = Convert.ToString(value); break;
                    case __.LinkURL : _LinkURL = Convert.ToString(value); break;
                    case __.TitleColor : _TitleColor = Convert.ToString(value); break;
                    case __.IsList : _IsList = Convert.ToInt32(value); break;
                    case __.PageSize : _PageSize = Convert.ToInt32(value); break;
                    case __.PId : _PId = Convert.ToInt32(value); break;
                    case __.IsHide : _IsHide = Convert.ToInt32(value); break;
                    case __.IsDel : _IsDel = Convert.ToInt32(value); break;
                    case __.Sequence : _Sequence = Convert.ToInt32(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得文章栏目字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field Id = FindByName(__.Id);

            /// <summary>栏目名称</summary>
            public static readonly Field KindName = FindByName(__.KindName);

            /// <summary>栏目英文名</summary>
            public static readonly Field KindEnName = FindByName(__.KindEnName);

            /// <summary>描述</summary>
            public static readonly Field Keyword = FindByName(__.Keyword);

            /// <summary>介绍</summary>
            public static readonly Field Description = FindByName(__.Description);

            /// <summary>跳转链接</summary>
            public static readonly Field LinkURL = FindByName(__.LinkURL);

            /// <summary>类别名称颜色</summary>
            public static readonly Field TitleColor = FindByName(__.TitleColor);

            /// <summary>是否为列表页面</summary>
            public static readonly Field IsList = FindByName(__.IsList);

            /// <summary>每页显示数量</summary>
            public static readonly Field PageSize = FindByName(__.PageSize);

            /// <summary>上级ID</summary>
            public static readonly Field PId = FindByName(__.PId);

            /// <summary>是否隐藏</summary>
            public static readonly Field IsHide = FindByName(__.IsHide);

            /// <summary>是否删除,已经删除到回收站</summary>
            public static readonly Field IsDel = FindByName(__.IsDel);

            /// <summary>排序</summary>
            public static readonly Field Sequence = FindByName(__.Sequence);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得文章栏目字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String Id = "Id";

            /// <summary>栏目名称</summary>
            public const String KindName = "KindName";

            /// <summary>栏目英文名</summary>
            public const String KindEnName = "KindEnName";

            /// <summary>描述</summary>
            public const String Keyword = "Keyword";

            /// <summary>介绍</summary>
            public const String Description = "Description";

            /// <summary>跳转链接</summary>
            public const String LinkURL = "LinkURL";

            /// <summary>类别名称颜色</summary>
            public const String TitleColor = "TitleColor";

            /// <summary>是否为列表页面</summary>
            public const String IsList = "IsList";

            /// <summary>每页显示数量</summary>
            public const String PageSize = "PageSize";

            /// <summary>上级ID</summary>
            public const String PId = "PId";

            /// <summary>是否隐藏</summary>
            public const String IsHide = "IsHide";

            /// <summary>是否删除,已经删除到回收站</summary>
            public const String IsDel = "IsDel";

            /// <summary>排序</summary>
            public const String Sequence = "Sequence";
        }
        #endregion
    }

    /// <summary>文章栏目接口</summary>
    public partial interface IArticleCategory
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 Id { get; set; }

        /// <summary>栏目名称</summary>
        String KindName { get; set; }

        /// <summary>栏目英文名</summary>
        String KindEnName { get; set; }

        /// <summary>描述</summary>
        String Keyword { get; set; }

        /// <summary>介绍</summary>
        String Description { get; set; }

        /// <summary>跳转链接</summary>
        String LinkURL { get; set; }

        /// <summary>类别名称颜色</summary>
        String TitleColor { get; set; }

        /// <summary>是否为列表页面</summary>
        Int32 IsList { get; set; }

        /// <summary>每页显示数量</summary>
        Int32 PageSize { get; set; }

        /// <summary>上级ID</summary>
        Int32 PId { get; set; }

        /// <summary>是否隐藏</summary>
        Int32 IsHide { get; set; }

        /// <summary>是否删除,已经删除到回收站</summary>
        Int32 IsDel { get; set; }

        /// <summary>排序</summary>
        Int32 Sequence { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}