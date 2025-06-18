namespace form1.cs
{
    partial class uc_chuong
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
            btn_chuong = new Guna.UI2.WinForms.Guna2Button();
            label_tenchuong = new Label();
            SuspendLayout();
            // 
            // btn_chuong
            // 
            btn_chuong.BorderRadius = 30;
            btn_chuong.CustomizableEdges = customizableEdges1;
            btn_chuong.DisabledState.BorderColor = Color.DarkGray;
            btn_chuong.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_chuong.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_chuong.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_chuong.FillColor = Color.White;
            btn_chuong.Font = new Font("Segoe UI", 9F);
            btn_chuong.ForeColor = Color.White;
            btn_chuong.Location = new Point(0, 0);
            btn_chuong.Name = "btn_chuong";
            btn_chuong.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_chuong.Size = new Size(855, 72);
            btn_chuong.TabIndex = 1;
            btn_chuong.Click += btn_chuong_Click_1;
            // 
            // label_tenchuong
            // 
            label_tenchuong.AutoSize = true;
            label_tenchuong.BackColor = Color.White;
            label_tenchuong.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_tenchuong.Location = new Point(52, 23);
            label_tenchuong.Name = "label_tenchuong";
            label_tenchuong.Size = new Size(79, 31);
            label_tenchuong.TabIndex = 3;
            label_tenchuong.Text = "label1";
            label_tenchuong.Click += label_tenchuong_Click;
            // 
            // uc_chuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(label_tenchuong);
            Controls.Add(btn_chuong);
            Name = "uc_chuong";
            Size = new Size(855, 72);
            Load += uc_chuong_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_chuong;
        public Label label_tenchuong;
    }
}
