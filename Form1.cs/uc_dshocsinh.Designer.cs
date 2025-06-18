namespace form1.cs
{
    partial class uc_dshocsinh
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
            btn_tendemGV = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // btn_tendemGV
            // 
            btn_tendemGV.BackColor = Color.Transparent;
            btn_tendemGV.BorderColor = Color.White;
            btn_tendemGV.BorderRadius = 20;
            btn_tendemGV.CustomizableEdges = customizableEdges1;
            btn_tendemGV.DisabledState.BorderColor = Color.DarkGray;
            btn_tendemGV.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_tendemGV.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_tendemGV.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_tendemGV.FillColor = Color.FromArgb(140, 82, 255);
            btn_tendemGV.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_tendemGV.ForeColor = Color.Black;
            btn_tendemGV.ImageAlign = HorizontalAlignment.Left;
            btn_tendemGV.Location = new Point(-3, 0);
            btn_tendemGV.Name = "btn_tendemGV";
            btn_tendemGV.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_tendemGV.Size = new Size(1227, 56);
            btn_tendemGV.TabIndex = 33;
            btn_tendemGV.Text = "BÉ Kỳ Cute";
            btn_tendemGV.TextAlign = HorizontalAlignment.Left;
            // 
            // uc_lophoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_tendemGV);
            Name = "uc_lophoc";
            Size = new Size(1227, 56);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_tendemGV;
    }
}
