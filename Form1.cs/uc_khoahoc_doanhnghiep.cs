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
    public partial class uc_khoahoc_doanhnghiep : UserControl
    {
        private List<KhoaHoc> danhSachKhoaHoc = new List<KhoaHoc>();

        public uc_khoahoc_doanhnghiep()
        {
            InitializeComponent();
            LoadDanhSachKhoaHoc();

        }
        public void LoadUC(UserControl uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
            uc.BringToFront();
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
            flowPanelMain10.Controls.Clear();

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
                    flowPanelMain10.Controls.Add(khoaHocCtrl);
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
        private void flowPanelMain10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_exithocchunggv_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
