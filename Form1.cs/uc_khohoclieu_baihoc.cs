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
    public partial class uc_khohoclieu_baihoc : UserControl
    {
        private int soLuongChuong = 10;
        public uc_khohoclieu_baihoc()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            US_KhoHocLieuHS ucKhoaHoc = new US_KhoHocLieuHS();

            F_TrangChu frm = this.FindForm() as F_TrangChu;
            if (frm != null)
            {
                frm.LoadUC(ucKhoaHoc);
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

        private void LoadChuong(int soLuongChuong)
        {
            flowPanelMain2.Controls.Clear();

            for (int i = 1; i <= soLuongChuong; i++)
            {
                string tieuDe = $"Bài {i}: Tên bài ví dụ";
                uc_chuong uc = new uc_chuong(tieuDe);
                flowPanelMain2.Controls.Add(uc);
            }
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowPanelMain2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uc_khohoclieu_baihoc_Load(object sender, EventArgs e)
        {
            LoadChuong(10);
        }

        private void flowPanelMain2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelMain_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
