namespace form1.cs
{
    partial class uc_khoahoc_tientrinh
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btn_khoahoc2 = new Guna.UI2.WinForms.Guna2Button();
            label_namekhoahoc = new Label();
            pic_khoahoc = new PictureBox();
            label_trangthai = new Label();
            label_tientrinh = new Label();
            label_age = new Label();
            label_phantram = new Label();
            label_tuoi = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_khoahoc).BeginInit();
            SuspendLayout();
            // 
            // btn_khoahoc2
            // 
            btn_khoahoc2.CustomizableEdges = customizableEdges1;
            btn_khoahoc2.DisabledState.BorderColor = Color.DarkGray;
            btn_khoahoc2.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_khoahoc2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_khoahoc2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_khoahoc2.FillColor = Color.White;
            btn_khoahoc2.Font = new Font("Segoe UI", 9F);
            btn_khoahoc2.ForeColor = Color.White;
            btn_khoahoc2.Location = new Point(0, 0);
            btn_khoahoc2.Name = "btn_khoahoc2";
            btn_khoahoc2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_khoahoc2.Size = new Size(309, 262);
            btn_khoahoc2.TabIndex = 29;
            btn_khoahoc2.Click += btn_khoahoc2_Click;
            // 
            // label_namekhoahoc
            // 
            label_namekhoahoc.AutoSize = true;
            label_namekhoahoc.BackColor = Color.White;
            label_namekhoahoc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_namekhoahoc.Location = new Point(11, 141);
            label_namekhoahoc.Name = "label_namekhoahoc";
            label_namekhoahoc.Size = new Size(282, 28);
            label_namekhoahoc.TabIndex = 31;
            label_namekhoahoc.Text = "Lập trình ngôn ngữ C cơ bản";
            label_namekhoahoc.Click += label_namekhoahoc_Click;
            // 
            // pic_khoahoc
            // 
            pic_khoahoc.BackgroundImageLayout = ImageLayout.Stretch;
            pic_khoahoc.Location = new Point(0, 0);
            pic_khoahoc.Name = "pic_khoahoc";
            pic_khoahoc.Size = new Size(309, 128);
            pic_khoahoc.TabIndex = 32;
            pic_khoahoc.TabStop = false;
            pic_khoahoc.Click += pic_khoahoc_Click;
            // 
            // label_trangthai
            // 
            label_trangthai.AutoSize = true;
            label_trangthai.BackColor = Color.White;
            label_trangthai.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_trangthai.Location = new Point(11, 179);
            label_trangthai.Name = "label_trangthai";
            label_trangthai.Size = new Size(74, 28);
            label_trangthai.TabIndex = 33;
            label_trangthai.Text = "Online";
            // 
            // label_tientrinh
            // 
            label_tientrinh.AutoSize = true;
            label_tientrinh.BackColor = Color.White;
            label_tientrinh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_tientrinh.ForeColor = Color.Red;
            label_tientrinh.Location = new Point(11, 217);
            label_tientrinh.Name = "label_tientrinh";
            label_tientrinh.Size = new Size(116, 28);
            label_tientrinh.TabIndex = 36;
            label_tientrinh.Text = "Tiến trình :";
            // 
            // label_age
            // 
            label_age.AutoSize = true;
            label_age.BackColor = Color.White;
            label_age.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_age.Location = new Point(259, 218);
            label_age.Name = "label_age";
            label_age.Size = new Size(50, 28);
            label_age.TabIndex = 38;
            label_age.Text = "13+";
            // 
            // label_phantram
            // 
            label_phantram.AutoSize = true;
            label_phantram.BackColor = Color.White;
            label_phantram.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_phantram.Location = new Point(133, 215);
            label_phantram.Name = "label_phantram";
            label_phantram.Size = new Size(60, 31);
            label_phantram.TabIndex = 39;
            label_phantram.Text = "80%";
            label_phantram.Click += label_phantram_Click;
            // 
            // label_tuoi
            // 
            label_tuoi.AutoSize = true;
            label_tuoi.BackColor = Color.White;
            label_tuoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_tuoi.Location = new Point(216, 217);
            label_tuoi.Name = "label_tuoi";
            label_tuoi.Size = new Size(49, 28);
            label_tuoi.TabIndex = 40;
            label_tuoi.Text = "Age";
            // 
            // uc_khoahoc_tientrinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label_tuoi);
            Controls.Add(label_phantram);
            Controls.Add(label_age);
            Controls.Add(label_tientrinh);
            Controls.Add(label_trangthai);
            Controls.Add(pic_khoahoc);
            Controls.Add(label_namekhoahoc);
            Controls.Add(btn_khoahoc2);
            Name = "uc_khoahoc_tientrinh";
            Size = new Size(309, 262);
            ((System.ComponentModel.ISupportInitialize)pic_khoahoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_khoahoc2;
        private Label label_namekhoahoc;
        private PictureBox pic_khoahoc;
        private Label label_trangthai;
        private Label label_tientrinh;
        private Label label_age;
        private Label label_phantram;
        private Label label_tuoi;
    }
}
