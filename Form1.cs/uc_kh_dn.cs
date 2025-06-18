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
    public partial class uc_kh_dn : UserControl
    {
        private KhoaHoc khoaHoc;

        public uc_kh_dn(KhoaHoc kh)
        {
            InitializeComponent();
            this.khoaHoc = kh;

            pic_khoahoc_GV.Image = khoaHoc.HinhAnh;
            pic_khoahoc_GV.SizeMode = PictureBoxSizeMode.StretchImage;

            label_namekhoahoc_GV.Text = khoaHoc.TenKhoaHoc;
            label_sotienmua_GV.Text = khoaHoc.HocPhi.ToString("N0") + "đ";
            label_age_GV.Text = $"Age: {khoaHoc.DoTuoi}+";
            label_danhgia_GV.Text = khoaHoc.DanhGia;
        }

        private void uc_kh_dn_Load(object sender, EventArgs e)
        {
            // Nếu cần code chạy khi load Control, viết ở đây
        }
    }

}

