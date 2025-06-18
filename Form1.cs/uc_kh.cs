using System;
using System.Drawing;
using System.Windows.Forms;
using form1.cs;
using static System.Windows.Forms.DataFormats;

namespace form1.cs
{
    public partial class uc_kh : UserControl
    {
        // Khai báo ở đầu class (ngoài các phương thức)
        private uc_khohoclieu_baihoc uc_khohoclieu_baihoc;

        private KhoaHoc khoaHoc;

        public uc_kh(KhoaHoc kh)
        {
            InitializeComponent();
            khoaHoc = kh;

            pic_khoahoc.Image = kh.HinhAnh;
            pic_khoahoc.SizeMode = PictureBoxSizeMode.StretchImage;

            label_namekhoahoc.Text = kh.TenKhoaHoc;
            label_sotienmua.Text = kh.HocPhi.ToString("N0") + "đ";
            label_age.Text = $"Age: {kh.DoTuoi}+";
            label_danhgia.Text = kh.DanhGia;
        }

        private void btn_Mota_Click(object sender, EventArgs e)
        {
            F_MoTa formMoTa = new F_MoTa(khoaHoc);
            formMoTa.Show();

            // Lấy form cha của usercontrol
            Form parentForm = this.FindForm();

            // Tạo form mô tả truyền dữ liệu khóa học hiện tại (nếu cần)
            // giả sử F_MoTa có constructor nhận KhoaHoc

            // Ẩn form cha
            parentForm.Hide();

            // Khi form mô tả đóng, hiện lại form cha
            formMoTa.FormClosed += (s, args) =>
            {
                parentForm.Show();
            };

            // Hiển thị form mô tả
            formMoTa.Show();
        }

        public string TenKhoaHoc => label_namekhoahoc.Text;

        private void pic_khoahoc_Click(object sender, EventArgs e)
        {
             pic_khoahoc.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btn_khoahoc1_Click(object sender, EventArgs e)
        {
            uc_khohoclieu_baihoc ucBaiHoc = new uc_khohoclieu_baihoc();

            F_TrangChu frm = this.FindForm() as F_TrangChu;
            if (frm != null)
            {
                frm.LoadUC(ucBaiHoc);
            }
            //// Gọi phương thức từ Form cha
            //F_TrangChu parentForm = this.FindForm() as F_TrangChu;
            //if (parentForm != null)
            //{
            //    parentForm.ChuyenSangKhoaHocLieu();
            //}
        }

        private void label_namekhoahoc_Click(object sender, EventArgs e)
        {

        }
        // Thêm phương thức này vào class F_TrangChu


    }
}
