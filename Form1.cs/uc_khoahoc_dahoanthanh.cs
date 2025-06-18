using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1.cs
{
    public partial class uc_khoahoc_dahoanthanh : UserControl
    {
        public uc_khoahoc_dahoanthanh()
        {
            InitializeComponent();
        }
        private void uc_khoahoc_dahoanthanh_Load(object sender, EventArgs e)
        {
            List<KhoaHoc> danhSach = new List<KhoaHoc>()
    {
        new KhoaHoc() { Ten = "C", Diem = 0, Hinh = @"D:\\visual\\Form1.cs\\form1.cs\\Images\\blog6.png\" },
        new KhoaHoc() { Ten = "Python cơ bản", Diem = 0, Hinh = @"D:\visual\Form1.cs\form1.cs\Images\pthon.png" },
        new KhoaHoc() { Ten = "HTML/CSS", Diem = 0, Hinh = @"D:\visual\Form1.cs\form1.cs\Images\htmlcss.png" },
        new KhoaHoc() { Ten = "SQL", Diem = 0, Hinh = @"D:\visual\Form1.cs\form1.cs\Images\sql.jpg" },
       // new KhoaHoc() { Ten = "Java", Diem = 4, Hinh = @"D:\\visual\\Form1.cs\\form1.cs\\Images\\blog6.png\" },
    };
          
            flowPanelMain5.Controls.Clear();

            foreach (var kh in danhSach)
            {
                var uc = new uc_khoahochoanthanh();
                uc.label_namekhoahoc.Text = kh.Ten;
                uc.Rating = kh.Diem; // Fixed: Use the 'Rating' property instead of 'SetRating'
                if (System.IO.File.Exists(kh.Hinh))
                {
                    uc.pic_khoahoc.Image = Image.FromFile(kh.Hinh);
                }
                flowPanelMain5.Controls.Add(uc);
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
        private void flowPanelMain5_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LoadDanhSachKhoaHocDaHoanThanh()
        {
            List<KhoaHoc> danhSach = new List<KhoaHoc>()
            {
                new KhoaHoc() { Ten = "Lập trình C cơ bản", Diem = 0, Hinh = @"D:\visual\\Form1.cs\\form1.cs\\Images\\blog6.png" },
                new KhoaHoc() { Ten = "Python cơ bản", Diem = 0, Hinh = @"D:\visual\Form1.cs\form1.cs\Images\pthon.png" },
                new KhoaHoc() { Ten = "HTML/CSS", Diem = 0, Hinh = @"D:\visual\Form1.cs\form1.cs\Images\htmlcss.png" },
                new KhoaHoc() { Ten = "SQL", Diem = 0, Hinh = @"D:\visual\Form1.cs\form1.cs\Images\sql.jpg" },
            };

            flowPanelMain5.Controls.Clear();

            foreach (var kh in danhSach)
            {
                var uc = new uc_khoahochoanthanh();
                uc.SetData(kh.Ten, "Đã hoàn thành", 100, kh.Diem, kh.Hinh);
                flowPanelMain5.Controls.Add(uc);
            }
        }

    }
}
