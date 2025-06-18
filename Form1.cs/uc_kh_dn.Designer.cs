namespace form1.cs
{
    partial class uc_kh_dn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_kh_dn));
            pic_khoahoc_GV = new PictureBox();
            label_namekhoahoc_GV = new Label();
            label_danhgia_GV = new Label();
            label_ngoisao_GV = new PictureBox();
            label_sotienmua_GV = new Label();
            label_age_GV = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_khoahoc_GV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)label_ngoisao_GV).BeginInit();
            SuspendLayout();
            // 
            // pic_khoahoc_GV
            // 
            pic_khoahoc_GV.BackgroundImageLayout = ImageLayout.Stretch;
            pic_khoahoc_GV.Location = new Point(0, 0);
            pic_khoahoc_GV.Name = "pic_khoahoc_GV";
            pic_khoahoc_GV.Size = new Size(309, 128);
            pic_khoahoc_GV.TabIndex = 30;
            pic_khoahoc_GV.TabStop = false;
            // 
            // label_namekhoahoc_GV
            // 
            label_namekhoahoc_GV.AutoSize = true;
            label_namekhoahoc_GV.BackColor = Color.White;
            label_namekhoahoc_GV.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_namekhoahoc_GV.Location = new Point(11, 141);
            label_namekhoahoc_GV.Name = "label_namekhoahoc_GV";
            label_namekhoahoc_GV.Size = new Size(282, 28);
            label_namekhoahoc_GV.TabIndex = 31;
            label_namekhoahoc_GV.Text = "Lập trình ngôn ngữ C cơ bản";
            // 
            // label_danhgia_GV
            // 
            label_danhgia_GV.AutoSize = true;
            label_danhgia_GV.BackColor = Color.White;
            label_danhgia_GV.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_danhgia_GV.Location = new Point(50, 183);
            label_danhgia_GV.Name = "label_danhgia_GV";
            label_danhgia_GV.Size = new Size(41, 28);
            label_danhgia_GV.TabIndex = 33;
            label_danhgia_GV.Text = "5.0";
            // 
            // label_ngoisao_GV
            // 
            label_ngoisao_GV.BackColor = Color.White;
            label_ngoisao_GV.BackgroundImage = (Image)resources.GetObject("label_ngoisao_GV.BackgroundImage");
            label_ngoisao_GV.BackgroundImageLayout = ImageLayout.Stretch;
            label_ngoisao_GV.Location = new Point(11, 183);
            label_ngoisao_GV.Name = "label_ngoisao_GV";
            label_ngoisao_GV.Size = new Size(33, 29);
            label_ngoisao_GV.TabIndex = 34;
            label_ngoisao_GV.TabStop = false;
            // 
            // label_sotienmua_GV
            // 
            label_sotienmua_GV.AutoSize = true;
            label_sotienmua_GV.BackColor = Color.White;
            label_sotienmua_GV.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_sotienmua_GV.ForeColor = Color.Red;
            label_sotienmua_GV.Location = new Point(11, 228);
            label_sotienmua_GV.Name = "label_sotienmua_GV";
            label_sotienmua_GV.Size = new Size(89, 28);
            label_sotienmua_GV.TabIndex = 36;
            label_sotienmua_GV.Text = "400.000";
            // 
            // label_age_GV
            // 
            label_age_GV.AutoSize = true;
            label_age_GV.BackColor = Color.White;
            label_age_GV.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_age_GV.Location = new Point(207, 228);
            label_age_GV.Name = "label_age_GV";
            label_age_GV.Size = new Size(98, 28);
            label_age_GV.TabIndex = 37;
            label_age_GV.Text = "Age: 13+";
            // 
            // uc_kh_dn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label_age_GV);
            Controls.Add(label_sotienmua_GV);
            Controls.Add(label_ngoisao_GV);
            Controls.Add(label_danhgia_GV);
            Controls.Add(label_namekhoahoc_GV);
            Controls.Add(pic_khoahoc_GV);
            Name = "uc_kh_dn";
            Size = new Size(309, 262);
            Load += uc_kh_dn_Load;
            ((System.ComponentModel.ISupportInitialize)pic_khoahoc_GV).EndInit();
            ((System.ComponentModel.ISupportInitialize)label_ngoisao_GV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_khoahoc_GV;
        private Label label_namekhoahoc_GV;
        private Label label_danhgia_GV;
        private PictureBox label_ngoisao_GV;
        private Label label_sotienmua_GV;
        private Label label_age_GV;
    }
}
