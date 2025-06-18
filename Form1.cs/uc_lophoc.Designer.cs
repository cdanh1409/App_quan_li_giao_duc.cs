namespace form1.cs
{
    partial class uc_lophoc
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
            btn_lop = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // btn_lop
            // 
            btn_lop.BackColor = Color.Transparent;
            btn_lop.BorderRadius = 20;
            btn_lop.CustomizableEdges = customizableEdges1;
            btn_lop.DisabledState.BorderColor = Color.DarkGray;
            btn_lop.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_lop.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_lop.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_lop.FillColor = Color.FromArgb(140, 82, 255);
            btn_lop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_lop.ForeColor = Color.White;
            btn_lop.Location = new Point(0, 0);
            btn_lop.Name = "btn_lop";
            btn_lop.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_lop.Size = new Size(483, 93);
            btn_lop.TabIndex = 32;
            btn_lop.Text = "12A1";
            btn_lop.Click += btn_lop_Click;
            // 
            // uc_lophoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_lop);
            Name = "uc_lophoc";
            Size = new Size(483, 93);
            ResumeLayout(false);
        }

        #endregion

        public Guna.UI2.WinForms.Guna2Button btn_lop;
    }
}
