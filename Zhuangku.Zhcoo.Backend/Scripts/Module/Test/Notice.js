'use strict';
$(function () {
    let $root = $('#Tab_Content_tishikongjian');

    var $BtnAlert = $('#BtnAlert', $root);
    $BtnAlert.click(function () {
        let $this = $(this).blur();
        //zk.alert({
        //    title: '删除确认'
        //    , message: '确定要删除该条记录'
        //    , desc: '记录编号：AK9842'
        //    , okText: '朕知道了！！'
        //    , callback: function () {
        //        alert('已删除');
        //    }
        //});
        zk.alert({
            title: '限制'
            , titleIcon: 'list'
            , bigIcon: 'warning'
            , message: '这里是标题'
            , desc: '限制条件不明显'
            , btnText: '我知道了'
            , callback: function () {
                alert('你点击了确定');
            }
        });
    });

    var $BtnConfirm = $('#BtnConfirm', $root);
    $BtnConfirm.click(function () {
        let $this = $(this).blur();
        zk.confirm({
            title: '退出系统确认'
            , titleIcon: 'info'
            , bigIcon: 'question'
            , message: '确定安全要退出系统'
            , desc: '服务器将清空上次登录的所有在线状态'
            , okBtnText: '马上退出'
            , cancelBtnText: '再工作一会儿'
            , okCallback: function () {
                alert('成功退出');
            }
            , cancelCallback: function () {
            }
        });
    });

    var $BtnMessage = $('#BtnMessage', $root);
    $BtnMessage.click(function () {
        let $this = $(this).blur();
        zk.message({
            type: 'success'
            , message: '操作成功'
        });
    });
});