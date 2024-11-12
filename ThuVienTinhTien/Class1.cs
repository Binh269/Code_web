using System;
using System.Collections.Generic;
using System.Text;


namespace ThuVienTinhTien
{
    public enum LoaiMay
    {
        Vip,
        Thuong
    }

    public class TinhTien
    {
        private const int GiaMayVip = 20000;
        private const int GiaMayThuong = 15000;
        private const int GiaDieuHoa = 5000;

        public static double TinhTongTien(LoaiMay May, double Gio, bool DieuHoa)
        {
            double giaTien = May == LoaiMay.Vip ? GiaMayVip : GiaMayThuong;
            if (DieuHoa)
            {
                giaTien += GiaDieuHoa;
            }
            return giaTien * Gio;
        }
    }
}

