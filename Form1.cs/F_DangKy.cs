using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1.cs
{
    public partial class F_DangKy : Form
    {
        private List<string> danhSachTaiKhoan = new List<string> { "admin", "test", "user1" };
        private bool KiemTraTaiKhoanTrung(string tenTaiKhoan)
        {
            return danhSachTaiKhoan.Contains(tenTaiKhoan);
        }

        private bool KiemTraMatKhauHopLe(string password)
        {
            if (password.Length < 6)
                return false;

            bool coChuHoa = password.Any(char.IsUpper);
            bool coSo = password.Any(char.IsDigit);
            bool coKyTuDacBiet = password.Any(ch => !char.IsLetterOrDigit(ch));

            return coChuHoa && coSo && coKyTuDacBiet;
        }

        private void LuuTaiKhoanMoi(string ten, string matkhau)
        {
            danhSachTaiKhoan.Add(ten);
            Console.WriteLine($"Tài khoản mới: {ten} - {matkhau}");
        }

        public F_DangKy()
        {
            InitializeComponent();

            guna_Email.Enter += guna_Email_Enter;
            guna_Email.Leave += guna_Email_Leave;

            // Khởi tạo placeholder
            guna_Email.Text = "Email:";
            guna_Email.ForeColor = Color.Black;

            // Thiết lập placeholder cho mật khẩu
            guna_Matkhau.Text = "Mật khẩu:";
            guna_Matkhau.ForeColor = Color.Black;
            guna_Matkhau.UseSystemPasswordChar = false;

            // Gán sự kiện
            guna_Matkhau.Enter += guna_Matkhau_Enter;
            guna_Matkhau.Leave += guna_Matkhau_Leave;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna_Tentaikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {

        }

        private void btn_register_Click_1(object sender, EventArgs e)
        {

        }

        private void guna_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_daco_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_microsorf_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "https://login.microsoftonline.com/",
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_register_Click_2(object sender, EventArgs e)
        {
            string taiKhoan = guna_Tentaikhoan.Text.Trim();
            string matKhau = guna_Matkhau.Text;

            if (string.IsNullOrWhiteSpace(taiKhoan) || taiKhoan == "Tên tài khoản:" ||
                string.IsNullOrWhiteSpace(matKhau) || matKhau == "Mật khẩu:")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (KiemTraTaiKhoanTrung(taiKhoan))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại. Vui lòng chọn tên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!KiemTraMatKhauHopLe(matKhau))
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự, bao gồm chữ hoa, số và ký tự đặc biệt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LuuTaiKhoanMoi(taiKhoan, matKhau);

            MessageBox.Show("Đăng ký thành công! Vui lòng đăng nhập.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            F_Login form1 = new F_Login();
            form1.Show();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Login form1 = new F_Login();
            form1.Show();
        }

        private void btn_google_Click(object sender, EventArgs e)
        {

        }

        private void btn_github_Click(object sender, EventArgs e)
        {

        }

        private void label_nentang_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
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

        private void guna_Tentaikhoan_Enter(object sender, EventArgs e)
        {
            if (guna_Tentaikhoan.Text.Trim().StartsWith("Tên tài khoản:"))
            {
                guna_Tentaikhoan.Text = "";
                guna_Tentaikhoan.ForeColor = Color.Black; // Khi người dùng gõ thì chữ đen
            }
        }

        private void guna_Tentaikhoan_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna_Email_Enter(object sender, EventArgs e)
        {
            if (guna_Email.Text == "Email:")
            {
                guna_Email.Text = "";
                guna_Email.ForeColor = Color.Black;
            }
        }

        private void guna_Email_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna_Email.Text))
            {
                guna_Email.Text = "Email:";
                guna_Email.ForeColor = Color.Black;
            }
        }


        private void guna_Matkhau_Enter(object sender, EventArgs e)
        {
            if (guna_Matkhau.Text == "Mật khẩu:")
            {
                guna_Matkhau.Text = "";
                guna_Matkhau.ForeColor = Color.Black;
                guna_Matkhau.UseSystemPasswordChar = true; // Bắt đầu ẩn ký tự khi người dùng nhập
            }
        }

        private void guna_Matkhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna_Matkhau.Text))
            {
                guna_Matkhau.Text = "Mật khẩu:";
                guna_Matkhau.ForeColor = Color.Black;
                guna_Matkhau.UseSystemPasswordChar = false; // Không ẩn khi hiển thị placeholder
            }
        }


        private void guna_Matkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna_Email_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel_login_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
