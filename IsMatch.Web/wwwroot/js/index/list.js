layui.config({
    base: '../../js/util/'
}).define(['jquery','mm','laypage','layer'], function (exports) {
    var mm = layui.mm, laypage = layui.laypage, layer = layui.layer, $ = layui.jquery;
    var list = {
        init: function () {
            var that = this;
            $('.layui-breadcrumb > a').on('click', function () {
                $(this).addClass('active').siblings().removeClass('active');
                that.render($(this).data('id') || 6, 1);
            });
            $('.layui-breadcrumb > a:first-child').trigger('click');
        },
        render: function (category, pageIndex) {
            if (category) {
                mm.request({
                    url: '/Home/GetList/' + category,
                    data: {
                        PageIndex: pageIndex
                    },
                    success: function (res) {
                        var html = laytplCont.innerHTML;
                        html = mm.renderHtml(html, res.data);
                        $('.list-item').html(html);
                        laypage.render({
                            elem: 'pager',
                            count: res.TotalCount,
                            limit: res.PageSize,
                            curr: res.PageIndex,
                            jump: function(obj, first) {
                                //首次不执行
                                if (!first) {
                                    render(category, obj.curr);
                                }
                            }
                        });
                    },
                    error: function (msg) {
                        layer.alert('请求数据发生错误，原因：' + msg);
                    }
                });
            }
        }
    };
    exports('list', list);
});