using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ThuVienTinhTien;


namespace web_api
{
    public partial class api : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int send = 0;
            try
            {
                double gio = double.Parse(this.Request["gio"]);
                send = 1;
                string loaiMayStr = this.Request["loaimay"];
                send = 2;
                bool dieuHoa = bool.Parse(this.Request["dieuhoa"]);
                send = 3;

                LoaiMay loaiMay;
                if (loaiMayStr == "Vip")
                {
                    loaiMay = LoaiMay.Vip;
                }
                else
                {
                    loaiMay = LoaiMay.Thuong;
                }

                double tongTien = TinhTien.TinhTongTien(loaiMay, gio, dieuHoa);

                string ketqua = $"Tổng tiền: {tongTien}";
                this.Response.Write(ketqua);
            }
            catch (Exception ex)
            {
                string kq;
                switch (send)
                {
                    case 0:
                        kq = "Có lỗi khi nhập số giờ";
                        break;
                    case 1:
                        kq = "Có lỗi khi chọn loại máy";
                        break;
                    case 2:
                        kq = "Có lỗi khi nhập thông tin điều hòa";
                        break;
                    default:
                        kq = $"Có lỗi không xác định: {ex.Message}";
                        break;
                }
                this.Response.Write(kq);
            }
    }
    }
}