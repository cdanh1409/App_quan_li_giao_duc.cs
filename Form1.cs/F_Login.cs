using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;


namespace form1.cs
{
    public partial class F_Login : Form
    {
        public F_Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            this.AcceptButton = btn_login;
            guna_Tentaikhoan.TabStop = true;
            guna_Tentaikhoan.TabIndex = 0;

            guna_Matkhau.TabStop = true;
            guna_Matkhau.TabIndex = 1;

            btn_login.TabStop = true;
            btn_login.TabIndex = 2;

        }
        private void guna_Matkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.PerformClick(); // Gọi sự kiện đăng nhập
            }
        }
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label_chaomung2_Click(object sender, EventArgs e)
        {

        }

        private void label_hoac_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn Form1 đi
            F_DangKy form2 = new F_DangKy(); // Tạo form đăng ký mới
            form2.Show(); // Mở Form2
        }

        private void guna2HtmlLabel1_Click_2(object sender, EventArgs e)
        {

        }

        private void guna_Tentaikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void radio_GV_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_github_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/login", // link đăng nhập GitHub
                UseShellExecute = true
            });
        }

        private void btn_google_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://accounts.google.com/signin", // link đăng nhập Google
                UseShellExecute = true
            });
        }

        private void btn_microsorf_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://login.microsoftonline.com/", // link đăng nhập Microsoft
                UseShellExecute = true
            });
        }

        private void btn_quenmk_Click(object sender, EventArgs e)
        {
            // Ẩn Form1
            this.Hide();

            // Mở Form4
            F_QuenMk form4 = new F_QuenMk();
            form4.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // Kiểm tra tên tài khoản
            if (string.IsNullOrWhiteSpace(guna_Tentaikhoan.Text) || guna_Tentaikhoan.Text == "Tên tài khoản:")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                guna_Tentaikhoan.Focus();
                return;
            }

            // Kiểm tra mật khẩu
            if (string.IsNullOrWhiteSpace(guna_Matkhau.Text) || guna_Matkhau.Text == "Mật khẩu:")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                guna_Matkhau.Focus();
                return;
            }

            // Kiểm tra đã chọn Giáo viên hoặc Học sinh
            if (!radio_GiaoVien.Checked && !radio_HocSinh.Checked)
            {
                MessageBox.Show("Vui lòng chọn vai trò (Giáo viên hoặc Học sinh).", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu tất cả hợp lệ, xử lý đăng nhập
            string taiKhoan = guna_Tentaikhoan.Text;
            string matKhau = guna_Matkhau.Text;
            string vaiTro = radio_GiaoVien.Checked ? "Giáo viên" : "Học sinh";

            // TODO: Thực hiện kiểm tra tài khoản mật khẩu ở đây

            MessageBox.Show($"Đăng nhập thành công với vai trò: {vaiTro}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Mở form F_Trangchu
            if (radio_GiaoVien.Checked)
            {
                F_TrangChuGV formGV = new F_TrangChuGV();
                formGV.Show();
            }
            else if (radio_HocSinh.Checked)
            {
                F_TrangChu formHS = new F_TrangChu();
                formHS.Show();
            }

            this.Hide(); // Ẩn form đăng nhập

        }


        private void guna_Matkhau_TextChanged(object sender, EventArgs e)
        {
            // Nếu text không trống và khác placeholder thì bật UseSystemPasswordChar
            if (!string.IsNullOrEmpty(guna_Matkhau.Text) && guna_Matkhau.Text != "Mật khẩu:")
            {
                guna_Matkhau.UseSystemPasswordChar = true;
            }
        }

        private void panel_hinhnen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_nentang_Click(object sender, EventArgs e)
        {

        }


        private void guna_Tentaikhoan_Enter(object sender, EventArgs e)
        {
            if (guna_Tentaikhoan.Text.Trim().StartsWith("Tên tài khoản:"))
            {
                guna_Tentaikhoan.Text = "";
                guna_Tentaikhoan.ForeColor = Color.Black; // Khi người dùng gõ thì chữ đen
            }
        }

        private void guna_Tentaikhoan_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna_Tentaikhoan.Text))
            {
                guna_Tentaikhoan.Text = "Tên tài khoản:";
                guna_Tentaikhoan.ForeColor = Color.Black; // Nếu để trống thì hiện lại placeholder
            }

        }

        private void guna_Matkhau_Enter(object sender, EventArgs e)
        {
            if (guna_Matkhau.Text == "Mật khẩu:")
            {
                guna_Matkhau.Text = "";
                guna_Matkhau.ForeColor = Color.Black;
                // Không bật UseSystemPasswordChar ở đây vội
            }
        }


        private void guna_Matkhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna_Matkhau.Text))
            {
                guna_Matkhau.UseSystemPasswordChar = false; // Không che nếu trống
                guna_Matkhau.Text = "Mật khẩu:";
                guna_Matkhau.ForeColor = Color.Black;
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
    }
}
