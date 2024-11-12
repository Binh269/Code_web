window.onload = function () {
    alert("Chào mừng bạn đến với trang web tính tiền máy tính!");
};

$(document).ready(function () {
    function send_data() {
        var gui_di = {
            gio: $('#gio').val(),
            loaimay: $('input[name="loaimay"]:checked').val(),
            dieuhoa: $('#dieuhoa').is(':checked')
        };

        if (isNaN(gui_di.gio)) {
            alert('Số giờ chơi chưa nhập đúng!');
            $('#gio').focus();
            return;
        }

        if (typeof gui_di.loaimay === 'undefined') {
            alert('Bạn phải chọn loại máy!');
            return;
        }

        $.post("api.aspx", gui_di, function (data, status) {
            var kq = '';
            if (data.indexOf('Có lỗi') >= 0) {
                kq = "Có lỗi: " + data;
            } else {
                kq = "Tổng tiền là: " + data;
            }
            alert(kq);
        });
    }

    $("#tinhtien").click(function () {
        send_data();
    });
});
