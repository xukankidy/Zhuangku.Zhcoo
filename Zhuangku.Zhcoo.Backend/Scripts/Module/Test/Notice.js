'use strict';
$(function () {
    let $root = $('#Tab_Content_tishikongjian');

    var $BtnAlert = $('#BtnAlert', $root);
    $BtnAlert.click(function () {
        let $this = $(this).blur();
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

    var $BtnPopup = $('#BtnPopup', $root);
    $BtnPopup.click(function () {
        let $this = $(this).blur();
        zk.popup({
            text: '这是一条消息'
            , url: 'http://www.baidu.com'
            , type: 'tab'
        });
    });

    let $TxtSearchStartTime = zk.datetimepicker({
        jqueryObj: $('#TxtSearchStartTime', $root)
        , format: 'yyyy-mm-dd'
    });
    let $TxtSearchEndTime = zk.datetimepicker({
        jqueryObj: $('#TxtSearchEndTime', $root)
        , format: 'yyyy-mm-dd hh:ii:ss'
    });
    let $BtnSearch = $('#BtnSearch', $root)
        .click(function () {
            let $this = $(this).blur();
            alert($TxtSearchEndTime.val());
        });
    let $CityId = zk.chosen({
        jqueryObj: $('#CityId', $root)
    });
    let $CityId1 = zk.chosen({
        jqueryObj: $('#CityId1', $root)
    });

    let $BtnOk = $('#BtnOk', $root)
        .click(function () {
            let $this = $(this).blur();
            alert($CityId.val());
        });
});