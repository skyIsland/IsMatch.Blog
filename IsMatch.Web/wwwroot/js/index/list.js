layui.define(['mm'], function (exports) {
    var mm = layui.mm;
    var list = {
        render: function (category, pageIndex) {
            // todo
            if (category) {
                mm.request({
                    url: '/Home/GetList/' + category,
                    data: {
                        PageIndex: pageIndex
                    },
                    success: function (res) {
                        var html = laytplCont.innerHTML;
                        html = mm.renderHtml(html, res.Data);
                        $('.list-item').html(html);
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