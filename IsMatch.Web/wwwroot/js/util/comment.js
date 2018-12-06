/**
 
 @Name: layuiSimpleBlog - 极简博客模板
 @Author: xuzhiwen
 @Copyright: layui.com
 
 */
layui.define(['mm', 'jquery'], function (exports) {
    var $ = layui.$, mm = layui.mm;
    var comment = {
        off: function () {
            $('.off').on('click', function () {
                var off = $(this).attr('off');
                var chi = $(this).children('i');
                var text = $(this).children('span');
                var cont = $(this).parents('.item').siblings('.review-version');
                if (off) {
                    $(text).text('展开');
                    $(chi).attr('class', 'layui-icon layui-icon-down');
                    $(this).attr('off', '');
                    $(cont).addClass('layui-hide');
                } else {
                    $(text).text('收起');
                    $(chi).attr('class', 'layui-icon layui-icon-up');
                    $(this).attr('off', 'true');
                    $(cont).removeClass('layui-hide');
                }
            });
        },       
        submit: function () {
            $('.definite').on('click', function (e) {
                var event = e || event;
                event.preventDefault();
                var $listcont = $(this).parents('.form').siblings('.list-cont').length ? $(this).parents('.form').siblings('.list-cont') : $(this).parents('.form-box').siblings('.list-cont');
                console.log($listcont);
                var img = $(this).parents('form').siblings('img').attr('src');
                var textarea = $(this).parents('.layui-form-item').siblings('.layui-form-text').children('.layui-input-block').children('textarea');
                var name = $(textarea).val();
                var html = laytplCont.innerHTML;
                var data = {
                    avatar: img,
                    name: '吴亦凡',
                    cont: name
                };
                if (name) {
                    var cont = mm.renderHtml(html, data);
                    $listcont.prepend(cont);
                    var cunt = $(this).parents('.form-box').siblings('.volume').children('span');
                    var cunts = $(this).parents('.form-box').siblings('.list-cont').children('.cont').length;
                    textarea.val('');
                } else {
                    layer.msg('请输入内容');
                }
                cunt.text(cunts);
            });
        }
    };
    exports('comment', comment);
});