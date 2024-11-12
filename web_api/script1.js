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

        $.ajax({
            url: "api_json.aspx",
            type: "POST",
            data: JSON.stringify(gui_di), 
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                if (data.ok) {
                    alert("Tổng tiền là: " + data.data.tongTien);
                } else {
                    alert("Có lỗi: " + data.error);
                }
            },
            error: function (xhr, status, error) {
                alert("Có lỗi xảy ra khi gửi dữ liệu: " + error);
            }
        });
    }

    $("#tinhtien").click(function () {
        send_data();
    });
});
