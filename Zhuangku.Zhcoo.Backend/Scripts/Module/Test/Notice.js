'use strict';
$(function () {
    let $root = $('#Tab_Content_tishikongjian');
    var $BtnAlert = $('#BtnAlert', $root);
    $BtnAlert.click(function () {
        let $this = $(this).blur();
        zk.alert({
            title: '删除确认'
            , message: '确定要删除该条记录'
            , desc: '记录编号：AK9842'
            , okText: '朕知道了！！'
            , callback: function () {
                alert('已删除');
            }
        });
    });
});