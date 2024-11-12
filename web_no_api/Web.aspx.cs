using System;
using System.Web.UI;
using ThuVienTinhTien;

namespace web_no_api
{
    public partial class Web : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void tinhtien_Click(object sender, EventArgs e)
        {
            int send = 0;
            try
            {
                double gio_choi = double.Parse(gio.Text);
                send = 1;

                LoaiMay loaiMay;
                if (vip.Checked)
                {
                    loaiMay = LoaiMay.Vip;
                }
                else if (thuong.Checked)
                {
                    loaiMay = LoaiMay.Thuong;
                }
                else
                {
                    throw new Exception("Chưa chọn loại máy!");
                }
                send = 2;

                bool dieuHoa = dieuhoa.Checked;
                send = 3;

                double tongTien = TinhTien.TinhTongTien(loaiMay, gio_choi, dieuHoa);

                string ketqua = $"Tổng tiền: {tongTien} VND";
                phaitra.InnerHtml = $"{ketqua}";
            }
            catch (Exception ex)
            {
                switch (send)
                {
                    case 0:
                        phaitra.InnerHtml = "Có lỗi khi nhập số giờ";
                        break;
                    case 1:
                        phaitra.InnerHtml = "Có lỗi khi chọn loại máy";
                        break;
                    case 2:
                        phaitra.InnerHtml = "Có lỗi khi nhập thông tin điều hòa";
                        break;
                    default:
                        phaitra.InnerHtml = $"Có lỗi không xác định: {ex.Message}";
                        break;
                }
                }
        }
    }
}
