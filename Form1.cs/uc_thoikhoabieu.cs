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
    public partial class uc_thoikhoabieu : UserControl
    {
        // Danh sách thời khóa biểu mẫu
        List<TKBItem> dsTKB = new List<TKBItem>()
        {
            new TKBItem { Thu = "Thứ 2", MonHoc = "Lập trình C cơ bản", Tiet = "1-4", Phong = "B-15.07", GiangVien = "Vẽ Lơ Kỳ Kào" },
            new TKBItem { Thu = "Thứ 3", MonHoc = "Toán rời rạc", Tiet = "5-8", Phong = "C-10.01", GiangVien = "Nguyễn Văn A" },
            new TKBItem { Thu = "Thứ 4", MonHoc = "Cơ sở dữ liệu", Tiet = "1-4", Phong = "B-11.04", GiangVien = "Trần Thị B" },
            new TKBItem { Thu = "Thứ 5", MonHoc = "Lập trình hướng đối tượng", Tiet = "5-8", Phong = "D-05.02", GiangVien = "Lê Văn C" },
            new TKBItem { Thu = "Thứ 6", MonHoc = "Mạng máy tính", Tiet = "1-4", Phong = "A-09.06", GiangVien = "Phạm Thị D" },
            new TKBItem { Thu = "Thứ 7", MonHoc = "Hệ điều hành", Tiet = "5-8", Phong = "B-12.07", GiangVien = "Đỗ Văn E" }
        };

        public uc_thoikhoabieu()
        {
            InitializeComponent();
            this.Load += uc_thoikhoabieu_Load; // Gọi hàm LoadTKB khi control được load
        }

        private void uc_thoikhoabieu_Load(object sender, EventArgs e)
        {
            LoadTKB(); // Hiển thị danh sách TKB từ Thứ 2 đến Thứ 7
        }

        // Hàm hiển thị danh sách thời khóa biểu lên flowLayoutPanel7
        private void LoadTKB()
        {
            flowLayoutPanel7.Controls.Clear(); // Xóa mục cũ

            foreach (var item in dsTKB)
            {
                uc_tkb tkbControl = new uc_tkb();
                tkbControl.label_thu.Text = item.Thu;
                tkbControl.label_thoikhoabieu.Text = item.MonHoc;
                tkbControl.label_Tiet.Text = item.Tiet;
                tkbControl.label_sophonghoc.Text = "Phòng: " + item.Phong;
                tkbControl.label_tengiangvien.Text = "GV: " + item.GiangVien;

                flowLayoutPanel7.Controls.Add(tkbControl);
            }
        }

        // Tuỳ chọn: sử dụng nếu muốn load thủ công usercontrol khác vào flowLayoutPanel7
        public void LoadThoiKhoaBieu(UserControl uc)
        {
            flowLayoutPanel7.Controls.Clear();
            flowLayoutPanel7.Controls.Add(uc);
        }

        private void flowLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {
            // Không cần xử lý gì ở đây
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
