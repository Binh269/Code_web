using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ThuVienTinhTien;
namespace AppGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_gio.Text = "1";
        }

        private void bt_up_Click(object sender, EventArgs e)
        {
            int tang;
            if (int.TryParse(txt_gio.Text, out tang))
            {
                tang++;
                txt_gio.Text = tang.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ.");
                txt_gio.Text = "1";
            }
        }

        private void bt_down_Click(object sender, EventArgs e)
        {
            int giam;
            if (int.TryParse(txt_gio.Text, out giam))
            {
                giam--;
                if (giam < 0)
                {
                    giam = 0;
                }
                txt_gio.Text = giam.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ.");
                txt_gio.Text = "1";
            }
        }

        private void bt_thanhtoan_Click(object sender, EventArgs e)
        {
            int send = 0;
            bool dieuHoa = false;
            LoaiMay May = LoaiMay.Vip;
            try
            {
                int giochoi;
                if (int.TryParse(txt_gio.Text, out giochoi))
                {
                    
                }
                send = 1;

                if (rbt_mayvip.Checked)
                {
                    May = LoaiMay.Vip;
                }
                else if (rbt_maythuong.Checked)
                {
                    May = LoaiMay.Thuong;
                }
                else
                {
                    MessageBox.Show("Chưa chọn loại máy!");
                    return;
                }
                send = 2;

                if (rbt_codh.Checked)
                {
                    dieuHoa = true;
                }
                else if (rbt_kodh.Checked)
                {
                    dieuHoa = false;

                }
                else
                {
                    MessageBox.Show("Bạn có dùng điều hòa không ?");
                    return;
                }
                send = 3;

                double tongTien = TinhTien.TinhTongTien(May, giochoi, dieuHoa);

                string ketqua = $"Tổng tiền : {tongTien} VND";
                MessageBox.Show(ketqua);
            }
            catch (Exception ex)
            {
                switch (send)
                {
                    case 0:
                        MessageBox.Show("Có lỗi khi nhập số giờ");
                        break;
                    case 1:
                        MessageBox.Show("Có lỗi khi chọn loại máy");
                        break;
                    case 2:
                        MessageBox.Show("Có lỗi khi nhập thông tin điều hòa");
                        break;
                    default:
                        MessageBox.Show($"Có lỗi không xác định: {ex.Message}");
                        break;
                }
            }
        }

        private void biết_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
