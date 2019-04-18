'use strict';
$(function () {
    let $root = $('#Panel_Modal_TestModal');
    let $closePanelModal = $('.zk-panel-titlebarOption', $root);
    function closePanelModal() {
        $closePanelModal.click();
    }
    let $BtnClose = $('#BtnClose', $root)
        .click(function () {
            let $this = $(this).blur();
            closePanelModal();
        });
    let $BtnSuccess = $('#BtnSuccess', $root)
        .click(function () {
            let $this = $(this).blur();
            zk.alert({
                title: '信息'
                , titleIcon: 'info'
                , bigIcon: 'question'
                , message: '确定保存'
                , desc: '您确定要保存该条目'
                , btnText: '确定'
                , callback: function () {
                    closePanelModal();
                }
            });
        });
});