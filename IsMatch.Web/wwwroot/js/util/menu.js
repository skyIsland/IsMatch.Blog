/**
 @Name: layuiSimpleBlog - 极简博客模板
 @Author: xuzhiwen
 @Copyright: layui.com
 
 */
layui.define(['jquery'], function (exports) {
    var $ = layui.$;
    var menu = {
        init: function () {
            $('.menu').on('click', function () {
                if ($(this).hasClass('on')) {
                    $(this).removeClass('on');
                    $('.header-down-nav').removeClass('layui-show');
                } else {
                    $(this).addClass('on');
                    $('.header-down-nav').addClass('layui-show');
                }
            });
            window.onresize = function () {
                var curwidth = document.documentElement.clientWidth;
                if (curwidth > 760) {
                    $('.header-down-nav').removeClass('layui-show');
                    $('.menu').removeClass('on');
                }
            };
            var count = $('.list-cont .cont').length;
            $('.volume span').text(count);
            $('.op-list .like').on('click', function () {
                var oSpan = $(this).children('span');
                var num = parseInt($(oSpan).text());
                var off = $(this).attr('off');
                if (off) {
                    $(this).removeClass('active');
                    off = true;
                    $(oSpan).text(num - 1);
                    $(this).attr('off', '');
                } else {
                    $(this).addClass('active');
                    off = false;
                    $(oSpan).text(num + 1);
                    $(this).attr('off', 'true');
                }
            });
        }        
    };
    exports('menu', menu);
});