namespace form1.cs
{
    partial class uc_tkb
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
            btn_luachon1 = new Guna.UI2.WinForms.Guna2Button();
            label_thu = new Label();
            label_Tiet = new Label();
            label_thoikhoabieu = new Label();
            label_sophonghoc = new Label();
            label_tengiangvien = new Label();
            SuspendLayout();
            // 
            // btn_luachon1
            // 
            btn_luachon1.BackColor = Color.Transparent;
            btn_luachon1.BorderRadius = 45;
            btn_luachon1.CustomizableEdges = customizableEdges1;
            btn_luachon1.DisabledState.BorderColor = Color.DarkGray;
            btn_luachon1.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_luachon1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_luachon1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_luachon1.FillColor = Color.FromArgb(140, 82, 255);
            btn_luachon1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_luachon1.ForeColor = Color.White;
            btn_luachon1.Location = new Point(3, 0);
            btn_luachon1.Name = "btn_luachon1";
            btn_luachon1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_luachon1.Size = new Size(1213, 122);
            btn_luachon1.TabIndex = 27;
            btn_luachon1.Click += btn_luachon1_Click;
            // 
            // label_thu
            // 
            label_thu.AutoSize = true;
            label_thu.BackColor = Color.FromArgb(140, 82, 255);
            label_thu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_thu.Location = new Point(146, 11);
            label_thu.Name = "label_thu";
            label_thu.Size = new Size(99, 41);
            label_thu.TabIndex = 35;
            label_thu.Text = "Thứ 2";
            // 
            // label_Tiet
            // 
            label_Tiet.AutoSize = true;
            label_Tiet.BackColor = Color.FromArgb(140, 82, 255);
            label_Tiet.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Tiet.Location = new Point(157, 68);
            label_Tiet.Name = "label_Tiet";
            label_Tiet.Size = new Size(64, 41);
            label_Tiet.TabIndex = 36;
            label_Tiet.Text = "1-4";
            // 
            // label_thoikhoabieu
            // 
            label_thoikhoabieu.AutoSize = true;
            label_thoikhoabieu.BackColor = Color.FromArgb(140, 82, 255);
            label_thoikhoabieu.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_thoikhoabieu.Location = new Point(618, 8);
            label_thoikhoabieu.Name = "label_thoikhoabieu";
            label_thoikhoabieu.Size = new Size(475, 46);
            label_thoikhoabieu.TabIndex = 37;
            label_thoikhoabieu.Text = "Lập trình ngôn ngữ C cơ bản";
            label_thoikhoabieu.Click += label_thoikhoabieu_Click;
            // 
            // label_sophonghoc
            // 
            label_sophonghoc.AutoSize = true;
            label_sophonghoc.BackColor = Color.FromArgb(140, 82, 255);
            label_sophonghoc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_sophonghoc.Location = new Point(570, 78);
            label_sophonghoc.Name = "label_sophonghoc";
            label_sophonghoc.Size = new Size(163, 28);
            label_sophonghoc.TabIndex = 38;
            label_sophonghoc.Text = "Phòng:  B-15.07";
            label_sophonghoc.Click += label_sophonghoc_Click;
            // 
            // label_tengiangvien
            // 
            label_tengiangvien.AutoSize = true;
            label_tengiangvien.BackColor = Color.FromArgb(140, 82, 255);
            label_tengiangvien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_tengiangvien.Location = new Point(960, 81);
            label_tengiangvien.Name = "label_tengiangvien";
            label_tengiangvien.Size = new Size(173, 28);
            label_tengiangvien.TabIndex = 39;
            label_tengiangvien.Text = "GV: Vễ Lo Ky Kào";
            // 
            // uc_tkb
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label_tengiangvien);
            Controls.Add(label_sophonghoc);
            Controls.Add(label_thoikhoabieu);
            Controls.Add(label_Tiet);
            Controls.Add(label_thu);
            Controls.Add(btn_luachon1);
            Name = "uc_tkb";
            Size = new Size(1213, 122);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_luachon1;
        public Label label_thu;
        public Label label_Tiet;
        public Label label_thoikhoabieu;
        public Label label_sophonghoc;
        public Label label_tengiangvien;
    }
}
