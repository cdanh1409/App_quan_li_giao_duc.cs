using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace form1.cs
{
    public partial class uc_caclophoc : UserControl
    {
        // Danh sách tên các lớp học
        List<string> dsLop = new List<string>()
        {
            "12A1", "12A2", "12A3", "11A1", "11A2", "10A1"
        };

        public uc_caclophoc()
        {
            InitializeComponent();
            this.Load += uc_caclophoc_Load;
        }

        // Khi user control được load
        private void uc_caclophoc_Load(object sender, EventArgs e)
        {
            LoadDanhSachLop();
        }

        // Hàm hiển thị danh sách lớp học lên FlowLayoutPanel
        private void LoadDanhSachLop()
        {
            flowLayoutPanel12.Controls.Clear(); // Xoá lớp cũ nếu có

            foreach (var tenLop in dsLop)
            {
                // Tạo control lớp học
                uc_lophoc uc = new uc_lophoc();
                uc.btn_lop.Text = tenLop; // Gán tên lớp lên button

                // Gắn sự kiện click (tuỳ chọn)
                uc.btn_lop.Click += (s, e) =>
                {
                    MessageBox.Show($"Bạn đã chọn lớp {tenLop}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Có thể mở form khác, hoặc load chi tiết lớp tại đây
                };

                flowLayoutPanel12.Controls.Add(uc); // Thêm vào giao diện
            }
        }

        // Tuỳ chọn: load thủ công 1 usercontrol khác nếu muốn
        public void LoadUserControl(UserControl uc)
        {
            flowLayoutPanel12.Controls.Clear();
            flowLayoutPanel12.Controls.Add(uc);
        }
        
        private void flowLayoutPanel12_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
