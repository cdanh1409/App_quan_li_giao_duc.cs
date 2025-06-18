using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace form1.cs
{
    public partial class US_KhoHocLieuHS : UserControl
    {
        private List<KhoaHoc> danhSachKhoaHoc = new List<KhoaHoc>();
        public US_KhoHocLieuHS()
        {
            InitializeComponent();
            LoadDanhSachKhoaHoc();
        }

        private void LoadDanhSachKhoaHoc()
        {
            var rawList = new List<(string ten, string gia, string tuoi, string danhGia, string duongDan)>()
    {
        ("Lập trình C cơ bản", "400.000đ", "13", "5.0", @"D:\visual\Form1.cs\form1.cs\Images\blog6.png"),
        ("Python nâng cao", "500.000đ", "15", "4.8", @"D:\visual\Form1.cs\form1.cs\Images\pthon.png"),
        ("Học SQL nâng cao", "350.000đ", "16", "4.9", @"D:\visual\Form1.cs\form1.cs\Images\sql.jpg"),
        ("Thiết kế Web", "300.000đ", "12", "4.7", @"D:\visual\Form1.cs\form1.cs\Images\htmlcss.png")
    };
            danhSachKhoaHoc.Clear();
            flowPanelMain1.Controls.Clear();

            foreach (var khoa in rawList)
            {
                if (File.Exists(khoa.duongDan))
                {
                    Image img = Image.FromFile(khoa.duongDan);
                    decimal hocPhi = ParsePrice(khoa.gia);
                    int doTuoi = int.TryParse(khoa.tuoi, out int age) ? age : 0;

                    KhoaHoc kh = new KhoaHoc(khoa.ten, hocPhi, doTuoi, khoa.danhGia, img);
                    danhSachKhoaHoc.Add(kh);

                    uc_kh khoaHocCtrl = new uc_kh(kh);
                    flowPanelMain1.Controls.Add(khoaHocCtrl);
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy ảnh: {khoa.duongDan}", "Lỗi ảnh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private decimal ParsePrice(string priceStr)
        {
            // "400.000đ" -> 400000
            string s = priceStr.Replace("đ", "").Replace(".", "").Trim();
            if (decimal.TryParse(s, out decimal result))
                return result;
            return 0;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // 🧠 Hàm tìm kiếm nhị phân
        public KhoaHoc TimKiemNhiPhan(List<KhoaHoc> danhSach, string tuKhoa)
        {
            int left = 0;
            int right = danhSach.Count - 1;

            tuKhoa = tuKhoa.ToLower();

            while (left <= right)
            {
                int mid = (left + right) / 2;
                string tenGiua = danhSach[mid].TenKhoaHoc.ToLower();

                int soSanh = string.Compare(tuKhoa, tenGiua);

                if (soSanh == 0)
                    return danhSach[mid];
                else if (soSanh < 0)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return null;
        }

        private void btn_found_Click(object sender, EventArgs e)
        {
            string tuKhoa = textbox_timkiem.Text.Trim();

            if (!string.IsNullOrEmpty(tuKhoa))
            {
                // 🔽 SẮP XẾP DANH SÁCH TRƯỚC KHI TÌM
                var danhSachSapXep = danhSachKhoaHoc
                    .OrderBy(kh => kh.TenKhoaHoc.ToLower())
                    .ToList();

                // 🔍 GỌI HÀM TÌM KIẾM
                KhoaHoc ketQua = TimKiemNhiPhan(danhSachSapXep, tuKhoa);

                // ✅ HIỂN THỊ KẾT QUẢ TRONG FLOWPANEL
                flowPanelMain1.Controls.Clear();

                if (ketQua != null)
                {
                    uc_kh khoaHocCtrl = new uc_kh(ketQua);
                    flowPanelMain1.Controls.Add(khoaHocCtrl);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khóa học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void flowPanelMain1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
