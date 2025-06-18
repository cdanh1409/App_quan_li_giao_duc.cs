namespace form1.cs
{
    partial class uc_kh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_kh));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btn_khoahoc1 = new Guna.UI2.WinForms.Guna2Button();
            pic_khoahoc = new PictureBox();
            label_namekhoahoc = new Label();
            label_danhgia = new Label();
            label_ngoisao = new PictureBox();
            label_age = new Label();
            label_sotienmua = new Label();
            btn_Mota = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pic_khoahoc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)label_ngoisao).BeginInit();
            SuspendLayout();
            // 
            // btn_khoahoc1
            // 
            btn_khoahoc1.CustomizableEdges = customizableEdges1;
            btn_khoahoc1.DisabledState.BorderColor = Color.DarkGray;
            btn_khoahoc1.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_khoahoc1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_khoahoc1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_khoahoc1.FillColor = Color.White;
            btn_khoahoc1.Font = new Font("Segoe UI", 9F);
            btn_khoahoc1.ForeColor = Color.White;
            btn_khoahoc1.Location = new Point(0, 0);
            btn_khoahoc1.Name = "btn_khoahoc1";
            btn_khoahoc1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_khoahoc1.Size = new Size(309, 262);
            btn_khoahoc1.TabIndex = 28;
            btn_khoahoc1.Click += btn_khoahoc1_Click;
            // 
            // pic_khoahoc
            // 
            pic_khoahoc.BackgroundImageLayout = ImageLayout.Stretch;
            pic_khoahoc.Location = new Point(0, 0);
            pic_khoahoc.Name = "pic_khoahoc";
            pic_khoahoc.Size = new Size(309, 128);
            pic_khoahoc.TabIndex = 29;
            pic_khoahoc.TabStop = false;
            pic_khoahoc.Click += pic_khoahoc_Click;
            // 
            // label_namekhoahoc
            // 
            label_namekhoahoc.AutoSize = true;
            label_namekhoahoc.BackColor = Color.White;
            label_namekhoahoc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_namekhoahoc.Location = new Point(11, 141);
            label_namekhoahoc.Name = "label_namekhoahoc";
            label_namekhoahoc.Size = new Size(282, 28);
            label_namekhoahoc.TabIndex = 30;
            label_namekhoahoc.Text = "Lập trình ngôn ngữ C cơ bản";
            label_namekhoahoc.Click += label_namekhoahoc_Click;
            // 
            // label_danhgia
            // 
            label_danhgia.AutoSize = true;
            label_danhgia.BackColor = Color.White;
            label_danhgia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_danhgia.Location = new Point(50, 183);
            label_danhgia.Name = "label_danhgia";
            label_danhgia.Size = new Size(41, 28);
            label_danhgia.TabIndex = 32;
            label_danhgia.Text = "5.0";
            // 
            // label_ngoisao
            // 
            label_ngoisao.BackColor = Color.White;
            label_ngoisao.BackgroundImage = (Image)resources.GetObject("label_ngoisao.BackgroundImage");
            label_ngoisao.BackgroundImageLayout = ImageLayout.Stretch;
            label_ngoisao.Location = new Point(11, 183);
            label_ngoisao.Name = "label_ngoisao";
            label_ngoisao.Size = new Size(33, 29);
            label_ngoisao.TabIndex = 33;
            label_ngoisao.TabStop = false;
            // 
            // label_age
            // 
            label_age.AutoSize = true;
            label_age.BackColor = Color.White;
            label_age.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_age.Location = new Point(207, 228);
            label_age.Name = "label_age";
            label_age.Size = new Size(98, 28);
            label_age.TabIndex = 34;
            label_age.Text = "Age: 13+";
            // 
            // label_sotienmua
            // 
            label_sotienmua.AutoSize = true;
            label_sotienmua.BackColor = Color.White;
            label_sotienmua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_sotienmua.ForeColor = Color.Red;
            label_sotienmua.Location = new Point(11, 228);
            label_sotienmua.Name = "label_sotienmua";
            label_sotienmua.Size = new Size(89, 28);
            label_sotienmua.TabIndex = 35;
            label_sotienmua.Text = "400.000";
            // 
            // btn_Mota
            // 
            btn_Mota.BackColor = Color.Transparent;
            btn_Mota.BackgroundImage = (Image)resources.GetObject("btn_Mota.BackgroundImage");
            btn_Mota.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Mota.CustomizableEdges = customizableEdges3;
            btn_Mota.DisabledState.BorderColor = Color.DarkGray;
            btn_Mota.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Mota.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Mota.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Mota.FillColor = Color.Transparent;
            btn_Mota.Font = new Font("Segoe UI", 9F);
            btn_Mota.ForeColor = Color.White;
            btn_Mota.Location = new Point(264, 3);
            btn_Mota.Name = "btn_Mota";
            btn_Mota.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_Mota.Size = new Size(41, 39);
            btn_Mota.TabIndex = 36;
            btn_Mota.Click += btn_Mota_Click;
            // 
            // uc_kh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_Mota);
            Controls.Add(label_sotienmua);
            Controls.Add(label_age);
            Controls.Add(label_ngoisao);
            Controls.Add(label_danhgia);
            Controls.Add(label_namekhoahoc);
            Controls.Add(pic_khoahoc);
            Controls.Add(btn_khoahoc1);
            Name = "uc_kh";
            Size = new Size(309, 262);
            ((System.ComponentModel.ISupportInitialize)pic_khoahoc).EndInit();
            ((System.ComponentModel.ISupportInitialize)label_ngoisao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_khoahoc1;
        private Label label_namekhoahoc;
        private Label label_danhgia;
        private PictureBox label_ngoisao;
        private Label label_age;
        private Label label_sotienmua;
        private PictureBox pic_khoahoc;
        private Guna.UI2.WinForms.Guna2Button btn_Mota;
    }
}
