namespace form1.cs
{
    partial class Form3
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            panel_login = new Guna.UI2.WinForms.Guna2Panel();
            label_quenmk2 = new Label();
            label_Quenmk = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label_quenmk1 = new Label();
            guna_nhaptkhoacemail = new Guna.UI2.WinForms.Guna2TextBox();
            btn_xacnhan = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            guna2GradientPanel1.SuspendLayout();
            panel_login.SuspendLayout();
            SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(panel_login);
            guna2GradientPanel1.CustomizableEdges = customizableEdges7;
            guna2GradientPanel1.Dock = DockStyle.Fill;
            guna2GradientPanel1.FillColor = Color.FromArgb(0, 74, 173);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(203, 108, 230);
            guna2GradientPanel1.Location = new Point(0, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2GradientPanel1.Size = new Size(1920, 1080);
            guna2GradientPanel1.TabIndex = 0;
            // 
            // panel_login
            // 
            panel_login.BackColor = Color.Transparent;
            panel_login.BorderRadius = 60;
            panel_login.BorderThickness = 4;
            panel_login.Controls.Add(label_quenmk2);
            panel_login.Controls.Add(label_Quenmk);
            panel_login.Controls.Add(label_quenmk1);
            panel_login.Controls.Add(guna_nhaptkhoacemail);
            panel_login.Controls.Add(btn_xacnhan);
            panel_login.Controls.Add(label2);
            panel_login.CustomizableEdges = customizableEdges5;
            panel_login.FillColor = Color.White;
            panel_login.Location = new Point(1015, 290);
            panel_login.Name = "panel_login";
            panel_login.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panel_login.Size = new Size(687, 470);
            panel_login.TabIndex = 1;
            // 
            // label_quenmk2
            // 
            label_quenmk2.AutoSize = true;
            label_quenmk2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_quenmk2.Location = new Point(84, 177);
            label_quenmk2.Name = "label_quenmk2";
            label_quenmk2.Size = new Size(522, 28);
            label_quenmk2.TabIndex = 22;
            label_quenmk2.Text = "Chúng tôi sẽ gửi cho bạn liên kết để đặt lại mật khẩu.";
            // 
            // label_Quenmk
            // 
            label_Quenmk.AutoSize = false;
            label_Quenmk.AutoSizeHeightOnly = true;
            label_Quenmk.BackColor = Color.Transparent;
            label_Quenmk.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Quenmk.Location = new Point(114, 30);
            label_Quenmk.Name = "label_Quenmk";
            label_Quenmk.Size = new Size(434, 82);
            label_Quenmk.TabIndex = 17;
            label_Quenmk.Text = "Quên mật khẩu";
            // 
            // label_quenmk1
            // 
            label_quenmk1.AutoSize = true;
            label_quenmk1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_quenmk1.Location = new Point(38, 133);
            label_quenmk1.Name = "label_quenmk1";
            label_quenmk1.Size = new Size(599, 28);
            label_quenmk1.TabIndex = 21;
            label_quenmk1.Text = "Vui lòng nhập tên đăng nhập hoặc email đã đăng ký của bạn. ";
            // 
            // guna_nhaptkhoacemail
            // 
            guna_nhaptkhoacemail.BorderColor = Color.FromArgb(140, 82, 255);
            guna_nhaptkhoacemail.BorderRadius = 17;
            guna_nhaptkhoacemail.BorderThickness = 3;
            guna_nhaptkhoacemail.CustomizableEdges = customizableEdges1;
            guna_nhaptkhoacemail.DefaultText = "Nhập Tên Đăng Nhập Hoặc Email*:";
            guna_nhaptkhoacemail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna_nhaptkhoacemail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna_nhaptkhoacemail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna_nhaptkhoacemail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna_nhaptkhoacemail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna_nhaptkhoacemail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna_nhaptkhoacemail.ForeColor = Color.Black;
            guna_nhaptkhoacemail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna_nhaptkhoacemail.Location = new Point(52, 242);
            guna_nhaptkhoacemail.Margin = new Padding(6, 8, 6, 8);
            guna_nhaptkhoacemail.Name = "guna_nhaptkhoacemail";
            guna_nhaptkhoacemail.PlaceholderText = "";
            guna_nhaptkhoacemail.SelectedText = "";
            guna_nhaptkhoacemail.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna_nhaptkhoacemail.Size = new Size(585, 69);
            guna_nhaptkhoacemail.TabIndex = 16;
            // 
            // btn_xacnhan
            // 
            btn_xacnhan.BorderRadius = 20;
            btn_xacnhan.CustomizableEdges = customizableEdges3;
            btn_xacnhan.DisabledState.BorderColor = Color.DarkGray;
            btn_xacnhan.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_xacnhan.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_xacnhan.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_xacnhan.FillColor = Color.FromArgb(140, 82, 255);
            btn_xacnhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_xacnhan.ForeColor = Color.White;
            btn_xacnhan.Location = new Point(52, 356);
            btn_xacnhan.Name = "btn_xacnhan";
            btn_xacnhan.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_xacnhan.Size = new Size(585, 56);
            btn_xacnhan.TabIndex = 20;
            btn_xacnhan.Text = "Xác nhận";
            btn_xacnhan.Click += btn_xacnhan_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(140, 82, 255);
            label2.Location = new Point(449, 814);
            label2.Name = "label2";
            label2.Size = new Size(294, 31);
            label2.TabIndex = 15;
            label2.Text = "____________________________";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1920, 1080);
            Controls.Add(guna2GradientPanel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            TransparencyKey = Color.Black;
            guna2GradientPanel1.ResumeLayout(false);
            panel_login.ResumeLayout(false);
            panel_login.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Panel panel_login;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox guna_nhaptkhoacemail;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_Quenmk;
        private Guna.UI2.WinForms.Guna2Button btn_xacnhan;
        private Label label_quenmk1;
        private Label label_quenmk2;
    }
}