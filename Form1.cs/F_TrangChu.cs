using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms; // Đảm bảo bạn đã thêm using này để nhận diện Guna2Button

namespace form1.cs
{
    public partial class F_TrangChu : Form
    {
        // Marking the field as readonly since it is only initialized in the constructor and not modified elsewhere.
        private readonly List<Guna2Button> menuButtons;

        public F_TrangChu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            // Khởi tạo danh sách các nút
            menuButtons = new List<Guna2Button>()
            {
                btn_trangchu,
                btn_khohoclieu,
                btn_khoahocchung,
                btn_diemso,
                btn_khoahochoanthanh,
                btn_thoikhoabieu,
                btn_hosocuatoi,
                btn_cuocthi,
                btn_dangxuat
            };

            // Đăng ký sự kiện cho các nút
            btn_trangchu.Click += btn_trangchu_Click;
            btn_khohoclieu.Click += btn_khohoclieu_Click;
            btn_khoahocchung.Click += btn_khoahocchung_Click;
            btn_khoahochoanthanh.Click += btn_khoahochoanthanh_Click;
            btn_diemso.Click += btn_diemso_Click;
            btn_thoikhoabieu.Click += btn_thoikhoabieu_Click;
            btn_hosocuatoi.Click += btn_hosocuatoi_Click;
            btn_cuocthi.Click += btn_cuocthi_Click;
            btn_dangxuat.Click += btn_dangxuat_Click;
        }

        // Load một UserControl vào panelMain
        private void LoadControl(UserControl uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
            uc.BringToFront();
        }

        // Đổi màu cho nút đang được chọn
        private void SetActiveButton(Guna2Button activeButton)
        {
            foreach (var btn in menuButtons)
            {
                btn.ForeColor = Color.Black;
            }
            activeButton.ForeColor = Color.Blue;
        }

        // Sự kiện từng nút
        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            SetActiveButton(btn_trangchu);
            LoadControl(new UC_TrangChu());
        }

        private void btn_khohoclieu_Click(object sender, EventArgs e)
        {
            SetActiveButton(btn_khohoclieu);
            LoadControl(new US_KhoHocLieuHS());
        }

        private void btn_khoahocchung_Click(object sender, EventArgs e)
        {
            SetActiveButton(btn_khoahocchung);
            LoadControl(new US_KhoaHocChung());
            // LoadControl(new UC_KhoaHocChung());
        }
        private void btn_khoahochoanthanh_Click(object sender, EventArgs e)
        {
            SetActiveButton(btn_khoahochoanthanh);
            uc_khoahoc_dahoanthanh uc = new uc_khoahoc_dahoanthanh();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc);

            // Gọi hàm load danh sách khóa học hoàn thành (nếu có)
            uc.LoadDanhSachKhoaHocDaHoanThanh();
        }
        private void btn_diemso_Click(object sender, EventArgs e)
        {
            SetActiveButton(btn_diemso);
            LoadControl(new uc_diemso());

        }

        private void btn_thoikhoabieu_Click(object sender, EventArgs e)
        {
            SetActiveButton(btn_thoikhoabieu);
            LoadControl(new uc_thoikhoabieu());
            uc_thoikhoabieu ucTKBView = new uc_thoikhoabieu();

            // Tạo uc_tkb
            uc_tkb tkbControl = new uc_tkb();

            // Gọi hàm load dữ liệu trong uc_thoikhoabieu
            ucTKBView.LoadThoiKhoaBieu(tkbControl);

            // Hiển thị uc_thoikhoabieu trong panelMain
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucTKBView);
            ucTKBView.Dock = DockStyle.Fill;
        }

        private void btn_hosocuatoi_Click(object sender, EventArgs e)
        {
            SetActiveButton(btn_hosocuatoi);
            LoadControl(new uc_hosocuatoi());
        }

        private void btn_cuocthi_Click(object sender, EventArgs e)
        {
            SetActiveButton(btn_cuocthi);
            LoadControl(new uc_cuocthi());
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            SetActiveButton(btn_dangxuat);

            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                F_Login loginForm = new F_Login();
                loginForm.Show(); // Mở form đăng nhập

                this.Close(); // Đóng form hiện tại
            }
        }

        public void ChuyenSangKhoaHocLieu()
        {
            // Ví dụ: nạp UserControl uc_khohoclieu_baihoc vào panelMain
            var uc = new uc_khohoclieu_baihoc();
            LoadControl(uc);
            SetActiveButton(btn_khohoclieu); // Nếu có nút này
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMain_Paint_1(object sender, PaintEventArgs e)
        {

        }

        public void LoadUC(UserControl uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void btn_khoahocchung_Click_1(object sender, EventArgs e)
        {
            // Xóa các control cũ trong panelMain
            panelMain.Controls.Clear();

            // Tạo mới UC_KhoaHocChung
            US_KhoaHocChung uc = new US_KhoaHocChung();

            // Dock để nó fill toàn bộ panel
            uc.Dock = DockStyle.Fill;

            // Thêm UC vào panelMain
            panelMain.Controls.Add(uc);
        }
        public void LoadUserControl(UserControl uc)
        {
            panelMain.Controls.Clear();     // panelMain là panel bạn chứa UC
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void btn_dangxuat_Click_1(object sender, EventArgs e)
        {

        }
    }
}
