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
    public partial class uc_khoahoc_tientrinh : UserControl
    {
        public uc_khoahoc_tientrinh()
        {
            InitializeComponent();
        }

        private void label_namekhoahoc_Click(object sender, EventArgs e)
        {

        }

        private void label_phantram_Click(object sender, EventArgs e)
        {

        }

        private void pic_khoahoc_Click(object sender, EventArgs e)
        {

        }

        public void SetData(string ten, string trangThai, string phanTram, string doTuoi, Image hinh)
        {
            label_namekhoahoc.Text = ten;
            label_trangthai.Text = trangThai;
            label_phantram.Text = phanTram;
            label_age.Text = doTuoi;
            pic_khoahoc.Image = hinh;
            pic_khoahoc.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_khoahoc2_Click(object sender, EventArgs e)
        {

        }
    }
}
