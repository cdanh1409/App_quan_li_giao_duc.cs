using System;
using System.Drawing;
using System.Windows.Forms;

namespace form1.cs
{
    public partial class F_MoTa : Form
    {
        private KhoaHoc khoaHoc;

        public F_MoTa(KhoaHoc kh)
        {
            InitializeComponent();
            khoaHoc = kh;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            Load += F_MoTa_Load;
        }

        private void F_MoTa_Load(object sender, EventArgs e)
        {
            HienThiThongTinKhoaHoc(khoaHoc);
        }

            private void HienThiThongTinKhoaHoc(KhoaHoc kh)
        {
            label_namekhoahoc.Text = kh.TenKhoaHoc;

            // Mô tả riêng cho từng khóa học
            if (kh.TenKhoaHoc == "Lập trình C cơ bản")
            {
                label_motakhoahoc.Text = "Khóa học lập trình C cho người mới bắt đầu. Khóa học này cung cấp kiến thức cơ bản và là nền tảng để bạn phát triển trên con đường lập trình.";
            }
            else if (kh.TenKhoaHoc == "Python nâng cao")
            {
                label_motakhoahoc.Text = "Khóa học Python nâng cao dành cho người đã có nền tảng cơ bản. Cung cấp kiến thức chuyên sâu về Python và ứng dụng thực tế trong xử lý dữ liệu, AI, Web,...";
            }
            else
            {
                label_motakhoahoc.Text = "Mô tả khóa học đang được cập nhật.";
            }

            label_tenGV.Text = "GV: Danh Cau Có";
            label_danhgia.Text = kh.DanhGia + " ★";
            label_trangthai_hocchunggv.Text = "Online";
            label_agehocchunggv.Text = "Age: " + kh.DoTuoi + "+";
            label_sotienhocchunggv.Text = kh.HocPhi.ToString("N0") + "đ";

            if (kh.HinhAnh != null)
            {
                pic_khoahoc.Image = kh.HinhAnh;
                pic_khoahoc.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }


        private void btn_exithocchunggv_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btn_back_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
