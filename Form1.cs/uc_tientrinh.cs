using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace form1.cs
{
    public partial class uc_tientrinh : UserControl
    {
        public uc_tientrinh()
        {
            InitializeComponent();
        }

        public void SetData(string tenKhoaHoc, string duongDanAnh, int tuoi, int phanTram)
        {
            label_namekhoahoccanhangv.Text = tenKhoaHoc;
            label_tientrinh_hoccanhangv.Text = $"Tiến Trình : {phanTram}%";
            label_agehocchunggv.Text = $"Age: {tuoi}+";

            if (!string.IsNullOrEmpty(duongDanAnh) && File.Exists(duongDanAnh))
            {
                pictureBox1_hoccanhangv.Image = Image.FromFile(duongDanAnh);
                pictureBox1_hoccanhangv.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1_hoccanhangv.Image = null; // hoặc set hình mặc định tại đây
            }
        }

        private void btn_khoahoccanhan1_Click(object sender, EventArgs e)
        {

        }
        public void SetData(KhoaHoc kh)
        {
            label_namekhoahoccanhangv.Text = kh.TenKhoaHoc;
            label_trangthai_hoccanhangv.Text = kh.TrangThai;
            label_tientrinh_hoccanhangv.Text = $"Tiến Trình : {kh.TienTrinh}%";
            label_agehocchunggv.Text = $"Age: {kh.DoTuoi}+";

            if (kh.HinhAnh != null)
            {
                pictureBox1_hoccanhangv.Image = kh.HinhAnh;
                pictureBox1_hoccanhangv.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (kh != null && kh.HinhAnh != null)
            {
                pictureBox1_hoccanhangv.Image = kh.HinhAnh;
            }

        }

    }
}
