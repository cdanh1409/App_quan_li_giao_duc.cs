using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace form1.cs
{
    public partial class F_TrangChuGV : Form
    {
        private List<Guna2Button> menuButtons;

        public F_TrangChuGV()
        {
            InitializeComponent();
            InitializeMenuButtons();
        }

        private void InitializeMenuButtons()
        {
            // Gán các nút vào danh sách
            menuButtons = new List<Guna2Button>()
            {
                btn_trangchu_GV,
                btn_lophoc,
                btn_cuocthi_GV,
                btn_taokhoahoc,
                btn_thoikhoabieu,
                btn_hosocuatoi_GV,
                btn_khoahoc_lop,
                btn_khoahoc_doanhnghiep,
                btn_dangxuat
            };

            // Gán sự kiện Click cho từng nút
            btn_trangchu_GV.Click += btn_trangchu_GV_Click;
            btn_lophoc.Click += btn_lophoc_Click;
            btn_cuocthi_GV.Click += btn_cuocthi_GV_Click;
            btn_taokhoahoc.Click += btn_taokhoahoc_Click;
            btn_thoikhoabieu.Click += btn_thoikhoabieu_Click;
            btn_hosocuatoi_GV.Click += btn_hosocuatoi_GV_Click;
            btn_khoahoc_lop.Click += btn_khoahoc_lop_Click;
            btn_khoahoc_doanhnghiep.Click += btn_khoahoc_doanhnghiep_Click;
            btn_dangxuat.Click += btn_dangxuat_Click;
        }

        private void SetActiveButton(Guna2Button activeButton)
        {
            foreach (var btn in menuButtons)
            {
                btn.ForeColor = Color.Black;
            }
            activeButton.ForeColor = Color.Blue;
        }

        private void LoadControl(UserControl uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
            uc.BringToFront();
        }

        // ================== Các sự kiện Click ===================
        private void btn_trangchu_GV_Click(object sender, EventArgs e)
        {
            SetActiveButton(btn_trangchu_GV);
            LoadControl(new UC_TrangChu_GV()); // ví dụ nếu bạn có UserControl trang chủ
        }
        private void btn_cuocthi_GV_Click(object sender, EventArgs e)
        {
            SetActiveButton(btn_cuocthi_GV);
        }
        private void btn_thoikhoabieu_Click(object sender, EventArgs e)
        {
            SetActiveButton(btn_thoikhoabieu);
        }

        private void btn_hosocuatoi_GV_Click(object sender, EventArgs e)
        {
            SetActiveButton(btn_hosocuatoi_GV);
        }

        private void btn_khoahoc_lop_Click(object sender, EventArgs e)
        {
            SetActiveButton(btn_khoahoc_lop);
            LoadControl(new uc_khoahoc_lop());
        }

        private void btn_khoahoc_doanhnghiep_Click(object sender, EventArgs e)
        {
            SetActiveButton(btn_khoahoc_doanhnghiep);
            LoadControl(new uc_khoahoc_doanhnghiep());
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            // Xử lý đăng xuất
            Application.Exit();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            // Không cần xử lý gì ở đây nếu không custom giao diện
        }

        private void btn_lophoc_Click(object sender, EventArgs e)
        {
            SetActiveButton(btn_lophoc);
            LoadControl(new uc_caclophoc());
        }

        private void btn_taokhoahoc_Click(object sender, EventArgs e)
        {
            SetActiveButton(btn_taokhoahoc);
            LoadControl(new uc_taokhoahoc());

        }
    }
}
