'use strict';
$(function () {
    let $Username = $('#Username');
    let $Password = $('#Password');
    let $BtnLogin = $('#BtnLogin');

    $BtnLogin.click(function () {
        let $this = $(this);
        if (!inputValidate()) {
            return;
        }
        $this.attr('disabled', 'disabled');
        location.href = '/Framework/Index/';
    });
    $Username.keydown(function (event) {
        if (event.keyCode == 13) {
            $Password.focus();
        }
    });
    $Password.keydown(function (event) {
        if (event.keyCode == 13) {
            $BtnLogin.click();
        }
    });
    $Username.focus();

    function inputValidate() {
        if ($.trim($Username.val()) == '') {
            alert('必须输入用户名');
            $Username.focus();
            return false;
        }
        if ($.trim($Password.val()) == '') {
            alert('必须输入密码');
            $Password.focus();
            return false;
        }

        return true;
    }
});