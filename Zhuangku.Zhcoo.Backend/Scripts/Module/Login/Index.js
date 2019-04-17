'use strict';
$(function () {
    let $Username = $('#Username');
    let $Password = $('#Password');
    let $BtnLogin = $('#BtnLogin');

    $BtnLogin.click(function () {
        location.href = '/Framework/Index/';
    });
    $Username.focus();
});