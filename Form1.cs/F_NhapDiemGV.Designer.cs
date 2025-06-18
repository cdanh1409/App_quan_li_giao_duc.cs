namespace form1.cs
{
    partial class F_NhapDiemGV
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_NhapDiemGV));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            label_Name = new Label();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            table_ten = new TableLayoutPanel();
            label_Tenbai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Label1_diemso = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btn_exithoccanhan = new Guna.UI2.WinForms.Guna2Button();
            btn_giohanghoccanhan = new Guna.UI2.WinForms.Guna2Button();
            btn_thongbaohoccanhan = new Guna.UI2.WinForms.Guna2Button();
            guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            table_ten.SuspendLayout();
            SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(label_Name);
            guna2GradientPanel1.Controls.Add(guna2CirclePictureBox1);
            guna2GradientPanel1.Controls.Add(table_ten);
            guna2GradientPanel1.Controls.Add(btn_exithoccanhan);
            guna2GradientPanel1.Controls.Add(btn_giohanghoccanhan);
            guna2GradientPanel1.Controls.Add(btn_thongbaohoccanhan);
            guna2GradientPanel1.CustomizableEdges = customizableEdges8;
            guna2GradientPanel1.FillColor = Color.FromArgb(0, 74, 173);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(203, 108, 230);
            guna2GradientPanel1.Location = new Point(0, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2GradientPanel1.Size = new Size(1443, 1080);
            guna2GradientPanel1.TabIndex = 8;
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.BackColor = Color.Transparent;
            label_Name.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Name.Location = new Point(808, 272);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(136, 54);
            label_Name.TabIndex = 33;
            label_Name.Text = "Name";
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.BackColor = Color.Transparent;
            guna2CirclePictureBox1.BackgroundImage = (Image)resources.GetObject("guna2CirclePictureBox1.BackgroundImage");
            guna2CirclePictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            guna2CirclePictureBox1.FillColor = Color.Transparent;
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(725, 53);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(289, 204);
            guna2CirclePictureBox1.TabIndex = 18;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // table_ten
            // 
            table_ten.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            table_ten.AutoScroll = true;
            table_ten.AutoSize = true;
            table_ten.BackColor = Color.Transparent;
            table_ten.ColumnCount = 2;
            table_ten.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table_ten.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table_ten.Controls.Add(label_Tenbai, 0, 0);
            table_ten.Controls.Add(Label1_diemso, 1, 0);
            table_ten.ForeColor = Color.Black;
            table_ten.Location = new Point(589, 364);
            table_ten.Name = "table_ten";
            table_ten.RowCount = 4;
            table_ten.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table_ten.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table_ten.RowStyles.Add(new RowStyle(SizeType.Absolute, 111F));
            table_ten.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
            table_ten.Size = new Size(519, 426);
            table_ten.TabIndex = 24;
            table_ten.Visible = false;
            table_ten.Paint += table_ten_Paint;
            // 
            // label_Tenbai
            // 
            label_Tenbai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_Tenbai.BackColor = Color.Transparent;
            label_Tenbai.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Tenbai.Location = new Point(3, 3);
            label_Tenbai.Name = "label_Tenbai";
            label_Tenbai.Size = new Size(210, 83);
            label_Tenbai.TabIndex = 34;
            label_Tenbai.Text = "Tên Bài";
            label_Tenbai.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // Label1_diemso
            // 
            Label1_diemso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Label1_diemso.BackColor = Color.Transparent;
            Label1_diemso.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1_diemso.Location = new Point(262, 3);
            Label1_diemso.Name = "Label1_diemso";
            Label1_diemso.Size = new Size(231, 83);
            Label1_diemso.TabIndex = 35;
            Label1_diemso.Text = "Điểm số";
            Label1_diemso.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btn_exithoccanhan
            // 
            btn_exithoccanhan.BackColor = Color.Transparent;
            btn_exithoccanhan.BackgroundImage = (Image)resources.GetObject("btn_exithoccanhan.BackgroundImage");
            btn_exithoccanhan.BackgroundImageLayout = ImageLayout.Stretch;
            btn_exithoccanhan.CustomizableEdges = customizableEdges2;
            btn_exithoccanhan.DisabledState.BorderColor = Color.DarkGray;
            btn_exithoccanhan.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_exithoccanhan.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_exithoccanhan.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_exithoccanhan.FillColor = Color.Transparent;
            btn_exithoccanhan.Font = new Font("Segoe UI", 9F);
            btn_exithoccanhan.ForeColor = Color.White;
            btn_exithoccanhan.Location = new Point(1364, 12);
            btn_exithoccanhan.Name = "btn_exithoccanhan";
            btn_exithoccanhan.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btn_exithoccanhan.Size = new Size(67, 56);
            btn_exithoccanhan.TabIndex = 23;
            // 
            // btn_giohanghoccanhan
            // 
            btn_giohanghoccanhan.BackColor = Color.Transparent;
            btn_giohanghoccanhan.BackgroundImage = (Image)resources.GetObject("btn_giohanghoccanhan.BackgroundImage");
            btn_giohanghoccanhan.BackgroundImageLayout = ImageLayout.Stretch;
            btn_giohanghoccanhan.BorderRadius = 30;
            btn_giohanghoccanhan.CustomizableEdges = customizableEdges4;
            btn_giohanghoccanhan.DisabledState.BorderColor = Color.DarkGray;
            btn_giohanghoccanhan.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_giohanghoccanhan.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_giohanghoccanhan.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_giohanghoccanhan.FillColor = Color.Transparent;
            btn_giohanghoccanhan.Font = new Font("Segoe UI", 9F);
            btn_giohanghoccanhan.ForeColor = Color.White;
            btn_giohanghoccanhan.Location = new Point(1151, 11);
            btn_giohanghoccanhan.Name = "btn_giohanghoccanhan";
            btn_giohanghoccanhan.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btn_giohanghoccanhan.Size = new Size(68, 56);
            btn_giohanghoccanhan.TabIndex = 22;
            // 
            // btn_thongbaohoccanhan
            // 
            btn_thongbaohoccanhan.BackColor = Color.Transparent;
            btn_thongbaohoccanhan.BackgroundImage = (Image)resources.GetObject("btn_thongbaohoccanhan.BackgroundImage");
            btn_thongbaohoccanhan.BackgroundImageLayout = ImageLayout.Stretch;
            btn_thongbaohoccanhan.CustomizableEdges = customizableEdges6;
            btn_thongbaohoccanhan.DisabledState.BorderColor = Color.DarkGray;
            btn_thongbaohoccanhan.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_thongbaohoccanhan.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_thongbaohoccanhan.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_thongbaohoccanhan.FillColor = Color.Transparent;
            btn_thongbaohoccanhan.Font = new Font("Segoe UI", 9F);
            btn_thongbaohoccanhan.ForeColor = Color.White;
            btn_thongbaohoccanhan.Location = new Point(1254, 12);
            btn_thongbaohoccanhan.Name = "btn_thongbaohoccanhan";
            btn_thongbaohoccanhan.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btn_thongbaohoccanhan.Size = new Size(71, 56);
            btn_thongbaohoccanhan.TabIndex = 21;
            // 
            // F_NhapDiemGV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1443, 1080);
            Controls.Add(guna2GradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "F_NhapDiemGV";
            Text = "Form24";
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            table_ten.ResumeLayout(false);
            table_ten.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btn_exithoccanhan;
        private Guna.UI2.WinForms.Guna2Button btn_giohanghoccanhan;
        private Guna.UI2.WinForms.Guna2Button btn_thongbaohoccanhan;
        private TableLayoutPanel table_ten;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label label_Name;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_Tenbai;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label1_diemso;
    }
}