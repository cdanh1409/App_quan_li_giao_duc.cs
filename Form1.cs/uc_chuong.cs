using System;
using System.Windows.Forms;

namespace form1.cs
{
    public partial class uc_chuong : UserControl
    {
        // 🔹 Constructor có tham số
        public uc_chuong(string tieuDe)
        {
            InitializeComponent();

            // Gán vào property
            TieuDe = tieuDe;

            // Gắn sự kiện click
            btn_chuong.Click += btn_chuong_Click;
        }

        private void btn_chuong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã click vào bài học!");
        }


        // 🔹 Public property để truy cập tiêu đề chương
        public string TieuDe
        {
            get => label_tenchuong.Text;
            set => label_tenchuong.Text = value;
        }

        private void label_tenchuong_Click(object sender, EventArgs e) { }
        private void uc_chuong_Load(object sender, EventArgs e) { }
        private void btn_chuong_Click_1(object sender, EventArgs e) { }
    }
}
