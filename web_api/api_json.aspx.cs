using System;
using System.IO;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using ThuVienTinhTien;

namespace web_api
{

    public partial class api_json : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int send = 0;
            try
            {
                string jsonString = new StreamReader(Request.InputStream).ReadToEnd();

                var data = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);

                double gio = double.Parse(data["gio"]);
                send = 1;
                string loaiMayStr = data["loaimay"];
                send = 2;
                bool dieuHoa = bool.Parse(data["dieuhoa"]);
                send = 3;

                LoaiMay loaiMay = (loaiMayStr == "Vip") ? LoaiMay.Vip : LoaiMay.Thuong;

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
