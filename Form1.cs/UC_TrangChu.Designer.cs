namespace form1.cs
{
    partial class UC_TrangChu
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
            panelMain = new Guna.UI2.WinForms.Guna2GradientPanel();
            label_chaomung3 = new Label();
            label_chaomung4 = new Label();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(label_chaomung3);
            panelMain.Controls.Add(label_chaomung4);
            panelMain.CustomizableEdges = customizableEdges1;
            panelMain.FillColor = Color.FromArgb(0, 74, 173);
            panelMain.FillColor2 = Color.FromArgb(203, 108, 230);
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelMain.Size = new Size(1446, 1080);
            panelMain.TabIndex = 4;
            panelMain.Paint += panelMain_Paint;
            // 
            // label_chaomung3
            // 
            label_chaomung3.AutoSize = true;
            label_chaomung3.BackColor = Color.Transparent;
            label_chaomung3.Font = new Font("Segoe UI", 64.2000046F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_chaomung3.ForeColor = Color.White;
            label_chaomung3.Location = new Point(793, 487);
            label_chaomung3.Name = "label_chaomung3";
            label_chaomung3.Size = new Size(296, 145);
            label_chaomung3.TabIndex = 1;
            label_chaomung3.Text = "-*/*-";
            // 
            // label_chaomung4
            // 
            label_chaomung4.AutoSize = true;
            label_chaomung4.BackColor = Color.Transparent;
            label_chaomung4.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_chaomung4.ForeColor = Color.White;
            label_chaomung4.Location = new Point(171, 287);
            label_chaomung4.Name = "label_chaomung4";
            label_chaomung4.Size = new Size(1210, 159);
            label_chaomung4.TabIndex = 0;
            label_chaomung4.Text = "Chào mừng đến với ";
            // 
            // UC_TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMain);
            Name = "UC_TrangChu";
            Size = new Size(1446, 1033);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel panelMain;
        private Label label_chaomung3;
        private Label label_chaomung4;
    }
}
