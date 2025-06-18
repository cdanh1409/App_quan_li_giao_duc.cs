using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace form1.cs
{
    public partial class US_KhoaHocChung : UserControl
    {
        private List<KhoaHoc> danhSachKhoaHoc = new List<KhoaHoc>();

        public US_KhoaHocChung()
        {
            InitializeComponent();
            LoadDanhSachKhoaHoc();
        }

        private void LoadDanhSachKhoaHoc()
        {
            var rawList = new List<(string ten, string trangThai, int tienTrinh, int tuoi, string duongDanAnh)>
            {
                ("Lập trình C cơ bản", "online", 100, 13, @"D:\visual\Form1.cs\form1.cs\Images\blog6.png"),
                ("Python nâng cao", "online", 75, 15, @"D:\visual\Form1.cs\form1.cs\Images\pthon.png"),
                ("Học SQL nâng cao", "offline", 90, 16, @"D:\visual\Form1.cs\form1.cs\Images\sql.jpg"),
                ("Thiết kế Web", "online", 50, 12, @"D:\visual\Form1.cs\form1.cs\Images\htmlcss.png"),
            };

            flowLayoutPanel2.Controls.Clear();
            danhSachKhoaHoc.Clear();

            foreach (var item in rawList)
            {
                if (File.Exists(item.duongDanAnh))
                {
                    Image img = Image.FromFile(item.duongDanAnh);
                    var kh = new KhoaHoc(item.ten, item.trangThai, item.tienTrinh, item.tuoi, img);

                    danhSachKhoaHoc.Add(kh);

                    var khoaHocUC = new uc_tientrinh();
                    khoaHocUC.SetData(kh); // Phương thức bạn cần tạo trong uc_tientrinh
                    flowLayoutPanel2.Controls.Add(khoaHocUC);
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy ảnh: {item.duongDanAnh}", "Lỗi ảnh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
